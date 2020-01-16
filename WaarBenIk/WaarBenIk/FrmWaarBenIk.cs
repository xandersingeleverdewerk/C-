using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaarBenIk
{
    public partial class FrmWaarBenIk : Form
    {
        public FrmWaarBenIk()
        {
            InitializeComponent();
        }

        private void FrmWaarBenIk_Load(object sender, EventArgs e)
        {

        }

        private void FrmWaarBenIk_MouseClick(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
            pnlLocation.Location = e.Location;
        }
    }
}
