using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SAE24
{
    public partial class FormCreationMission : Form
    {
        public FormCreationMission()
        {
            InitializeComponent();
        }

        private void FormCreationMission_Load(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = @"select nom from planete";

            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxPlanete.Items.Add(reader.GetString(0));
            }

            reloadComboBoxChef();

            cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = @"select count(*) from Membre";
            trackBarNbMembres.Maximum = Convert.ToInt32(cmd.ExecuteScalar());

            Connexion.FermerConnexion();
        }

        private void reloadComboBoxChef()
        {
            string depart = dateTimePickerDepart.Value.ToString("yyyy-MM-dd");
            string retour = dateTimePickerRetour.Value.ToString("yyyy-MM-dd");

            SQLiteCommand cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = $@"SELECT DISTINCT m.grade || ' · ' || me.nom || ' ' || me.prenom, me.matricule
            FROM Militaire m
JOIN Membre me ON m.matriculeMembre = me.matricule
WHERE me.matricule NOT IN(
    SELECT c.matriculeMembre
    FROM Composer c
    JOIN Mission mi ON c.nomPlanete = mi.nomPlanete AND c.numeroMission = mi.numero
    WHERE mi.dateDepart <= '{retour}' AND mi.dateRetour >= '{depart}')
ORDER BY m.grade";

            SQLiteDataReader reader = cmd.ExecuteReader();
            Dictionary<string, string> result = new Dictionary<string, string>();

            while (reader.Read())
            {
                result.Add(reader.GetString(0), reader.GetString(1));
            }

            comboBoxChef.DataSource = new BindingSource(result, null);
            comboBoxChef.DisplayMember = "Key";
            comboBoxChef.ValueMember = "Value";
        }

        private int nbMissionsPlanete(String planete)
        {
            SQLiteCommand cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = $@"select count(*) 
from Mission 
where lower(nomPlanete) = lower('{comboBoxPlanete.SelectedItem}')";

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void comboBoxPlanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(comboBoxPlanete, "");
            int nbMissions = nbMissionsPlanete(comboBoxPlanete.SelectedItem.ToString());
            labelNomMission.Text = $"Nom de mission: {comboBoxPlanete.SelectedItem} - {nbMissions + 1}";
        }

        private void dateTimePickerDepart_ValueChanged(object sender, EventArgs e)
        {
            reloadComboBoxChef();
            dateTimePickerRetour.MinDate = dateTimePickerDepart.Value;
            int nbJours = calculerTempsMission().Days;

            labelDuree.Text = $"Durée: {nbJours} jour";

            if (nbJours > 1)
            {
                labelDuree.Text += "s";
            }
        }

        private void dateTimePickerRetour_ValueChanged(object sender, EventArgs e)
        {
            reloadComboBoxChef();
            dateTimePickerDepart.MaxDate = dateTimePickerRetour.Value;
            int nbJours = calculerTempsMission().Days;

            labelDuree.Text = $"Durée: {nbJours} jour";

            if (nbJours > 1)
            {
                labelDuree.Text += "s";
            }
        }

        private TimeSpan calculerTempsMission()
        {
            DateTime depart = dateTimePickerDepart.Value;
            DateTime retour = dateTimePickerRetour.Value;

            return retour.Subtract(depart);
        }

        private void trackBarNbMembres_Scroll(object sender, EventArgs e)
        {
            labelMembres.Text = trackBarNbMembres.Value.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider.SetError((TextBox)sender, "");
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            if (comboBoxPlanete.SelectedIndex < 0) // si rien n'est sélectionné
            {
                errorProvider.SetError(comboBoxPlanete, "Le nom de planète doit être sélectionné");
                erreur = true;
            }
            if (richTextBoxFeuilleRoute.Text == String.Empty)
            {
                errorProvider.SetError(richTextBoxFeuilleRoute, "La feuille de route doit être saisie");
                erreur = true;
            }
            if (textBoxDatabaz.Text == String.Empty)
            {
                errorProvider.SetError(textBoxDatabaz, "L'objectif de databaz doit être saisi");
                erreur = true;
            }
            if (textBoxBudget.Text == String.Empty)
            {
                errorProvider.SetError(textBoxBudget, "Le budget doit être saisi");
                erreur = true;
            }
            if (erreur)
            {
                return;
            }

            string planete = comboBoxPlanete.SelectedItem.ToString();
            int num = nbMissionsPlanete(planete) + 1;
            int nbMembres = trackBarNbMembres.Value;
            string depart = dateTimePickerDepart.Value.ToString("yyyy-MM-dd");
            string retour = dateTimePickerRetour.Value.ToString("yyyy-MM-dd");
            string matriculeChef = comboBoxChef.SelectedValue.ToString();
            string feuille = richTextBoxFeuilleRoute.Text;
            feuille = feuille.Replace("'", "''");
            int databaz = int.Parse(this.textBoxDatabaz.Text);
            int budget = int.Parse(textBoxBudget.Text);

            SQLiteCommand cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = $@"insert into Mission (nomPlanete, numero, nbMembreRequis, dateDepart, dateRetour, matriculeChef, feuilleDeRoute, objectifDatabaz, budget) 
values ('{planete}', {num}, {nbMembres}, '{depart}', '{retour}', '{matriculeChef}', '{feuille}', {databaz}, {budget})";

            if (cmd.ExecuteNonQuery() == 1) {
                MessageBox.Show("Mission créée !");
            }
        }

        private void richTextBoxFeuilleRoute_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider.SetError(richTextBoxFeuilleRoute, "");
        }
    }
}
