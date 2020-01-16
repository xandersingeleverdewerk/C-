using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selectie
{
    public partial class Selectie : Form
    {
        public Selectie()
        {
            InitializeComponent();
        }

        private void CheckBoxMeisje_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMeisje.Checked == true)
            {
                checkBoxMeisje.Checked = true;
                checkBoxJongen.Checked = false;
            }
        }

        private void CheckBoxJongen_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJongen.Checked == true)
            {
                checkBoxMeisje.Checked = false;
                checkBoxJongen.Checked = true;
            }
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            DateTime geboortedatum = DateTime.Parse(Geboortedatum.Value.ToString());
            DateTime schoolfeest = DateTime.Parse(dtpSchoolfeest.Value.ToString());
            long leeftijd = (DateTime.Now.Year - geboortedatum.Year);

            if (leeftijd >= 18)
            {
                MessageBox.Show("Drink bier in plaats van water, dan heb je morgen een flinke kater");
            }

            else
            {
                MessageBox.Show("Je mag nog geen alcohol drinken.");

                if (checkBoxMeisje.Checked == true)
                {
                    MessageBox.Show("Wat wil je dan drinken?");
                }
                else
                {
                    MessageBox.Show("Je hebt pech en krijgt vandaag alleen nog maar water.");
                    MessageBox.Show("Je mag pas alcohol drinken vanaf " + geboortedatum.AddYears(18).ToShortDateString());
                }
            }
        }

        private void BtnMagIkDanAlcoholDrinken_Click(object sender, EventArgs e)
        {
            DateTime geboortedatum = DateTime.Parse(Geboortedatum.Value.ToString());
            DateTime schoolfeest = DateTime.Parse(dtpSchoolfeest.Value.ToString());
            
            if (dtpSchoolfeest.Value < geboortedatum.AddYears(18))
            {
                MessageBox.Show("Je bent dan nog niet oud genoeg om alcohol te drinken.");
            }
            else
            {
                MessageBox.Show("Je bent dan oud genoeg om alcohol te drinken.");
            }
        }
    }
}
