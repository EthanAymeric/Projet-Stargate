using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        DataRow[] missionActuelle;
        BindingSource bsMission;
        BindingSource bsJournalDeBord;
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
            creationDGVContacts();
            creationDGVDepense();
            creationListeEvent();
            creationDGVCapture();
            Text = $"Resume de la mission : {missionActuelle[0]["nomPlanete"]} {missionActuelle[0]["numero"]}";
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
            DataRow[] depenses = missionActuelle[0].GetChildRows("FK_Mission_Depense");

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
            bsMission.Filter = $"nomPlanete = '{missionActuelle[0]["nomPlanete"]}' AND numero = '{missionActuelle[0]["numero"]}'";

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


            DataRow[] contacts = missionActuelle[0].GetChildRows("FK_Mission_Contact");
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

        private void creationDGVCapture()
        {
            //On crée une table qui servira à donner les informations de Contact de la mission actuelle
            DataTable dt = new DataTable("CaptureMissionActuelle");
            dt.Columns.Add("Nom de l'espèce", typeof(string));
            dt.Columns.Add("Objectif initial", typeof(string));
            dt.Columns.Add("Nombre de captures réalisées", typeof(string));
            dt.Columns.Add("Taux de réussite (en %)", typeof(string));


            DataRow[] captures = missionActuelle[0].GetChildRows("FK_Mission_Capturer");
            foreach (DataRow capture in captures)
            {
                DataRow newCapture = dt.NewRow();
                DataRow idEspece = capture.GetParentRow("FK_Espece_Capturer");
                DataRow[] objectifCapture = missionActuelle[0].GetChildRows("FK_Mission_ObjectifCapture");
                newCapture[0] = idEspece["nom"];
                Int32 objectif = 0;
                foreach (DataRow r in  objectifCapture)
                {
                    if (r["idEspeceEnnemi"].ToString() == capture["idEspeceEnnemi"].ToString())
                    {
                        objectif = Convert.ToInt32(r["objectif"]);
                        newCapture[1] = r["objectif"].ToString();
                    }
                }
                DataRow[] capturé = missionActuelle[0].GetChildRows("FK_Mission_Capturer");
                Int32 nbCapture = 0;
                foreach (DataRow r in capturé)
                {
                    if (r["idEspeceEnnemi"].ToString() == capture["idEspeceEnnemi"].ToString())
                    {
                        nbCapture = Convert.ToInt32(r["nombre"]);
                    }
                }
                newCapture[2] = nbCapture.ToString();
                newCapture[3] = (nbCapture*100/objectif).ToString();
                dt.Rows.Add(newCapture);
            }
            dgvCapture.DataSource = dt;

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
