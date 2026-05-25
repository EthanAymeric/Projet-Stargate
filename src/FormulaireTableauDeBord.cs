using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlPlanetes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
            InfosPlanetes();
            InfosEspeces();
            ChargementComboBoxes();
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

                // id (Espece) <-> idEspece (Allie)
                MesDatas.DsGlobal.Relations.Add("FK_Espece_Allie", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Allie"].Columns["idEspece"]);

                // id (Espece) <-> idEspece (Ennemi)
                MesDatas.DsGlobal.Relations.Add("FK_Espece_Ennemi", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Ennemi"].Columns["idEspece"]);

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
            
            pnlTDB.Visible = true;
            pnlPlanetes.Visible = false;
            pnlEspeces.Visible = false;
            pnlAllies.Visible = false;
            pnlEnnemis.Visible = false;
            grpEspeces.Visible = false;

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
            pnlTDB.Visible = false;
            pnlPlanetes.Visible = false;
            pnlEspeces.Visible = true;
            pnlAllies.Visible = false;
            pnlEnnemis.Visible = false;
            grpEspeces.Visible = true;
        }

        private void btnPlanetes_Click(object sender, EventArgs e)
        {
            pnlTDB.Visible = false;
            pnlPlanetes.Visible = true;
            pnlEspeces.Visible = false;
            pnlAllies.Visible = false;
            pnlEnnemis.Visible = false;
            grpEspeces.Visible = false;
        }

        private void InfosEspeces()
        {
            // Préparation du panel pour la recherche des espèces
            
            pnlEspeces.Controls.Clear();
            pnlEspeces.Visible = false;
            grpEspeces.Visible = false;
            pnlAllies.Visible = false;
            pnlEnnemis.Visible = false;
            rdbAllies.Checked = false;
            rdbEnnemis.Checked = false;

            // Initialisation des paramètres de placement du UserControl
            Int32 top = 0;
            Int32 left = 0;

            // Initialisation des éléments pour la recherche (avec ou sans filtre)
            DataRow[] tab;
            DataTable dt;
            bool filtreEstPresent = false;
            bool resultatExiste = true;

            // S'il y a un filtre à appliquer, on prend ce qui est indiqué dans la combobox pour créer un filtr
            if (ckCouleur.Checked)
            {
                string filtre = "couleur = '" + cboCouleur.SelectedValue + "'";
                tab = MesDatas.DsGlobal.Tables["Espece"].Select(filtre);
                // on copie la table filtrée dans une DataTable
                dt = tab.CopyToDataTable();
                // Si la recherche spécifiée ne marche pas, on l'indique
                if (dt.Rows.Count == 0)
                {
                    resultatExiste = false;
                }
                else
                {
                    dt.TableName = "Filtre";
                }
                filtreEstPresent = true;
            }
            // Sinon on récupère simplement les données directements depuis le DataSet local
            else
            {
                dt = MesDatas.DsGlobal.Tables["Espece"];
            }

            // Si la recherche spécifiée ne marche pas, on l'indique
            if (!resultatExiste)
            {
                Label error = afficherMessageErreurEspece();
                pnlEspeces.Controls.Add(error);
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {

                    // Ajout des informations pour toutes les espèces (générales)
                    // Ajout du lien de l'image correspondant à l'espèce
                    string nomImageEspece = "";

                    // Ajout du nom de l'espèce
                    string nomEspece = r["nom"].ToString();

                    // Ajout de sa couleur
                    string couleur = r["couleur"].ToString();

                    // Liste de la (des) planète(s) sur laquelle (lesquelles) l'espèce vit
                    List<string> listePlanetes = new List<string>();

                    // Si un filtre est présent, on traite la sélection des planètes différemment comme on n'a pas de relations avec la table filtrée
                    if (filtreEstPresent)
                    {
                        // On parcourt la table Habiter
                        DataTable planete = MesDatas.DsGlobal.Tables["Habiter"];

                        foreach (DataRow dr in planete.Rows)
                        {
                            // Si cela correspond à l'élément présent dans le filtre, on le rajoute
                            if (dr[1].ToString() == r["id"].ToString())
                            {
                                listePlanetes.Add(dr[0].ToString());
                            }
                        }
                    }
                    // Sinon, on traite l'affichage des planètes normalement :
                    else
                    {
                        // On parcourt les planètes et on les affiche toutes en les reliant aux bonnes espèces
                        DataRow[] planete = r.GetChildRows("FK_Espece_Habiter");

                        foreach (DataRow dr in planete)
                        {
                            if (dr.GetParentRow("FK_Planete_Habiter")[0] != null)
                            {
                                listePlanetes.Add(dr.GetParentRow("FK_Planete_Habiter")[0].ToString());
                            }

                        }
                    }

                    // Création de l'UserControl en le surchargeant 
                    UserControlEspeces u = new UserControlEspeces(nomImageEspece, nomEspece, couleur, listePlanetes);


                    // Affichage des UserControl les uns en-dessous des autres
                    u.Top = top;
                    u.Left = left;

                    left += u.Width;

                    if (left > pnlEspeces.Width)
                    {
                        top += u.Height;
                        left = 0;
                    }


                    // Ajout de l'UserControl dans le panel du tableau de bord
                    pnlEspeces.Controls.Add(u);
                }
            }
        }

        private void InfosPlanetes()
        {
            pnlPlanetes.Visible = false;
            Int32 top = 0;

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
                string nomImageTemp = "";
                Int32 valueTemp = 0;
                int xOut;
                bool tempImageInconnue = false;

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
                        tempImageInconnue = true;
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

                // Affichage en conséquence d'une image pour la température
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

                // Température inconnue
                if (tempImageInconnue)
                {
                    nomImageTemp = $"../../Images/Temperature/Inconnue.png";
                }

                // Initialisation des listes

                // Pour les espèces :
                List<string> listeEspeces = new List<string>();
                List<string> listePourcentageEspece = new List<string>();

                DataRow[] espece = r.GetChildRows("FK_Planete_Habiter");

                foreach (DataRow dr in espece)
                {
                    listeEspeces.Add(dr.GetParentRow("FK_Espece_Habiter")[1].ToString());
                    //MessageBox.Show(dr.GetParentRow("FK_Espece_Habiter")[1].ToString() + " : " + listeEspeces.Contains(dr.GetParentRow("FK_Espece_Habiter")[1].ToString()).ToString());
                    listePourcentageEspece.Add(dr[2].ToString());
                }


                // Pour les missions :
                List<string> listeMissions = new List<string>();

                DataRow[] mission = r.GetChildRows("FK_Planete_Mission");
                foreach (DataRow dr in mission)
                {
                    if (dr[0] != null)
                    {
                        listeMissions.Add(dr[0].ToString() + dr[1]);
                    }
                }

                // Création de l'UserControl en le surchargeant
                UserControlPlanete u = new UserControlPlanete(nomImagePlanete, nomImageTemp, nomPlanete, temp, gravite, presenceDatabaz, listeEspeces, listeMissions, listePourcentageEspece);

                // Affichage des UserControl les uns en-dessous des autres
                u.Top = top;
                top += u.Height;

                // Ajout de l'UserControl dans le panel du tableau de bord
                pnlPlanetes.Controls.Add(u);
            }
        }

        private void FrmTableauDeBord_Shown(object sender, EventArgs e)
        {
            //Chargement();
            foreach (System.Windows.Forms.Button b in Controls.OfType<System.Windows.Forms.Button>())
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            /*
                Permet de réinitialiser tous les éléments de recherche dans grpEspeces
            */

            // Décoche les CheckBoxes confirmant les filtres
            ckNom.Checked = false;
            ckCouleur.Checked = false;

            // Décoche les RadioButtons précisant si l'espèce est alliée ou ennemie
            rdbAllies.Checked = false;
            rdbEnnemis.Checked = false;
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            // Vérifie si un filtre par allié ou ennemi est réalisée ou non et agis en conséquence
            if (rdbAllies.Checked)
            {
                InfoEspecesAlliees();
                pnlAllies.Visible = true;
                pnlEnnemis.Visible = false;
                pnlEspeces.Visible = false;
                grpEspeces.Visible = true;
            }
            else if (rdbEnnemis.Checked)
            {
                InfoEspecesEnnemies();
                pnlAllies.Visible = false;
                pnlEnnemis.Visible = true;
                pnlEspeces.Visible = false;
                grpEspeces.Visible = true;

            }
            else
            {
                InfosEspeces();
                pnlAllies.Visible = false;
                pnlEnnemis.Visible = false;
                pnlEspeces.Visible = true;
                grpEspeces.Visible = true;

            }
        }

        private void InfoEspecesAlliees()
        {
            
            // Initialisation des éléments de départ et affichage propre des bons éléments
            pnlAllies.Controls.Clear();
            pnlEspeces.Visible = false;
            grpEspeces.Visible = false;
            pnlAllies.Visible = false;
            pnlEnnemis.Visible = false;
            Int32 top = 0;
            Int32 left = 0;
            DataRow[] tabTemp;
            DataRow[] clone;
            DataTable dt = new DataTable();
            DataTable dtTemp;
            bool filtreEstPresent = false;
            bool resultatExiste = true;

            if (ckCouleur.Checked)
            {
                // Création d'une table temporaire avec un premier filtre qui ne sélectionne que les espèces correspondants à la couleur choisie
                string filtre = "couleur = '" + cboCouleur.SelectedValue + "'";
                tabTemp = MesDatas.DsGlobal.Tables["Espece"].Select(filtre);
                dtTemp = tabTemp.CopyToDataTable();
                dtTemp.TableName = "Filtre";

                // Parcours des espèces alliées : on vérifie si les espèces filtrées par couleur sont des alliés ou pas
                string filtre2 = "";
                int nbEspeces = 0;
                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Allie"].Rows)
                {
                    foreach (DataRow d in dtTemp.Rows)
                    {
                        // Si les espèces alliées sont de la bonne couleur, on les rajoute dans le filtre
                        if (dr[0].ToString() == d[0].ToString())
                        {
                            // Faire un filtre ne contenant que cette espèce
                            // Il peut y avoir plusieurs espèces ayant cette couleur, d'où l'utilisatino du 'OR' pour le filtre
                            filtre2 += "idEspece = " + d[0] + " OR ";
                            nbEspeces++;
                        }
                    }
                    

                }
                // Si aucune espèce ne correspond à la recherche spécifiée, on l'indique
                if (nbEspeces == 0)
                {
                    resultatExiste = false;
                }
                else
                {
                    // On enlève le dernier 'Or' de trop pour avoir un filtre fonctionnel
                    string filtreFinal = filtre2.Remove(filtre2.Length - 4);
                    // On place ce filtre final dans une table 'clone' qui va être copiée dans la DataTable
                    clone = MesDatas.DsGlobal.Tables["Allie"].Select(filtreFinal);
                    dt = clone.CopyToDataTable();
                    filtreEstPresent = true;
                }
                
            }
            else
            {
                // S'il n'y a pas de filtre, on parcourt simplement les éléments de la table Allie
                dt = MesDatas.DsGlobal.Tables["Allie"];
            }

            // Si aucune espèce ne correspond à la recherche spécifiée, on l'indique
            if (!resultatExiste)
            {
                Label error = afficherMessageErreurEspece();
                pnlAllies.Controls.Add(error);
            }
            // Sinon le reste se passe comme sur des roulettes ^_^
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    // Affichage des premiers éléments de base présents directement dans la table Allie
                    string degreBienveillance = r["degreBienveillance"].ToString();
                    string instrument = r["instrumentMusique"].ToString();
                    string datePremierContact = r["datePremierContact"].ToString();
                    List<string> listePlanetes = new List<string>();

                    string nomImageEspece = "";

                    string nomEspece = "";
                    string couleur = "";

                    // Pour les éléments qui ne sont pas dans la table Allie, on vérifie si on utilise un filtre ou pas
                    // En effet, on ne parcourt pas les données de la même façon :
                    // par comparaison des tables Allie et Espece en parcourant cette dernière...
                    if (filtreEstPresent)
                    {
                        // Recherche du nom et de la couleur de l'espèce pour les afficher
                        foreach (DataRow dr in MesDatas.DsGlobal.Tables["Espece"].Rows)
                        {
                            if (dr[0].ToString() == r[0].ToString())
                            {
                                nomEspece = dr[1].ToString();
                                couleur = dr[2].ToString();
                            }
                        }

                        // Liste de la (des) planète(s) sur laquelle (lesquelles) l'espèce vit
                        DataTable planete = MesDatas.DsGlobal.Tables["Habiter"];

                        foreach (DataRow dr in planete.Rows)
                        {

                            if (dr[1].ToString() == r["idEspece"].ToString())
                            {
                                listePlanetes.Add(dr[0].ToString());
                            }
                        }
                    }
                    // ...ou par relation de clé étrangère définie dans AjoutRelation()
                    else
                    {
                        // Ajout du nom de l'espèce
                        nomEspece = r.GetParentRow("FK_Espece_Allie")[1].ToString();

                        // Ajout de sa couleur
                        couleur = r.GetParentRow("FK_Espece_Allie")[2].ToString();

                        // Liste de la (des) planète(s) sur laquelle (lesquelles) l'espèce vit

                        DataRow[] planetes = r.GetParentRow("FK_Espece_Allie").GetChildRows("FK_Espece_Habiter");

                        foreach (DataRow dr in planetes)
                        {
                            if (dr.GetParentRow("FK_Planete_Habiter")[0] != null)
                            {
                                listePlanetes.Add(dr.GetParentRow("FK_Planete_Habiter")[0].ToString());
                            }

                        }
                    }

                    // test du UserControl
                    // Création de l'UserControl en le surchargeant); 
                    UserControlEspecesAlliees u = new UserControlEspecesAlliees(nomImageEspece, couleur, nomEspece, degreBienveillance, listePlanetes, datePremierContact, instrument);


                    // Affichage des UserControl les uns en-dessous des autres
                    u.Top = top;
                    u.Left = left;

                    left += u.Width;

                    if (left > pnlAllies.Width)
                    {
                        top += u.Height;
                        left = 0;
                    }

                    // Ajout de l'UserControl dans le panel du tableau de bord
                    pnlAllies.Controls.Add(u);

                }
            }
        }

        private void InfoEspecesEnnemies()
        {
            // Initialisation des éléments de départ et affichage propre des bons éléments
            pnlEnnemis.Controls.Clear();
            pnlEspeces.Visible = false;
            grpEspeces.Visible = false;
            pnlAllies.Visible = false;
            pnlEnnemis.Visible = false;
            Int32 top = 0;
            Int32 left = 0;
            DataRow[] tabTemp;
            DataRow[] clone;
            DataTable dt = new DataTable();
            DataTable dtTemp;
            bool filtreEstPresent = false;
            bool resultatExiste = true;

            if (ckCouleur.Checked)
            {
                // Création d'une table temporaire avec un premier filtre qui ne sélectionne que les espèces correspondants à la couleur choisie
                string filtre = "couleur = '" + cboCouleur.SelectedValue + "'";
                tabTemp = MesDatas.DsGlobal.Tables["Espece"].Select(filtre);
                dtTemp = tabTemp.CopyToDataTable();
                dtTemp.TableName = "Filtre";

                // Parcours des espèces alliées : on vérifie si les espèces filtrées par couleur sont des alliés ou pas
                string filtre2 = "";
                int nbEspeces = 0;

                foreach (DataRow dr in MesDatas.DsGlobal.Tables["Ennemi"].Rows)
                {
                    foreach (DataRow d in dtTemp.Rows)
                    {
                        // Si les espèces alliées sont de la bonne couleur, on les rajoute dans le filtre
                        if (dr[0].ToString() == d[0].ToString())
                        {
                            // Faire un filtre ne contenant que cette espèce
                            // Il peut y avoir plusieurs espèces ayant cette couleur, d'où l'utilisatino du 'OR' pour le filtre
                            filtre2 += "idEspece = " + d[0] + " OR ";
                            nbEspeces++;
                        }
                    }


                }
                // Si aucune espèce correspondant au critère(s) de recherche n'a été trouvé, on l'indique
                if (nbEspeces == 0)
                {
                    resultatExiste = false;
                }
                else
                {
                    // On enlève le dernier 'Or' de trop pour avoir un filtre fonctionnel
                    string filtreFinal = filtre2.Remove(filtre2.Length - 4);
                    // On place ce filtre final dans une table 'clone' qui va être copiée dans la DataTable
                    clone = MesDatas.DsGlobal.Tables["Ennemi"].Select(filtreFinal);
                    dt = clone.CopyToDataTable();
                    filtreEstPresent = true;
                }
                
            }
            else
            {
                // S'il n'y a pas de filtre, on parcourt simplement les éléments de la table Allie
                dt = MesDatas.DsGlobal.Tables["Ennemi"];
            }

            if (!resultatExiste)
            {
                Label error = afficherMessageErreurEspece();
                pnlEnnemis.Controls.Add(error);
            }
            else
            {


                foreach (DataRow r in dt.Rows)
                {
                    // Affichage des premiers éléments de base présents directement dans la table Allie
                    string degreAgressivite = r["degreAgressivite"].ToString();
                    string arme = r["typeArme"].ToString();

                    string nomImageEspece = "";

                    string nomEspece = "";
                    string couleur = "";

                    List<string> listePlanetes = new List<string>();

                    // Pour les éléments qui ne sont pas dans la table Allie, on vérifie si on utilise un filtre ou pas
                    // En effet, on ne parcourt pas les données de la même façon :
                    // par comparaison des tables Ennemi et Espece en parcourant cette dernière...
                    if (filtreEstPresent)
                    {
                        // Recherche du nom et de la couleur de l'espèce pour les afficher
                        foreach (DataRow dr in MesDatas.DsGlobal.Tables["Espece"].Rows)
                        {
                            if (dr[0].ToString() == r[0].ToString())
                            {
                                nomEspece = dr[1].ToString();
                                couleur = dr[2].ToString();
                            }
                        }

                        // Liste de la (des) planète(s) sur laquelle (lesquelles) l'espèce vit
                        DataTable planete = MesDatas.DsGlobal.Tables["Habiter"];

                        foreach (DataRow dr in planete.Rows)
                        {

                            if (dr[1].ToString() == r["idEspece"].ToString())
                            {
                                listePlanetes.Add(dr[0].ToString());
                            }
                        }
                    }
                    // ...ou par relation de clé étrangère définie dans AjoutRelation()
                    else
                    {
                        // Ajout du nom de l'espèce
                        nomEspece = r.GetParentRow("FK_Espece_Ennemi")[1].ToString();

                        // Ajout de sa couleur
                        couleur = r.GetParentRow("FK_Espece_Ennemi")[2].ToString();

                        // Liste de la (des) planète(s) sur laquelle (lesquelles) l'espèce vit

                        DataRow[] planetes = r.GetParentRow("FK_Espece_Ennemi").GetChildRows("FK_Espece_Habiter");

                        foreach (DataRow dr in planetes)
                        {
                            if (dr.GetParentRow("FK_Planete_Habiter")[0] != null)
                            {
                                listePlanetes.Add(dr.GetParentRow("FK_Planete_Habiter")[0].ToString());
                            }

                        }
                    }

                    // Création de l'UserControl en le surchargeant); 
                    UserControlEspecesEnnemies u = new UserControlEspecesEnnemies(nomImageEspece, couleur, nomEspece, listePlanetes, degreAgressivite, arme);


                    // Affichage des UserControl les uns en-dessous des autres
                    u.Top = top;
                    u.Left = left;

                    left += u.Width;

                    if (left > pnlEnnemis.Width)
                    {
                        top += u.Height;
                        left = 0;
                    }


                    // Ajout de l'UserControl dans le panel du tableau de bord
                    pnlEnnemis.Controls.Add(u);


                }
            }
        }


        private void ChargementComboBoxes()
        {
            // ComboBox Couleur
            co = Connexion.Connec;
            try
            {
                // ComboBox couleur
                string request = @"select distinct couleur from Espece";
                SQLiteCommand cmd = new SQLiteCommand(request, co);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(MesDatas.DsGlobal, "Couleur");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connexion.FermerConnexion();
            }
            cboCouleur.DataSource = MesDatas.DsGlobal.Tables["Couleur"];
            cboCouleur.DisplayMember = "couleur";
            cboCouleur.ValueMember = "couleur";

            // ComboBox Nom
            cboNom.DataSource = MesDatas.DsGlobal.Tables["Espece"];
            cboNom.DisplayMember = "nom";
            cboNom.ValueMember = "nom";
        }

        private Label afficherMessageErreurEspece()
        {
            /*
             * Renvoie un label contenant un message d'erreur si la recherche d'espèce n'est pas fructueuse
            */
            Label errorEspece = new Label();
            errorEspece.Text = "Aucun résultat ne correspond à votre recherche :( ";
            errorEspece.Size = new Size(200, 150);
            errorEspece.Location = new Point(pnlEnnemis.Width / 2 - 50, pnlEnnemis.Height / 2);
            pnlEnnemis.Controls.Add(errorEspece);
            return errorEspece;
        }

        private void cboNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboCouleur_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ckCouleur_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
