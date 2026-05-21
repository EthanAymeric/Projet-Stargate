using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BCrypt.Net;

namespace SAE24
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
    }

        private void genererErreurLoginMdp()
        {
            errorProvider.SetError(textBoxLogin, "Login ou Mot de passe incorrect");
            errorProvider.SetError(textBoxMdp, "Login ou Mot de passe incorrect");
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            String login = this.textBoxLogin.Text;
            String mdp = this.textBoxMdp.Text;

            // si le nom d'utilisateur ou mdp n'a pas été renseigné 
            if (login == string.Empty)
            {
                errorProvider.SetError(textBoxLogin, "Le nom d'utilisateur doit être renseigné");
            }

            if (mdp == string.Empty)
            {
                errorProvider.SetError(textBoxMdp, "Le mot de passe doit être renseigné");
            }

            if (login == string.Empty || mdp == string.Empty)
            {
                Connexion.FermerConnexion();
                return;
            }

            SQLiteCommand cmd = new SQLiteCommand($"select mdp from Admin where login = '{login}'", 
                Connexion.Connec);
            Object obj = cmd.ExecuteScalar();

            // si le login n'existe pas 
            if (obj == null)
            {
                this.genererErreurLoginMdp();
                Connexion.FermerConnexion();
                return;
            }

            String mdpHash = obj.ToString();
            bool valide = BCrypt.Net.BCrypt.Verify(mdp, mdpHash); // on vérifie que le mot de passe correspond

            if (valide)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                genererErreurLoginMdp();
            }

            Connexion.FermerConnexion();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // supprime l'erreur 
            if (e.KeyChar != (char)Keys.Back)
            {
                errorProvider.SetError(textBoxLogin, "");
            }

            e.Handled = e.KeyChar == (char)Keys.Space || e.KeyChar == '\'';
        }

        private void textBoxMdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // supprime l'erreur 
            if (e.KeyChar != (char)Keys.Back)
            {
                errorProvider.SetError(textBoxMdp, "");
            }

            e.Handled = e.KeyChar == '\'';
        }

        private void checkBoxAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMdp.UseSystemPasswordChar = !checkBoxAfficherMdp.Checked;
        }
    }
}
