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
    public partial class MembreEquipage : UserControl
    {
        public MembreEquipage()
        {
            InitializeComponent();
        }

        public string SetImage
        {
            set
            {
                pbMembre.Image = Image.FromFile($"../../Images/Membres/{value}.png");
            }
        }

        public string setText
        {
            set
            {
                lblMembre.Text = value; 
            }
        }
    }
}
