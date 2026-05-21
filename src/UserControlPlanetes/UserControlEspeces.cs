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
    public partial class UserControlEspeces : UserControl
    {
        public UserControlEspeces()
        {
            InitializeComponent();
        }

        public UserControlEspeces(string nomImageEspece, string nomEspece, string couleur, List<string> planeteOrigine)
        {
            InitializeComponent();

            // Initialisation des différents labels composants la fiche de présentation générale des espèces
            lblNomEspece.Text = nomEspece;
            lblCouleur.Text = "Couleur : " + couleur;
            /*
            Color afficher = Color.FromName(couleur);
            lblCouleur.ForeColor = afficher;
            */

            // Vérification spéciale pour l'affichage de la/des planète(s) d'origine
            // Si cette(ces) dernière(s) existe(nt), on l'(les) affiche(nt)
            if (planeteOrigine.Count == 0)
            {
                // Sinon, on affiche "Origine inconnue" et on change la couleur du texte
                lblOrigine.Text = "Origine inconnue";
                lblOrigine.ForeColor = Color.Red;
                lblNbPlanete.Visible = false;
            }

            // S'il n'y a qu'une seule planète, on n'affiche que celle-là
            else if (planeteOrigine.Count == 1)
            {
                lblOrigine.Text = planeteOrigine[0];
            }
            // Sinon, on les affiche toutes les unes après les autres
            else
            {
                lblNbPlanete.Text = "Planètes d'origine : ";

                string texte = "";
                foreach(string planete in planeteOrigine)
                {
                    texte += planete + "/";
                }
                lblOrigine.Text = texte.Remove(texte.Length-1);
                /*
                for (int i = 0; i < planeteOrigine.Count; i++)
                {
                    texte += planeteOrigine[i] + "/";   // Affichage des éléments de la liste avec la virgule
                }
                texte += planeteOrigine[planeteOrigine.Count];  // Affichage du dernier élément de la liste SANS la virgule
                */
            }

            // Ajout de l'image pour l'espèce
            if (nomImageEspece != string.Empty)
            {
                pbEspece.Image = Image.FromFile(nomImageEspece);
                pbEspece.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void UserControlEspeces_Load(object sender, EventArgs e)
        {

        }

        private void lblNomEspece_Click(object sender, EventArgs e)
        {

        }
    }
}
