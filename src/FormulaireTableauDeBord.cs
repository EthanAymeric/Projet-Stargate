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
            ModifDate();

            //Mettre en place la couleur de base du thème sur le formulaire
            BackColor = Couleur.getBackground;
            ForeColor = Couleur.getText;
            foreach (Control c in Controls)
            {
                UpdateColorControls(c);
            }   
        }

        private void UpdateDataSet()
        {
            // Sert à mettre à jour le DataSet quand il y a un ajout de mission
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
            // Remplit le DataSet Local à partir de la base de donnée
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

        private void ModifDate()
        {
            // Sert à modifier le format de toute les dates dans le DataSet pour avoir le même format partout
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Depense"].Rows)
            {
                r[3] = Convert.ToDateTime(r[3]).ToString("yyyy-MM-dd");

            }
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Allie"].Rows)
            {
                r[1] = Convert.ToDateTime(r[1]).ToString("yyyy-MM-dd"); 
            }
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                r[3] = Convert.ToDateTime(r[3]).ToString("yyyy-MM-dd");
                r[4] = Convert.ToDateTime(r[4]).ToString("yyyy-MM-dd");

            }
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Contact"].Rows)
            {
                r[2] = Convert.ToDateTime(r[2]).ToString("yyyy-MM-dd");
            }
            foreach (DataRow r in MesDatas.DsGlobal.Tables["JournalDeBord"].Rows)
            {
                r[2] = Convert.ToDateTime(r[2]).ToString("yyyy-MM-dd");
            }
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Membre"].Rows)
            {
                r[3] = Convert.ToDateTime(r[3]).ToString("yyyy-MM-dd");
            }
        }

        private void AjoutRelation()
        {
            try
            {
                // Ajout des relations relatif à la base de donnée qui permettent de récupérer les Lignes parent ou enfant d'une autre donnée
                // ENFANT > PARENT
                // Matricule Chef > Matricule Militaire
                MesDatas.DsGlobal.Relations.Add("FK_Militaire_Chef", MesDatas.DsGlobal.Tables["Militaire"].Columns["matriculeMembre"], MesDatas.DsGlobal.Tables["Mission"].Columns["matriculeChef"]);

                // Matricule Militaire > Matricule Membre
                MesDatas.DsGlobal.Relations.Add("FK_Membre_Militaire", MesDatas.DsGlobal.Tables["Membre"].Columns["matricule"], MesDatas.DsGlobal.Tables["Militaire"].Columns["matriculeMembre"]);

                // Matricule Civil > Matricule Membre
                MesDatas.DsGlobal.Relations.Add("FK_Membre_Civil", MesDatas.DsGlobal.Tables["Membre"].Columns["matricule"], MesDatas.DsGlobal.Tables["Civil"].Columns["matriculeMembre"]);

                // Matricule Composer > Matricule Membre
                MesDatas.DsGlobal.Relations.Add("FK_Membre_Composer", MesDatas.DsGlobal.Tables["Membre"].Columns["matricule"], MesDatas.DsGlobal.Tables["Composer"].Columns["matriculeMembre"]);

                // Depense > Mission
                DataColumn[] missionPK = new DataColumn[] { MesDatas.DsGlobal.Tables["Mission"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Mission"].Columns["numero"] };
                DataColumn[] depensePK = new DataColumn[] { MesDatas.DsGlobal.Tables["Depense"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Depense"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_Depense", missionPK, depensePK);

                // Composer > Mission
                DataColumn[] composer = new DataColumn[] { MesDatas.DsGlobal.Tables["Composer"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Composer"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_Composer", missionPK, composer);

                // Objectif Capture > Mission
                DataColumn[] objectifCapture = new DataColumn[] { MesDatas.DsGlobal.Tables["ObjectifCapture"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["ObjectifCapture"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_ObjectifCapture", missionPK, objectifCapture);

                // Objectif Capture > Espece
                MesDatas.DsGlobal.Relations.Add("FK_Espece_ObjectifCapture", MesDatas.DsGlobal.Tables["Espece"].Columns["id"] , MesDatas.DsGlobal.Tables["ObjectifCapture"].Columns["idEspeceEnnemi"]);
                DataColumn[] journalDeBord = new DataColumn[] { MesDatas.DsGlobal.Tables["JournalDeBord"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["JournalDeBord"].Columns["numero"] };

                // Journal De Bord > Mission
                MesDatas.DsGlobal.Relations.Add("FK_Mission_JournalDeBord", missionPK, journalDeBord);

                // Contact > Mission
                DataColumn[] contact = new DataColumn[] { MesDatas.DsGlobal.Tables["Contact"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Contact"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_Contact", missionPK, contact);

                // Contact > Informateur
                MesDatas.DsGlobal.Relations.Add("FK_Informateur_Contact", MesDatas.DsGlobal.Tables["Informateur"].Columns["nomCode"], MesDatas.DsGlobal.Tables["Contact"].Columns["nomCodeInformateur"]);

                // Depense > Type Depense
                MesDatas.DsGlobal.Relations.Add("FK_TypeDepense_Depense", MesDatas.DsGlobal.Tables["TypeDepense"].Columns["id"], MesDatas.DsGlobal.Tables["Depense"].Columns["idTypeDepense"]);
                
                // Capture > Mission
                DataColumn[] capture = new DataColumn[] { MesDatas.DsGlobal.Tables["Capturer"].Columns["nomPlanete"], MesDatas.DsGlobal.Tables["Capturer"].Columns["numeroMission"] };
                MesDatas.DsGlobal.Relations.Add("FK_Mission_Capturer", missionPK, capture);
                
                // Capturer > Espece
                MesDatas.DsGlobal.Relations.Add("FK_Espece_Capturer", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Capturer"].Columns["idEspeceEnnemi"]);

                // Ennemi > Espece
                MesDatas.DsGlobal.Relations.Add("FK_Espece_Ennemi", MesDatas.DsGlobal.Tables["Espece"].Columns["id"], MesDatas.DsGlobal.Tables["Ennemi"].Columns["idEspece"]);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ActualisationTDB()
        {

            // Remplis le Flow Layout Pannel avec les UserControl MissionResume
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
                mr.afficher += AfficherResume;
                pnlTDB.Controls.Add(mr);
            }
        }

        private void AfficherResume(object sender, EventArgs e)
        {
            // Permet d'afficher la fiche de mission en cliquant sur une mission

            MissionResume mr = (MissionResume)sender;
            FormulaireMission frm = new FormulaireMission(mr.GetMission);
            frm.ShowDialog();
        }
        private void btnTDB_Click(object sender, EventArgs e)
        {
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

        }

        private void btnSwitchTheme_Click(object sender, EventArgs e)
        {
            Couleur.SwitchTheme();
            btnSwitchTheme.Text = (btnSwitchTheme.Text == "Theme Sombre") ? "Theme Clair" : "Theme Sombre";
            BackColor = Couleur.getBackground;
            ForeColor = Couleur.getText;
            foreach (Control c in Controls)
            {
                UpdateColorControls(c);
            }

        }

        private void UpdateColorControls(Control c)
        {
            if(c is Label)
            {
                c.ForeColor = Couleur.getText;
            }
            if(c is Button)
            {
                c.BackColor = Couleur.getButton;
                c.ForeColor = Couleur.getText;
            }
            if(c is MissionResume)
            {
                MissionResume mr = (MissionResume)c;
                mr.UpdateColors();
            }
            foreach(Control subControl in c.Controls)
            {
                UpdateColorControls(subControl);
            }
        }
    }
}
