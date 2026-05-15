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
    public partial class MissionPB : UserControl
    {
        public MissionPB()
        {
            InitializeComponent();
        }

        public string SetImage
        {
            set
            {
                this.pictureBox1.Image = Image.FromFile($"../../Images/Planetes/{value}.png");
            }
        }

        public string SetText
        {
            set
            {
                this.lblMissionNom.Text = value;
            }
        }

    }
}
