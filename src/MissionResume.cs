using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE24
{
    public partial class MissionResume : UserControl
    {

        public MissionResume()
        {
            InitializeComponent();
        }

        public MissionResume(string nomMission, string dateDeb, string duree, string chef)
        {
            InitializeComponent();
            lblNomMission.Text = nomMission;
            lblDateDeb.Text = dateDeb;
            lblDuree.Text = $"{duree} Jours";
            lblChef.Text = chef;
            lblNomMission.Visible = true;
            lblDateDeb.Visible = true;
            lblDuree.Visible = true;
            lblChef.Visible = true;
            string nomPlanete = nomMission.Substring(0, nomMission.Length - 1);
            pbPlanete.Image = Image.FromFile($"../../Images/Planetes/{nomPlanete}.png");
        }

        private void MissionResume_Load(object sender, EventArgs e)
        {

        }

        private void MissionResume_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void MissionResume_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void pbPlanete_Click(object sender, EventArgs e)
        {
            FormulaireMission frm = new FormulaireMission(lblNomMission.Text);
            frm.ShowDialog();
        }
    }
}
