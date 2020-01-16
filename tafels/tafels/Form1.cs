using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tafels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) {
                MessageBox.Show("Voer een getal in!");
                return;
            }

            textBox2.Text = "";

            int num = Convert.ToInt32(textBox1.Text);
            for (int n = 1; n < 11; n++)
            {
                int nn = n * num;
                textBox2.Text += n + " x " + num + " = " + nn + "\r\n";
            }
        }
    }
}
