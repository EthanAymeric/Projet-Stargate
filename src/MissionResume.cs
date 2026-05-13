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
            pbPlanete.Image = Image.FromFile("../../Images/Planetes/Kobaia.png");
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
    }
}
