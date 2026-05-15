using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SAE24
{
    public partial class FormulaireJournalDeBord : Form
    {
        DataRow mission;
        BindingSource bsMission;
        BindingSource bsJournalDeBord;
        public FormulaireJournalDeBord()
        {
            InitializeComponent();
        }

        public FormulaireJournalDeBord(DataRow missionActuelle)
        {
            InitializeComponent();
            mission = missionActuelle;
        }

        private void FormulaireJournalDeBord_Load(object sender, EventArgs e)
        {
            creationDGVContacts();
            creationDGVDepense();
            creationListeEvent();
        }

        private void creationDGVDepense()
        {
            //On créer une nouvelle table qui est constitué des informations que l'on souhaite
            //pour la mission actuelle.
            DataTable dt = new DataTable("DepenseMissionActuelle");
            dt.Columns.Add("N°", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Motif", typeof(string));
            dt.Columns.Add("Montant", typeof(string));
            dt.Columns.Add("Type de dépense", typeof(string));

            //Variable servant à compter les dépenses totales
            Double montantDepense = 0;

            //On récupère les dépenses qui sont liées à la mission
            DataRow[] depenses = mission.GetChildRows("FK_Mission_Depense");

            //Pour chaque dépense, on crée une nouvelle ligne qui ira dans notre DataGridView
            foreach (DataRow depense in depenses)
            {
                DataRow newDepense = dt.NewRow();
                newDepense[0] = depense["id"];
                newDepense[1] = depense["dateD"];
                newDepense[2] = depense["motif"];
                newDepense[3] = depense["montant"];

                //On récupère le libelle correspondant au type de dépense.
                DataRow typeDepense = depense.GetParentRow("FK_TypeDepense_Depense");
                newDepense[4] = typeDepense["libelle"];

                //On incrémente notre somme totale de dépense
                montantDepense += Convert.ToDouble(depense["montant"]);
                dt.Rows.Add(newDepense);
            }

            //On affiche la somme totale des dépenses et on les affiche dans le DataGridView
            dgvDepenses.DataSource = dt;
            lblDepense.Text = $"Depense totale : {montantDepense.ToString()}";
        }

        private void creationListeEvent()
        {
            // On initialise nos Binding Source pour la relation Maitre/Détail
            bsMission = new BindingSource();
            bsMission.DataSource = MesDatas.DsGlobal.Tables["mission"];

            //On met un filtre sur ce BindingSource pour que les évent de journal soit bien ceux de la mission actuelle
            bsMission.Filter = $"nomPlanete = '{mission["nomPlanete"]}' AND numero = '{mission["numero"]}'";

            bsJournalDeBord = new BindingSource();
            bsJournalDeBord.DataSource = bsMission;
            bsJournalDeBord.DataMember = MesDatas.DsGlobal.Relations["FK_Mission_JournalDeBord"].ToString();

            //On tri par date ascendante (Marche moyennement à cause du type String et du format des dates aléatoire de la DB)
            bsJournalDeBord.Sort = "dateJ ASC";

            //On peut bind au label le texte à afficher
            lblDateEvent.DataBindings.Add("Text", bsJournalDeBord, "dateJ");
            lblEventDescription.DataBindings.Add("Text", bsJournalDeBord, "commentaires");
        }

        private void creationDGVContacts()
        {
            //On crée une table qui servira à donner les informations de Contact de la mission actuelle
            DataTable dt = new DataTable("ContactMissionActuelle");
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Somme", typeof(string));
            dt.Columns.Add("Appreciation", typeof(string));
            dt.Columns.Add("Informateur", typeof(string));


            DataRow[] contacts = mission.GetChildRows("FK_Mission_Contact");
            Double montantSommeVersee = 0; 
            foreach (DataRow contact in contacts)
            {
                DataRow newContact = dt.NewRow();
                newContact[0] = contact["dateC"];
                newContact[1] = contact["sommeVersee"];
                newContact[2] = contact["appreciation"];
                DataRow informateur = contact.GetParentRow("FK_Informateur_Contact");
                newContact[3] = informateur["nom"];
                montantSommeVersee += Convert.ToDouble(newContact[1]);
                dt.Rows.Add(newContact);
            }
            dgvContact.DataSource = dt;
            lblSommeVersees.Text = $"Somme totale versée : {montantSommeVersee.ToString()}";
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bsJournalDeBord.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bsJournalDeBord.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bsJournalDeBord.MoveNext();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bsJournalDeBord.MoveLast();
        }
    }
}
