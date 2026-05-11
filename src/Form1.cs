using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace SAE24
{
    public partial class Form1 : Form
    {
        SQLiteConnection co;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            co = Connexion.Connec;
            DataTable mesDT = co.GetSchema("Tables");

            foreach (DataRow r in mesDT.Rows)
            {
                string request = $"SELECT * FROM {r[2].ToString()}";
                SQLiteCommand cmd = new SQLiteCommand(request, co);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(MesDatas.DsGlobal, r[2].ToString());
            }

            Connexion.FermerConnexion();
        }
        private void btnTDB_Click(object sender, EventArgs e)
        {
            int top = 20, left = 20;
            foreach (DataRow r in MesDatas.DsGlobal.Tables["Mission"].Rows)
            {
                string nomMission = r["NomPlanete"].ToString() + r["numero"].ToString();
                string strDateDepart = r["dateDepart"].ToString();
                DateTime dateRetour = DateTime.Parse(r["dateRetour"].ToString());
                DateTime dateDepart = DateTime.Parse(r["dateDepart"].ToString());
                TimeSpan duree = dateRetour.Subtract(dateDepart);
                string strDuree = duree.ToString("dd");
                string chef = r["matriculeChef"].ToString();


                MissionResume mr = new MissionResume(nomMission, strDateDepart, strDuree, chef);
                mr.Top = top;
                mr.Left = left;
                pnlTDB.Controls.Add(mr);

                top += 150;
            }


        }

        private void btnNouvelleMission_Click(object sender, EventArgs e)
        {

        }

        private void btnRaces_Click(object sender, EventArgs e)
        {

        }

        private void btnPlanetes_Click(object sender, EventArgs e)
        {

        }
    }
}
