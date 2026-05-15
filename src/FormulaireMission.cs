using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class FormulaireMission : Form
    {
        DataRow[] missionActuelle;
        public FormulaireMission()
        {
            InitializeComponent();
        }

        public FormulaireMission(string idMission)
        {
            InitializeComponent();
            missionActuelle = MesDatas.DsGlobal.Tables["Mission"].Select($"nomPlanete = '{idMission.Substring(0, idMission.Length - 1)}' AND numero = '{ idMission.Substring(idMission.Length - 1, 1)}'");
            missionPB1.SetImage = idMission.Substring(0,idMission.Length - 1);
            missionPB1.SetText = idMission;
        }

        private void RemplissageMembre()
        {
            DataRow[] membreMission = missionActuelle[0].GetChildRows("FK_Mission_Composer");
            int left = 10;

            foreach (DataRow membre in membreMission)
            {
                left = CreationMembre(membre, left);
            }
        }

        private int CreationMembre(DataRow r, int left)
        {
            int top = 10;
            MembreEquipage m = new MembreEquipage();
            DataRow profil = r.GetParentRow("FK_Membre_Composer");
            if (profil["matricule"].ToString()[0] == 'C')
            {
                m.SetImage = "Civil";
            }
            else
            {
                m.SetImage = "Soldier";
            }
            m.setText = $"{profil["nom"].ToString()}\n{profil["prenom"].ToString()}";
            if (profil["matricule"].ToString() == missionActuelle[0]["matriculeChef"].ToString())
            {
                m.BackColor = Color.Green;
            }
            m.Top = top;
            m.Left = left;
            pnlMembre.Controls.Add(m);
            left += m.Width + 5;

            return left;
        }

        private void RemplissageInfoMission()
        {
            lblDepart.Text = $"Date de départ : {missionActuelle[0]["dateDepart"]}";
            lblArrivee.Text = $"Date de retour prévu : {missionActuelle[0]["dateRetour"]}";
            double solde = Convert.ToDouble(missionActuelle[0]["budget"]);

            lblBudget.Text = $"Budget : {missionActuelle[0]["budget"]}";

            DataRow[] depense = missionActuelle[0].GetChildRows("FK_Mission_Depense");

            foreach (DataRow row in depense)
            {
                solde -= Convert.ToDouble(row["montant"]);
            }
            lblSolde.Text = $"Solde après dépenses : {solde.ToString()}";
            txtFeuilleRoute.Text = $"{missionActuelle[0]["feuilleDeRoute"]}";
            txtFeuilleRoute.BackColor = SystemColors.Window;
        }

        private void RemplissageObjectif()
        {
            DataRow[] objectifs = missionActuelle[0].GetChildRows("FK_Mission_ObjectifCapture");


            foreach (DataRow r in objectifs)
            {
                DataRow espece = r.GetParentRow("FK_Espece_ObjectifCapture");
                txtCaptures.Text += $"{espece["nom"].ToString()} : {r["objectif"].ToString()}\r\n";
            }
            txtCaptures.BackColor = SystemColors.Window;
        }
        private void FormulaireMission_Load(object sender, EventArgs e)
        {
            RemplissageInfoMission();
            RemplissageMembre();
            RemplissageObjectif();
        }

        private void btnFormJournal_Click(object sender, EventArgs e)
        {
            FormulaireJournalDeBord frmJournal = new FormulaireJournalDeBord(missionActuelle[0]);
            frmJournal.ShowDialog();
        }
    }
}
