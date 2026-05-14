using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlPlanetes
{
    public partial class UserControlPlanete: UserControl
    {
        public UserControlPlanete()
        {
            InitializeComponent();
        }

        public UserControlPlanete(string nomImagePlanete, string nomImageTemp, string nomPlanete, string temp, float gravite, Int64 presenceDatabaz, List<string> especesPresentes, List<string> missionsRealisees, Int64 pourcentageAllies, Int64 pourcentageEnnemis)
        {
            InitializeComponent();
            // Ajout des éléments textuels
            lblNomPlanete.Text = nomPlanete;
            lblTemp.Text = temp;
            lblGraviteValue.Text = gravite.ToString();

            lblAlliesValue.Text = pourcentageAllies + " %";
            lblEnnemisValue.Text = pourcentageEnnemis + " %";

            // Dire s'il y a du Databz ou pas
            if (presenceDatabaz == 1)
            {
                lblPresenceDatabaz.Text = "Présence de Databaz";
            }
            else
            {
                lblPresenceDatabaz.Text = "Absence de Databaz";
            }


            // Parcours de la liste des espèces pour afficher toutes les espèces proprement
            // S'il n'y a qu'une espèce, on n'affiche que celle-là
            if (especesPresentes.Count() == 1)
            {
                lblEspecesValue.Text = especesPresentes[0];
                lblEspecesCommun.Text = "Espèce présente : ";
            }
            // S'il n'y en a aucune, on le dit
            else if (especesPresentes.Count() == 0)
            {
                lblEspecesValue.Text = "Pas d'espèces (connues)";
            }
            // Sinon, on parcourt et on affiche toutes les espèces
            else
            {
                string texte = "";
                for (int i = 0; i < especesPresentes.Count() - 1; i++)
                {
                    texte += especesPresentes[i] + ", ";
                }
                texte += " et " + especesPresentes[especesPresentes.Count()];

                lblEspecesValue.Text = texte;
            }

            // Parcours de la liste des missions pour afficher toutes les missions proprement
            // S'il n'y a qu'une mission, on n'affiche que celle-là
            if (missionsRealisees.Count() == 1)
            {
                lblMissionsValue.Text = missionsRealisees[0];
            }
            // S'il n'y en a aucune, on le dit
            else if (missionsRealisees.Count() == 0)
            {
                lblMissionsValue.Text = "Aucune mission réalisée";
            }
            // Sinon, on parcourt et on affiche toutes les espèces
            else
            {
                string texte = "";
                for (int i = 0; i < missionsRealisees.Count() - 1; i++)
                {
                    texte += missionsRealisees[i] + ", ";
                }
                texte += " et " + missionsRealisees[missionsRealisees.Count()];

                lblMissionsValue.Text = texte;
            }

            // Ajout des images pour la planète et le thermomètre (température)
            if (nomImagePlanete != string.Empty)
            {
                pbPlanete.Image = Image.FromFile(nomImagePlanete);
                pbPlanete.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (nomImageTemp != string.Empty)
            {
                pbTemp.Image = Image.FromFile(nomImageTemp);
                pbTemp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
