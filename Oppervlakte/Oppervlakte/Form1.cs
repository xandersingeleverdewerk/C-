using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oppervlakte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BerekenOppervlakte_Click(object sender, EventArgs e)
        {
            decimal lengte = Convert.ToDecimal(txbLengte.Text);
            decimal breedte = Convert.ToDecimal(txbBreedte.Text);
            if (lengte == breedte)
            {
                textBox1.Text = "Bij een rechthoek kan de lengte en de breedte niet hetzelfde zijn";
            }
            else
            {
                decimal oppervlakte = lengte * breedte;

                textBox1.Text = Convert.ToString(oppervlakte);
            }
        }

        private void BerekenOmtrek_Click(object sender, EventArgs e)
        {
            decimal lengte = Convert.ToDecimal(txbLengte.Text);
            decimal breedte = Convert.ToDecimal(txbBreedte.Text);
            if (lengte == breedte)
            {
                textBox1.Text = "Bij een rechthoek kan de lengte en de breedte niet hetzelfde zijn";
            }
            else
            {
                decimal omtrek = lengte + lengte + breedte + breedte;

                textBox2.Text = Convert.ToString(omtrek);
            }
        }
    }
}
