using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class FormulaireMission : Form
    {
        DataRow missionActuelle;
        BindingSource bsMission;
        BindingSource bsJournalDeBord;
        DataTable depenseMissionActuelle;
        DataTable contactMissionActuelle;
        DataTable captureMissionActuelle;
        public FormulaireMission()
        {
            InitializeComponent();
        }

        public FormulaireMission(string idMission)
        {
            InitializeComponent();
            missionActuelle = MesDatas.DsGlobal.Tables["Mission"].Select($"nomPlanete = '{idMission.Substring(0, idMission.Length - 1)}' AND numero = '{idMission.Substring(idMission.Length - 1, 1)}'")[0];
            missionPB1.SetImage = idMission.Substring(0, idMission.Length - 1);
            missionPB1.SetText = idMission;
        }

        private void RemplissageMembre()
        {
            DataRow[] membreMission = missionActuelle.GetChildRows("FK_Mission_Composer");
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
            if (profil["matricule"].ToString() == missionActuelle["matriculeChef"].ToString())
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
            lblDepart.Text = $"Date de départ : {missionActuelle["dateDepart"]}";
            lblArrivee.Text = $"Date de retour prévu : {missionActuelle["dateRetour"]}";
            double solde = Convert.ToDouble(missionActuelle["budget"]);

            lblBudget.Text = $"Budget : {missionActuelle["budget"]}";

            DataRow[] depense = missionActuelle.GetChildRows("FK_Mission_Depense");

            foreach (DataRow row in depense)
            {
                solde -= Convert.ToDouble(row["montant"]);
            }
            lblSolde.Text = $"Solde après dépenses : {solde.ToString()}";
            txtFeuilleRoute.Text = $"{missionActuelle["feuilleDeRoute"]}";
            txtFeuilleRoute.BackColor = SystemColors.Window;
        }

        private void RemplissageObjectif()
        {
            DataRow[] objectifs = missionActuelle.GetChildRows("FK_Mission_ObjectifCapture");


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
            creationDGVContacts();
            creationDGVDepense();
            creationListeEvent();
            creationDGVCapture();
            Text = $"Resume de la mission : {missionActuelle["nomPlanete"]} {missionActuelle["numero"]}";
        }

        private void creationDGVDepense()
        {
            //On créer une nouvelle table qui est constitué des informations que l'on souhaite
            //pour la mission actuelle.
            depenseMissionActuelle = new DataTable("DepenseMissionActuelle");
            depenseMissionActuelle.Columns.Add("N°", typeof(string));
            depenseMissionActuelle.Columns.Add("Date", typeof(string));
            depenseMissionActuelle.Columns.Add("Motif", typeof(string));
            depenseMissionActuelle.Columns.Add("Montant", typeof(string));
            depenseMissionActuelle.Columns.Add("Type de dépense", typeof(string));

            //Variable servant à compter les dépenses totales
            Double montantDepense = 0;

            //On récupère les dépenses qui sont liées à la mission
            DataRow[] depenses = missionActuelle.GetChildRows("FK_Mission_Depense");

            //Pour chaque dépense, on crée une nouvelle ligne qui ira dans notre DataGridView
            foreach (DataRow depense in depenses)
            {
                DataRow newDepense = depenseMissionActuelle.NewRow();
                newDepense[0] = depense["id"];
                newDepense[1] = depense["dateD"];
                newDepense[2] = depense["motif"];
                newDepense[3] = depense["montant"];

                //On récupère le libelle correspondant au type de dépense.
                DataRow typeDepense = depense.GetParentRow("FK_TypeDepense_Depense");
                newDepense[4] = typeDepense["libelle"];

                //On incrémente notre somme totale de dépense
                montantDepense += Convert.ToDouble(depense["montant"]);
                depenseMissionActuelle.Rows.Add(newDepense);
            }

            //On affiche la somme totale des dépenses et on les affiche dans le DataGridView
            dgvDepenses.DataSource = depenseMissionActuelle;
            lblDepense.Text = $"Depense totale : {montantDepense.ToString()}";
        }

        private void creationListeEvent()
        {
            // On initialise nos Binding Source pour la relation Maitre/Détail
            bsMission = new BindingSource();
            bsMission.DataSource = MesDatas.DsGlobal.Tables["mission"];

            //On met un filtre sur ce BindingSource pour que les évent de journal soit bien ceux de la mission actuelle
            bsMission.Filter = $"nomPlanete = '{missionActuelle["nomPlanete"]}' AND numero = '{missionActuelle["numero"]}'";

            bsJournalDeBord = new BindingSource();
            bsJournalDeBord.DataSource = bsMission;
            bsJournalDeBord.DataMember = MesDatas.DsGlobal.Relations["FK_Mission_JournalDeBord"].ToString();

            //On tri par date ascendante (Marche moyennement à cause du type String et du format des dates aléatoire de la DB)
            bsJournalDeBord.Sort = "dateJ";

            //On peut bind au label le texte à afficher
            lblDateEvent.DataBindings.Add("Text", bsJournalDeBord, "dateJ");
            lblEventDescription.DataBindings.Add("Text", bsJournalDeBord, "commentaires");
        }

        private void creationDGVContacts()
        {
            //On crée une table qui servira à donner les informations de Contact de la mission actuelle
            contactMissionActuelle = new DataTable("ContactMissionActuelle");
            contactMissionActuelle.Columns.Add("Date", typeof(string));
            contactMissionActuelle.Columns.Add("Somme", typeof(string));
            contactMissionActuelle.Columns.Add("Appreciation", typeof(string));
            contactMissionActuelle.Columns.Add("Informateur", typeof(string));


            DataRow[] contacts = missionActuelle.GetChildRows("FK_Mission_Contact");
            Double montantSommeVersee = 0;
            foreach (DataRow contact in contacts)
            {
                DataRow newContact = contactMissionActuelle.NewRow();
                newContact[0] = contact["dateC"];
                newContact[1] = contact["sommeVersee"];
                newContact[2] = contact["appreciation"];
                DataRow informateur = contact.GetParentRow("FK_Informateur_Contact");
                newContact[3] = informateur["nom"];
                montantSommeVersee += Convert.ToDouble(newContact[1]);
                contactMissionActuelle.Rows.Add(newContact);
            }
            dgvContact.DataSource = contactMissionActuelle;
            lblSommeVersees.Text = $"Somme totale versée : {montantSommeVersee.ToString()}";
        }

        private void creationDGVCapture()
        {
            //On crée une table qui servira à donner les informations de Contact de la mission actuelle
            captureMissionActuelle = new DataTable("CaptureMissionActuelle");
            captureMissionActuelle.Columns.Add("Nom de l'espèce", typeof(string));
            captureMissionActuelle.Columns.Add("Objectif initial", typeof(string));
            captureMissionActuelle.Columns.Add("Nombre de captures réalisées", typeof(string));
            captureMissionActuelle.Columns.Add("Taux de réussite (en %)", typeof(string));


            DataRow[] captures = missionActuelle.GetChildRows("FK_Mission_Capturer");
            foreach (DataRow capture in captures)
            {
                DataRow newCapture = captureMissionActuelle.NewRow();
                DataRow idEspece = capture.GetParentRow("FK_Espece_Capturer");
                DataRow[] objectifCapture = missionActuelle.GetChildRows("FK_Mission_ObjectifCapture");
                newCapture[0] = idEspece["nom"];
                Int32 objectif = 0;
                foreach (DataRow r in objectifCapture)
                {
                    if (r["idEspeceEnnemi"].ToString() == capture["idEspeceEnnemi"].ToString())
                    {
                        objectif = Convert.ToInt32(r["objectif"]);
                        newCapture[1] = r["objectif"].ToString();
                    }
                }
                DataRow[] capturé = missionActuelle.GetChildRows("FK_Mission_Capturer");
                Int32 nbCapture = 0;
                foreach (DataRow r in capturé)
                {
                    if (r["idEspeceEnnemi"].ToString() == capture["idEspeceEnnemi"].ToString())
                    {
                        nbCapture = Convert.ToInt32(r["nombre"]);
                    }
                }
                newCapture[2] = nbCapture.ToString();
                newCapture[3] = (nbCapture * 100 / objectif).ToString();
                captureMissionActuelle.Rows.Add(newCapture);
            }
            dgvCapture.DataSource = captureMissionActuelle;

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

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                grpFormulaireAjout.Controls.Clear();
                switch (rdb.Tag)
                {
                    case "1":
                        AfficherFormContact();
                        break;
                    case "2":
                        AfficherFormDepense();
                        break;
                    case "3":
                        AfficherFormEvent();
                        break;
                    case "4":
                        AfficherFormCapture();
                        break;
                    default:
                        MessageBox.Show("Une erreur est survenue");
                        break;
                }
            }
        }

        private void AfficherFormDepense()
        {
            int top = 40;
            int left = 20;
            grpFormulaireAjout.Visible = true;
            grpFormulaireAjout.Text = "Ajout de Dépense";
            DateTimePicker dtp = new DateTimePicker();
            Label lblDate = new Label();
            Label lblMontant = new Label();
            TextBox txtMontant = new TextBox();
            Label lblMotif = new Label();
            RichTextBox txtMotif = new RichTextBox();
            Label lblInformateur = new Label();
            ComboBox cboInformateur = new ComboBox();

            lblDate.Text = "Date";
            lblDate.Top = top;
            lblDate.Left = left;
            lblDate.Name = "lblDate";

            dtp.Top = lblDate.Top;
            dtp.Left = lblDate.Width + 20 + left;
            dtp.MinDate = Convert.ToDateTime(missionActuelle["dateDepart"]);
            dtp.MaxDate = Convert.ToDateTime(missionActuelle["dateRetour"]);


            lblMontant.Top = top + lblDate.Height + 20;
            lblMontant.Left = left;
            lblMontant.Text = "Montant";

            txtMontant.Top = lblMontant.Top;
            txtMontant.Left = lblMontant.Width + 20 + left;

            lblMotif.Text = "Motif";
            lblMotif.Left = left;
            lblMotif.Top = lblMontant.Top + lblMontant.Height + 20;

            txtMotif.Top = lblMotif.Top + lblMotif.Height;
            txtMotif.Left = left;
            txtMotif.Width = grpFormulaireAjout.Width - 40;

            lblInformateur.Text = "Informateur";
            lblInformateur.Left = left;
            lblInformateur.Top = txtMotif.Top + txtMotif.Height + 20;

            cboInformateur.Top = txtMotif.Top + txtMotif.Height + 20;
            cboInformateur.Left = lblInformateur.Width + 20 + left;
            cboInformateur.DataSource = MesDatas.DsGlobal.Tables["TypeDepense"];
            cboInformateur.DisplayMember = "libelle";
            cboInformateur.ValueMember = "id";



            grpFormulaireAjout.Controls.Add(lblDate);
            grpFormulaireAjout.Controls.Add(dtp);
            grpFormulaireAjout.Controls.Add(lblMontant);
            grpFormulaireAjout.Controls.Add(txtMontant);
            grpFormulaireAjout.Controls.Add(lblMotif);
            grpFormulaireAjout.Controls.Add(txtMotif);
            grpFormulaireAjout.Controls.Add(lblInformateur);
            grpFormulaireAjout.Controls.Add(cboInformateur);


        }

        private void AfficherFormContact()
        {
            int top = 40;
            int left = 20;
            grpFormulaireAjout.Visible = true;
            grpFormulaireAjout.Text = "Ajout de Contact";
            DateTimePicker dtp = new DateTimePicker();
            Label lblDate = new Label();
            Label lblSomme = new Label();
            TextBox txtSomme = new TextBox();
            Label lblAppreciation = new Label();
            RichTextBox txtAppreciation = new RichTextBox();
            Label lblInformateur = new Label();
            ComboBox cboInformateur = new ComboBox();

            lblDate.Text = "Date";
            lblDate.Top = top;
            lblDate.Left = left;
            lblDate.Name = "lblDate";

            dtp.Top = lblDate.Top;
            dtp.Left = lblDate.Width + 20 + left;
            dtp.MinDate = Convert.ToDateTime(missionActuelle["dateDepart"]);
            dtp.MaxDate = Convert.ToDateTime(missionActuelle["dateRetour"]);


            lblSomme.Top = top + lblDate.Height + 20;
            lblSomme.Left = left;
            lblSomme.Text = "Somme";

            txtSomme.Top = lblSomme.Top;
            txtSomme.Left = lblSomme.Width + 20 + left;

            lblAppreciation.Text = "Appreciation";
            lblAppreciation.Left = left;
            lblAppreciation.Top = lblSomme.Top + lblSomme.Height + 20;

            txtAppreciation.Top = lblAppreciation.Top + lblAppreciation.Height;
            txtAppreciation.Left = left;
            txtAppreciation.Width = grpFormulaireAjout.Width - 40;

            lblInformateur.Text = "Informateur";
            lblInformateur.Left = left;
            lblInformateur.Top = txtAppreciation.Top + txtAppreciation.Height + 20;

            cboInformateur.Top = txtAppreciation.Top + txtAppreciation.Height + 20;
            cboInformateur.Left = lblInformateur.Width + 20 + left;
            cboInformateur.DataSource = MesDatas.DsGlobal.Tables["Informateur"];
            cboInformateur.DisplayMember = "nom";
            cboInformateur.ValueMember = "nomCode";



            grpFormulaireAjout.Controls.Add(lblDate);
            grpFormulaireAjout.Controls.Add(dtp);
            grpFormulaireAjout.Controls.Add(lblSomme);
            grpFormulaireAjout.Controls.Add(txtSomme);
            grpFormulaireAjout.Controls.Add(lblAppreciation);
            grpFormulaireAjout.Controls.Add(txtAppreciation);
            grpFormulaireAjout.Controls.Add(lblInformateur);
            grpFormulaireAjout.Controls.Add(cboInformateur);

        }

        private void AfficherFormEvent()
        {
            int top = 40;
            int left = 20;
            grpFormulaireAjout.Visible = true;
            grpFormulaireAjout.Text = "Ajout d'Évènements";
            DateTimePicker dtp = new DateTimePicker();
            Label lblDate = new Label();
            Label lblMotif = new Label();
            RichTextBox txtMotif = new RichTextBox();

            lblDate.Text = "Date";
            lblDate.Top = top;
            lblDate.Left = left;
            lblDate.Name = "lblDate";

            dtp.Top = lblDate.Top;
            dtp.Left = lblDate.Width + 20 + left;
            dtp.MinDate = Convert.ToDateTime(missionActuelle["dateDepart"]);
            dtp.MaxDate = Convert.ToDateTime(missionActuelle["dateRetour"]);

            lblMotif.Text = "Motif";
            lblMotif.Left = left;
            lblMotif.Top = lblDate.Top + lblDate.Height + 20;

            txtMotif.Top = lblMotif.Top + lblMotif.Height;
            txtMotif.Left = left;
            txtMotif.Width = grpFormulaireAjout.Width - 40;

            grpFormulaireAjout.Controls.Add(lblDate);
            grpFormulaireAjout.Controls.Add(dtp);
            grpFormulaireAjout.Controls.Add(lblMotif);
            grpFormulaireAjout.Controls.Add(txtMotif);
        }

        private void AfficherFormCapture()
        {
            int top = 40;
            int left = 20;
            grpFormulaireAjout.Visible = true;
            grpFormulaireAjout.Text = "Ajout de Contact";
            ComboBox cboCapture = new ComboBox();
            Label lblCapture = new Label();
            Label lblSomme = new Label();
            TextBox txtSomme = new TextBox();
            DataTable especeEnnemi = new DataTable("EspeceEnnemi");
            especeEnnemi.Columns.Add("id", typeof(string));
            especeEnnemi.Columns.Add("nom", typeof(string));

            foreach (DataRow r in MesDatas.DsGlobal.Tables["Ennemi"].Rows)
            {
                DataRow dr = r.GetParentRow("FK_Espece_Ennemi");
                DataRow e = especeEnnemi.NewRow();
                e[0] = dr[0];
                e[1] = dr[1];
                especeEnnemi.Rows.Add(e);
            }

            cboCapture.DataSource = especeEnnemi;
            cboCapture.DisplayMember = "nom";
            cboCapture.ValueMember = "id";

            lblCapture.Text = "Ennemi capturé :";
            lblCapture.Left = left;
            lblCapture.Top = top;

            cboCapture.Top = top;
            cboCapture.Left = left + lblCapture.Width + 20;

            lblSomme.Top = top + lblCapture.Height + 20;
            lblSomme.Left = left;
            lblSomme.Text = "Nombre d'ennemi\ncapturé :";
            lblSomme.Height = 25;

            txtSomme.Top = lblSomme.Top;
            txtSomme.Left = lblSomme.Width + 20 + left;

            grpFormulaireAjout.Controls.Add(lblCapture);
            grpFormulaireAjout.Controls.Add(cboCapture);
            grpFormulaireAjout.Controls.Add(lblSomme);
            grpFormulaireAjout.Controls.Add(txtSomme);
        }

        private void btnValidationAjout_Click(object sender, EventArgs e)
        {
            string tag = "";
            foreach (RadioButton rdb in grpChoixAjout.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked)
                {
                    tag = rdb.Text;
                }
            }

            switch (tag)
            {
                case "1":
                    ;
                    break;
                case "2":
                    ;
                    break;
                case "3":
                    ;
                    break;
                case "4":
                    ;
                    break;
                default:
                    MessageBox.Show("Une erreur est survenue");
                    break;
            }
        }

        public void ajoutContact()
        {
            SQLiteConnection co = Connexion.Connec();

            try
            {
                string nomPlanete = missionActuelle[0];
                string numeroMission = missionActuelle[1];
                string date = 
            }
        }
    }
}
