using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decimale_getallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Berekenen_Click(object sender, EventArgs e)
        {
            decimal[] prijzen = { (decimal)200000.79, (decimal)400000.88, (decimal)600000.77, (decimal)800000.66, (decimal)999999.55 };
            decimal totaal = 0;
            foreach (int prijs in prijzen)
            {
                totaal += prijs;
            }
            txbUitvoer.Text = totaal.ToString();
        }

        private void BtnResize_Click(object sender, EventArgs e)
        {
            decimal[] prijzen = { (decimal)200000.79, (decimal)400000.88, (decimal)600000.77, (decimal)800000.66, (decimal)999999.55 };
            Array.Resize(ref prijzen, 10);
            Array.Sort(prijzen);
            foreach (int prijs in prijzen)
            {
                txbUitvoer.Text = txbUitvoer.Text + prijs.ToString() + "\r\n";
            }
        }
    }
}
