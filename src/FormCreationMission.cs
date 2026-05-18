using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = @"select m.grade || ' · ' || me.nom || ' ' || me.prenom
from Militaire m
join Membre me on m.matriculeMembre = me.matricule
order by m.grade";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxChef.Items.Add(reader.GetString(0));
            }

            Connexion.FermerConnexion();
        }

        private void comboBoxPlanete_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand cmd = new SQLiteCommand(Connexion.Connec);
            cmd.CommandText = $@"select count(*) 
from Mission 
where lower(nomPlanete) = lower('{comboBoxPlanete.SelectedItem}')";
            int nbMission = Convert.ToInt32(cmd.ExecuteScalar()) + 1;

            labelNomMission.Text = $"Nom de mission: {comboBoxPlanete.SelectedItem} - {nbMission}";
        }

        private void dateTimePickerDepart_ValueChanged(object sender, EventArgs e)
        {
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
    }
}
