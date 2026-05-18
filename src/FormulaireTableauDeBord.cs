using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
using UserControlPlanetes;

namespace SAE24
{
    public partial class FrmTableauDeBord : Form
    {
        SQLiteConnection co;
        public FrmTableauDeBord()
        {
            InitializeComponent();
        }

        private void FrmTableauDeBord_Load(object sender, EventArgs e)
        {
            RemplissageDS();
            AjoutRelation();
        }

        private void UpdateDataSet()
        {
            MesDatas.DsGlobal.Clear();
            co = Connexion.Connec;
            try
            {
                DataTable mesDT = co.GetSchema("Tables");

                foreach (DataRow r in mesDT.Rows)
                {
                    string request = $"SELECT * FROM {r[2].ToString()}";
                    SQLiteCommand cmd = new SQLiteCommand(request, co);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Update(MesDatas.DsGlobal, r[2].ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Connexion.FermerConnexion(); }
        }

        private void RemplissageDS()
        {
            co = Connexion.Connec;
            try
            {
                DataTable mesDT = co.GetSchema("Tables");

                foreach (DataRow r in mesDT.Rows)
                {
                    string request = $"SELECT * FROM {r[2].ToString()}";
                    SQLiteCommand cmd = new SQLiteCommand(request, co);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(MesDatas.DsGlobal, r[2].ToString());
                }   
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Connexion.FermerConnexion(); }
        }

        private void AjoutRelation()
        {
            try
            {
                // Relations Tableau de bord
                MesDatas.DsGlobal.Relations.Add("FK_Militaire_Chef", MesDatas.DsGlobal.Tables["Militaire"].Columns["matriculeMembre"], MesDatas.DsGlobal.Tables["Mission"].Columns["matriculeChef"]);
                MesDatas.DsGlobal.Relations.Add("FK_Membre_Militaire", MesDatas.DsGlobal.Tables["Membre"].Columns["matricule"], MesDatas.DsGlobal.Tables["Militaire"].Columns["matriculeMembre"]);
                MesDatas.DsGlobal.Relations.Add("FK_Membre_Civil", MesDatas.DsGlobal.Tables["Membre"].Columns["matricule"], MesDatas.DsGlobal.Tables["Civil"].Columns["matriculeMembre"]);
                MesDatas.DsGlobal.Relations.Add("FK_Membre_Composer", MesDatas.DsGlobal.Tables["Membre"].Columns["matricule"], MesDatas.DsGlobal.Tables["Composer"].Columns["matriculeMembre"]);
                DataColumn[] missionPK = new DataColumn[] { MesDatas.DsGlobal.Tables["Mission"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Mission"].Columns["numero"] };
                DataColumn[] depensePK = new DataColumn[] { MesDatas.DsGlobal.Tables["Depense"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Depense"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_Depense", missionPK, depensePK);
                DataColumn[] composer = new DataColumn[] { MesDatas.DsGlobal.Tables["Composer"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Composer"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_Composer", missionPK, composer);
                DataColumn[] objectifCapture = new DataColumn[] { MesDatas.DsGlobal.Tables["ObjectifCapture"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["ObjectifCapture"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_ObjectifCapture", missionPK, objectifCapture);
                MesDatas.DsGlobal.Relations.Add("FK_Espece_ObjectifCapture", MesDatas.DsGlobal.Tables["Espece"].Columns["id"] , MesDatas.DsGlobal.Tables["ObjectifCapture"].Columns["idEspeceEnnemi"]);

                // Relations Planètes
                
                // nom (Planete) <-> nomPlanete (Habiter)
                MesDatas.DsGlobal.Relations.Add("FK_Planete_Habiter", MesDatas.DsGlobal.Tables["Planete"].Columns["nom"], MesDatas.DsGlobal.Tables["Habiter"].Columns["nomPlanete"]);
                // id (Espece) <-> idEspece (Habiter)
                MesDatas.DsGlobal.Relations.Add("FK_Espece_Habiter", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Habiter"].Columns["idEspece"]);

                // nom (Planete) <-> nomPlanete (Mission)
                MesDatas.DsGlobal.Relations.Add("FK_Planete_Mission", MesDatas.DsGlobal.Tables["Planete"].Columns["nom"], MesDatas.DsGlobal.Tables["Mission"].Columns["nomPlanete"]);                

            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
        private void ActualisationTDB()
        {
            int top = 20, left = 20;
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                string nomMission = r["NomPlanete"].ToString() + r["numero"].ToString();
                string strDateDepart = r["dateDepart"].ToString();
                DateTime dateRetour = DateTime.Parse(r["dateRetour"].ToString());
                DateTime dateDepart = DateTime.Parse(r["dateDepart"].ToString());
                TimeSpan duree = dateRetour.Subtract(dateDepart);
                string strDuree = duree.ToString("dd");
                string grade = r.GetParentRow("FK_Militaire_Chef")[1].ToString();
                string identite = $"{r.GetParentRow("FK_Militaire_Chef").GetParentRow("FK_Membre_Militaire")[1].ToString()} {r.GetParentRow("FK_Militaire_Chef").GetParentRow("FK_Membre_Militaire")[2].ToString()}";
                string chef = $"{identite} : {grade}";


                MissionResume mr = new MissionResume(nomMission, strDateDepart, strDuree, chef);
                mr.Top = top;
                mr.Left = left;
                pnlTDB.Controls.Add(mr);

                top += mr.Height + 20;
            }
        }
        private void btnTDB_Click(object sender, EventArgs e)
        {
            pnlTDB.Controls.Clear();
            ActualisationTDB();
        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                UpdateDataSet();
                AjoutRelation();
                ActualisationTDB();
            }
        }

        private void btnRaces_Click(object sender, EventArgs e)
        {

        }

        private void btnPlanetes_Click(object sender, EventArgs e)
        {
            // Mise à jour
            pnlTDB.Controls.Clear();
            Int32 left = 0;
            int nbPlaneteOnScreen = 0;
            // Parcours de la table pour récupérer toutes les infos nécessaires
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Planete"].Rows)
            {
                // Récupération des chaînes de caractères
                string nomPlanete = r["nom"].ToString();
                string temp = r["temperature"].ToString();
                string gravite = r["gravite"].ToString();
                string presenceDatabaz = r["dataBazON"].ToString();


                // Récupération du chemin des images

                // Pour les planètes
                // La fonction replace permete de remplacer les espaces présents dans 'la 9e planete' pour quon' puisse afficher la bonne image correspondante
                string nomImageP = nomPlanete.Replace(" ", "");
                string nomImagePlanete = $"../../Images/Planetes/{nomImageP}.png";

                // Pour la température
                string nomImageTemp;
                Int32 valueTemp = 0;
                int xOut;

                
                // Si la valeur est positive, on reprend simplement la valeur obtenue en la castant
                if (!r["temperature"].ToString().Contains("-"))
                {
                    // On vérifie qu'on puisse bien la convertir
                    if (Int32.TryParse(r["temperature"].ToString(), out xOut))
                    {
                        // Si oui, on affecte la valeur dans valueTemp
                        valueTemp = xOut;
                    }
                    else
                    {
                        // Sinon, on renvoie un string vide indiquant que la température est inconnue
                        nomImageTemp = "";
                    }
                }
                // Si la température est négative
                else if (r["temperature"].ToString().Contains("-"))
                {
                    string valuePositive = "";
                    // On parcourt la chaîne de caractères APRES le signe moins ('-')
                    for (int i = 1; i < r["temperature"].ToString().Length; i++)
                    {
                        // On affecte ces valeurs dans la variable temporaire
                        valuePositive += r["temperature"].ToString()[i];
                    }
                    // On les convertit en entier pour obtenir la valeur absolue
                    valueTemp = Int32.Parse(valuePositive);

                    // Comme le nombre original est négatif, on le multiplie par -1 pour inverser son signe
                    valueTemp *= -1;

                }
                
                // Affichage en conséquence
                // Température froide
                if (valueTemp <= 5)
                {
                    nomImageTemp = $"../../Images/Temperature/Froid.png";
                }
                // Température medium
                else if (valueTemp > 5 && valueTemp < 100)
                {
                    nomImageTemp = $"../../Images/Temperature/Medium.png";
                }
                // Température chaude
                else if (valueTemp > 100)
                {
                    nomImageTemp = $"../../Images/Temperature/Chaud.png";
                }
                else
                {
                    nomImageTemp = "";
                }


                // Initialisation des listes

                // Pour les espèces :
                List<string> listeEspeces = new List<string>();

                
                DataRow[] espece = r.GetChildRows("FK_Planete_Habiter");

                foreach (DataRow dr in espece)
                {
                    if (dr.GetParentRow("FK_Espece_Habiter") != null)
                    {
                        listeEspeces.Add(dr.GetParentRow("FK_Espece_Habiter")[1].ToString());
                    }
                    
                }
                

                // Pour les missions :
                List<string> listeMissions = new List<string>();

                DataRow[] mission = r.GetChildRows("FK_Planete_Mission");
                foreach(DataRow dr in mission)
                {
                    if (dr[0] != null)
                    {
                        listeMissions.Add(dr[0].ToString() + dr[1]);
                    }
                }

                // Création de l'UserControl en le surchargeant
                UserControlPlanete u = new UserControlPlanete(nomImagePlanete, nomImageTemp, nomPlanete, temp, gravite, presenceDatabaz, listeEspeces, listeMissions, 20, 80);

                // Gérer la taille du UserControl (réduire sa taille comme celle par défaut est trop grande)
                u.Width = u.Width - 100;
                nbPlaneteOnScreen++;

                // Affichage séparée
                u.Left = left;
                left += u.Width + 225;

                // Ajout de l'UserControl dans le panel du tableau de bord
                pnlTDB.Controls.Add(u);
            }

        }

        

        private void FrmTableauDeBord_Shown(object sender, EventArgs e)
        {
            //Chargement();
            foreach (Button b in Controls.OfType<Button>())
            {
                b.Visible = true;
            }
            pbChargement.Visible = false;
        }

        private void Chargement()
        {
            pbChargement.Value = 0;
            System.Threading.Thread.Sleep(1000);
            pbChargement.Value = 13;
            System.Threading.Thread.Sleep(1500);
            pbChargement.Value = 21;
            System.Threading.Thread.Sleep(500);
            pbChargement.Value = 34;
            System.Threading.Thread.Sleep(250);
            pbChargement.Value = 55;
            System.Threading.Thread.Sleep(1000);
            pbChargement.Value = 89;
            System.Threading.Thread.Sleep(500);
            pbChargement.Value = 100;
        }
    }
}
