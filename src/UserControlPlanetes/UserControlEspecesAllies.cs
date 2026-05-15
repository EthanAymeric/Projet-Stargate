using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlPlanetes
{
    public partial class UserControlEspecesAlliees : UserControl
    {
        public UserControlEspecesAlliees()
        {
            InitializeComponent();
        }

        public UserControlEspecesAlliees(string nomImageEspeceAlliee, string couleur, string nomEspeceAlliee, string degreBienveillance, List<string> planeteOrigine, string premierContact, string instrument)
        {
            InitializeComponent();

            // Initialisation des différents labels composants la fiche de présentation générale des espèces alliées
            lblNomEspeceAlliee.Text = nomEspeceAlliee;
            lblDegreBienveillance.Text = degreBienveillance;
            lblInstrument.Text = instrument;
            lblDatePremierContact.Text = premierContact;
            lblCouleur.Text = "Couleur : " + couleur;

            // Vérification spéciale pour l'affichage de la/des planète(s) d'origine
            // Si cette(ces) dernière(s) existe(nt), on l'(les) affiche(nt)
            if (planeteOrigine.Count != 0)
            {
                // S'il n'y a qu'une seule planète, on n'affiche que celle-là
                if (planeteOrigine.Count == 1)
                {
                    lblOrigine.Text = planeteOrigine[0];
                }
                // Sinon, on les affiche toutes les unes après les autres
                else
                {
                    lblNbPlanete.Text = "Planètes d'origine : ";

                    string texte = "";
                    for (int i = 0; i < planeteOrigine.Count - 1; i++)
                    {
                        texte += planeteOrigine[i] + ", ";   // Affichage des éléments de la liste avec la virgule
                    }
                    texte += planeteOrigine[planeteOrigine.Count];  // Affichage du dernier élément de la liste SANS la virgule
                }
            }
            // Sinon, on affiche "Origine inconnue" et on change la couleur du texte
            else
            {
                lblOrigine.Text = "Origine inconnue";
                lblOrigine.ForeColor = Color.Red;
            }

            // Ajout de l'image pour l'espèce
            if (nomImageEspeceAlliee != string.Empty)
            {
                pbEspeceAlliee.Image = Image.FromFile(nomImageEspeceAlliee);
                pbEspeceAlliee.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void UserControlEspecesAlliees_Load(object sender, EventArgs e)
        {

        }
    }
}
