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

        private void FormulaireMission_Load(object sender, EventArgs e)
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

        }
    }
}
