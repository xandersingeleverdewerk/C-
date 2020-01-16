using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teksten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNaam_Click(object sender, EventArgs e)
        {
            String[] namen = { "Jan", "piet", "Klaas", "Kees", "Xander" };
            int result = namen.GetLength(0);
            int regel = 0;
            int regelnummer = 0;
            try
            {
                regelnummer = int.Parse(txbRegelnummer.Text) - 1;
                regel = regelnummer;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            if (regelnummer > result)
            {
                textBox1.Text = "kies een lagere waarde";
            }
            else
            {
                textBox1.Text = "Op regelnummer " + regelnummer + " staat de naam " + (namen[regel].ToString());
            }
        }

        private void Uitvoer_Click(object sender, EventArgs e)
        {
            String[] namen = { "Jan", "piet", "Klaas", "Kees", "Xander" };
            Array.Sort(namen);
            int lengteArray = namen.Length;
            textBox1.Text = namen[0].ToString();
            for (int index=1; index<lengteArray; index++)
            {
                textBox1.Text = textBox1.Text + "," + namen[index].ToString();
            }
        }
    }
}
