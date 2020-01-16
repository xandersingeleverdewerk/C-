using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            byte getal1;
            sbyte getal2;
            int antwoord = 0;

            try
            {
                getal1 = byte.Parse(txbGetal1.Text);
                getal2 = sbyte.Parse(txbGetal2.Text);
                antwoord = getal1 + getal2;
                errorProvider1.SetError(txbGetal1, "");
                errorProvider2.SetError(txbGetal2, "");
            }
            catch (Exception exception)
            {
                errorProvider1.SetError(txbGetal1, exception.Message);
                errorProvider2.SetError(txbGetal2, exception.Message);
            }
            lblAntwoord.Text = antwoord.ToString();
        }
    }
}
