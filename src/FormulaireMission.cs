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
                Int32 objectif = 1;
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
            grpFormDepense.Visible = true;
            grpFormCapture.Visible = false;
            grpFormContact.Visible = false;
            grpFormEvent.Visible = false;

            lblDateDepense.Top = top;
            lblDateDepense.Left = left;

            dtpDateDepense.Top = lblDateDepense.Top;
            dtpDateDepense.Left = lblDateDepense.Width + 20 + left;
            dtpDateDepense.MinDate = Convert.ToDateTime(missionActuelle["dateDepart"]);
            dtpDateDepense.MaxDate = Convert.ToDateTime(missionActuelle["dateRetour"]);
            dtpDateDepense.Width = 200;


            lblMontantDepense.Top = top + lblDateDepense.Height + 20;
            lblMontantDepense.Left = left;

            txtMontantDepense.Top = lblMontantDepense.Top;
            txtMontantDepense.Left = lblMontantDepense.Width + 20 + left;

            lblMotifDepense.Left = left;
            lblMotifDepense.Top = lblMontantDepense.Top + lblMontantDepense.Height + 20;

            rtxtMotifDepense.Top = lblMotifDepense.Top + lblMotifDepense.Height + 20;
            rtxtMotifDepense.Left = left;
            rtxtMotifDepense.Width = grpFormDepense.Width - 40;
            rtxtMotifDepense.Height = 100;

            lblTypeDepense.Left = left;
            lblTypeDepense.Top = rtxtMotifDepense.Top + rtxtMotifDepense.Height + 20;

            cboTypeDepense.Top = rtxtMotifDepense.Top + rtxtMotifDepense.Height + 20;
            cboTypeDepense.Left = lblTypeDepense.Width + 20 + left;
            cboTypeDepense.DataSource = MesDatas.DsGlobal.Tables["TypeDepense"];
            cboTypeDepense.DisplayMember = "libelle";
            cboTypeDepense.ValueMember = "id";
        }

        private void AfficherFormContact()
        {
            int top = 40;
            int left = 20;
            grpFormCapture.Visible = false;
            grpFormDepense.Visible = false;
            grpFormDepense.Visible = false;
            grpFormContact.Visible = true;

            lblDateContact.Top = top;
            lblDateContact.Left = left;


            dtpDateContact.Top = lblDateContact.Top;
            dtpDateContact.Left = lblDateContact.Width + 20 + left;
            dtpDateContact.MinDate = Convert.ToDateTime(missionActuelle["dateDepart"]);
            dtpDateContact.MaxDate = Convert.ToDateTime(missionActuelle["dateRetour"]);
            dtpDateContact.Width = 200;



            lblNombre.Top = top + lblDateContact.Height + 20;
            lblNombre.Left = left;

            txtSomme.Top = lblNombre.Top;
            txtSomme.Left = lblNombre.Width + 20 + left;

            lblAppreciation.Left = left;
            lblAppreciation.Top = lblNombre.Top + lblNombre.Height + 20;

            rtxtAppreciation.Top = lblAppreciation.Top + lblAppreciation.Height + 20;
            rtxtAppreciation.Left = left;
            rtxtAppreciation.Width = grpFormContact.Width - 40;
            rtxtAppreciation.Height = 100;

            lblInformateur.Left = left;
            lblInformateur.Top = rtxtAppreciation.Top + rtxtAppreciation.Height + 20;

            cboInformateur.Top = rtxtAppreciation.Top + rtxtAppreciation.Height + 20;
            cboInformateur.Left = lblInformateur.Width + 20 + left;
            cboInformateur.DataSource = MesDatas.DsGlobal.Tables["Informateur"];
            cboInformateur.DisplayMember = "nom";
            cboInformateur.ValueMember = "nomCode";
        }

        private void AfficherFormEvent()
        {
            int top = 40;
            int left = 20;
            grpFormEvent.Visible = true;
            grpFormCapture.Visible = false;
            grpFormContact.Visible = false;
            grpFormDepense.Visible = false;

            lblDateAjoutEvent.Top = top;
            lblDateAjoutEvent.Left = left;

            dtpDateEvent.Top = lblDateAjoutEvent.Top;
            dtpDateEvent.Left = lblDateAjoutEvent.Width + 20 + left;
            dtpDateEvent.MinDate = Convert.ToDateTime(missionActuelle["dateDepart"]);
            dtpDateEvent.MaxDate = Convert.ToDateTime(missionActuelle["dateRetour"]); 
            dtpDateEvent.Width = 200;


            lblCommentaireEvent.Left = left;
            lblCommentaireEvent.Top = lblDateAjoutEvent.Top + lblDateAjoutEvent.Height + 20;

            rtxtCommentaire.Top = lblCommentaireEvent.Top + lblCommentaireEvent.Height + 40;
            rtxtCommentaire.Left = left;
            rtxtCommentaire.Width = grpFormEvent.Width - 40;
        }

        private void AfficherFormCapture()
        {
            int top = 40;
            int left = 20;
            grpFormCapture.Visible = true;
            grpFormContact.Visible = false;
            grpFormDepense.Visible = false;
            grpFormEvent.Visible = false;
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

            lblCapture.Left = left;
            lblCapture.Top = top;

            cboCapture.Top = top;
            cboCapture.Left = left + lblCapture.Width + 20;

            lblNombre.Top = top + lblCapture.Height + 20;
            lblNombre.Left = left;
            lblNombre.Height = 25;

            txtNombre.Top = lblNombre.Top;
            txtNombre.Left = cboCapture.Left;
        }

        private void btnValidationAjout_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string tag = "";
            foreach (RadioButton rdb in grpChoixAjout.Controls.OfType<RadioButton>())
            {
                if (rdb.Checked)
                {
                    tag = rdb.Tag.ToString();
                }
            }

            switch (tag)
            {
                case "1":
                    ajoutContact();
                    break;
                case "2":
                    AjoutDepense();
                    break;
                case "3":
                    AjoutEvent();
                    break;
                case "4":
                    AjoutCapture();
                    break;
                default:
                    MessageBox.Show("Une erreur est survenue");
                    break;
            }
        }
        
        public void AjoutEvent()
        {
            SQLiteConnection co = Connexion.Connec;

            try
            {
                string date = dtpDateEvent.Value.ToString("yyyy-MM-dd");
                string commentaire = rtxtCommentaire.Text;
                string request = $"INSERT INTO JournalDeBord(nomPlanete, numero, dateJ, commentaires) VALUES ('{missionActuelle["nomPlanete"].ToString()}','{missionActuelle["numero"].ToString()}','{date}','{commentaire}')";
                MessageBox.Show(request);
                SQLiteCommand cmd = new SQLiteCommand(request,co);
                int res = cmd.ExecuteNonQuery();
                MessageBox.Show(res.ToString());


                DataRow eventRow = MesDatas.DsGlobal.Tables["JournalDeBord"].NewRow();
                eventRow[0] = missionActuelle["nomPlanete"];
                eventRow[1] = missionActuelle["numero"];
                eventRow[2] = date;
                eventRow[3] = commentaire;
                MesDatas.DsGlobal.Tables["JournalDeBord"].Rows.Add(eventRow);

            } catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Connexion.FermerConnexion(); }
        }

        public void AjoutCapture()
        {
            SQLiteConnection co = Connexion.Connec;

            try
            {
                string nomPlanete = missionActuelle[0].ToString();
                string numeroMission = missionActuelle[1].ToString();
                string id = cboCapture.SelectedValue.ToString();
                int nombre = Convert.ToInt32(txtNombre.Text.Replace("'","''"));

                string verifRequest = $"SELECT Count(idEspeceEnnemi) FROM Capturer WHERE idEspeceEnnemi = '{id}'";
                SQLiteCommand verifCmd = new SQLiteCommand(verifRequest, co);
                int res = Convert.ToInt32(verifCmd.ExecuteScalar());

                if (res == 0)
                {
                    string insertRequest = $"INSERT INTO Capturer(nomPlanete, numeroMission, idEspeceEnnemi, nombre) VALUES ('{nomPlanete}','{numeroMission}','{id}',{nombre})";

                    SQLiteCommand cmd = new SQLiteCommand(insertRequest, co);
                    int resInsert = cmd.ExecuteNonQuery();
                    MessageBox.Show(resInsert.ToString());

                    DataRow drNewCapture = captureMissionActuelle.NewRow();
                    drNewCapture[0] = cboCapture.Text;
                    if (MesDatas.DsGlobal.Tables["ObjectifCapture"].Select($"idEspeceEnnemi = {id}").Length == 0)
                    {
                        drNewCapture[1] = 1;
                    }
                    else
                    {
                        drNewCapture[1] = MesDatas.DsGlobal.Tables["ObjectifCapture"].Select($"idEspeceEnnemi = {id}")[0][3];
                    }
                    drNewCapture[2] = nombre;
                    drNewCapture[3] = Convert.ToInt32(nombre) * 100 / Convert.ToInt32(drNewCapture[1]);
                    captureMissionActuelle.Rows.Add(drNewCapture);
                }
                else
                {
                    string request = $"UPDATE Capturer SET nombre = nombre + {nombre} WHERE nomPlanete = '{nomPlanete}' AND numeroMission = '{numeroMission}' AND idEspeceEnnemi = '{id}'";
                    SQLiteCommand cmd = new SQLiteCommand(request, co);
                    int resUpdate = cmd.ExecuteNonQuery();
                    DataRow drCapture = captureMissionActuelle.Select($"[Nom de l'espèce] = '{cboCapture.Text}'")[0];
                    drCapture[2] = (Convert.ToInt32(drCapture[2]) + nombre).ToString();
                    drCapture[3] = Convert.ToInt32(drCapture[2]) * 100 / Convert.ToInt32(drCapture[1]);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Connexion.FermerConnexion(); }
        }


        public void AjoutDepense()
        {
            SQLiteConnection co = Connexion.Connec;

            try
            {
                string nomPlanete = missionActuelle[0].ToString();
                string numeroMission = missionActuelle[1].ToString();
                int id = Convert.ToInt32(depenseMissionActuelle.Compute("max([N°])",string.Empty)) + 1;
                string date = dtpDateDepense.Value.ToString("yyyy-MM-dd");
                string montant = txtMontantDepense.Text.Replace("'","''");
                string motif = rtxtMotifDepense.Text.Replace("'","''");
                string idTypeDepense = cboTypeDepense.SelectedValue.ToString();

                string request = $"INSERT INTO Depense(nomPlanete, numeroMission, id, dateD, montant, motif, idTypeDepense) VALUES ('{nomPlanete}','{numeroMission}','{id}','{date}','{montant}','{motif}','{idTypeDepense}')";

                SQLiteCommand cmd = new SQLiteCommand(request, co);
                int res = cmd.ExecuteNonQuery();
                MessageBox.Show(res.ToString());
                DataRow dr = depenseMissionActuelle.NewRow();
                dr[0] = id;
                dr[1] = date;
                dr[2] = motif;
                dr[3] = montant;
                dr[4] = MesDatas.DsGlobal.Tables["TypeDepense"].Select($"id = {idTypeDepense}")[0][1];
                depenseMissionActuelle.Rows.Add(dr);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { Connexion.FermerConnexion(); }
        }

        public void ajoutContact()
        {
            SQLiteConnection co = Connexion.Connec;

            try
            {
                string nomPlanete = missionActuelle[0].ToString();
                string numeroMission = missionActuelle[1].ToString();
                string date = dtpDateContact.Value.ToString("yyyy-MM-dd");
                string sommeVersee = txtSomme.Text.Replace("'", "''");
                string appreciation = rtxtAppreciation.Text.Replace("'", "''");
                string nomCodeInformateur = cboInformateur.SelectedValue.ToString();
                string request = $"INSERT INTO Contact(nomPlanete, numeroMission, dateC, sommeVersee, appreciation, nomCodeInformateur) VALUES ('{nomPlanete}','{numeroMission}','{date}','{sommeVersee}','{appreciation}','{nomCodeInformateur}')";

                SQLiteCommand cmd = new SQLiteCommand(request, co);
                int res = cmd.ExecuteNonQuery();
                MessageBox.Show(res.ToString());
                DataRow dr = contactMissionActuelle.NewRow();
                dr[0] = date;
                dr[1] = sommeVersee;
                dr[2] = appreciation;
                dr[3] = MesDatas.DsGlobal.Tables["Espece"].Select($"id = {nomCodeInformateur}")[1];
                contactMissionActuelle.Rows.Add(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connexion.FermerConnexion();
            }
        }
    }
}
