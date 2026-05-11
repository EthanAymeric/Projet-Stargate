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

namespace SAE24
{
    public partial class Form1 : Form
    {
        DataSet ds = MesDatas.DsGlobal;
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
                da.Fill(ds, r[2].ToString());
            }

            Connexion.FermerConnexion();
        }
        private void btnTDB_Click(object sender, EventArgs e)
        {

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
