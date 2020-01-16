using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Welkom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String naam = Environment.UserName;
            textBox1.Text = "Beste (" + naam + "), \r\n Welkom in ons systeem. Zoals je zult begrijpen zijn er enkele regels op ons \r\n systeem van toepassing waar iedere gebruiker zich aan moet houden. Door op de \r\n knop 'ok' te klikken gaat  ermee akkoord dat de systeembeheerde onbeperkt \r\n toegang heeft tot uw computer";
        }
    }
}
