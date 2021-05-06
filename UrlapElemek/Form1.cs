using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlapElemek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RedBtn_CheckedChanged(object sender, EventArgs e)
        {
            valtLabel.ForeColor = Color.Red;
        }

        private void GreenBtn_CheckedChanged(object sender, EventArgs e)
        {
            valtLabel.ForeColor = Color.MediumSeaGreen;
        }

        private void BlueBtn_CheckedChanged(object sender, EventArgs e)
        {
            valtLabel.ForeColor = Color.DodgerBlue;
        }

        private void ThirtyBtn_CheckedChanged(object sender, EventArgs e)
        {
            valtLabel.Font = new Font(valtLabel.Font.Name, 30);
        }

        private void FortyBtn_CheckedChanged(object sender, EventArgs e)
        {
            valtLabel.Font = new Font(valtLabel.Font.Name, 40);
        }

        private void FiftyBtn_CheckedChanged(object sender, EventArgs e)
        {
            valtLabel.Font = new Font(valtLabel.Font.Name, 50);
        }

        private void OsszeadBtn_Click(object sender, EventArgs e)
        {
            int osszeg = 0;

            if (otForintCBox.Checked == true)
            {
                osszeg += 5;
            }

            if (tizForintCbox.Checked == true)
            {
                osszeg += 10;
            }

            if (huszForintCbox.Checked == true)
            {
                osszeg += 20;
            }

            if (otvenForintCbox.Checked == true)
            {
                osszeg += 50;
            }

            if (szazForintCbox.Checked == true)
            {
                osszeg += 100;
            }

            if (ketszazForintCbox.Checked == true)
            {
                osszeg += 200;
            }

            osszegLabel.ForeColor = Color.White;
            osszegLabel.Text = osszeg.ToString() + "Ft";
        }

        private void SzamolBtn_Click(object sender, EventArgs e)
        {
            int osszeg = 0;

            if (appleCbox.Checked == true)
            {
                try
                {
                    int alma = Int32.Parse(appleCB.SelectedItem.ToString());
                    osszeg += 500 * alma;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Nincs választott mennyiség!", "Figyelmeztetés" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (pearCbox.Checked == true)
            {
                try
                {
                    int korte = Int32.Parse(pearCB.SelectedItem.ToString());
                    osszeg += 800 * korte;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Nincs választott mennyiség!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (plumCbox.Checked == true)
            {
                try
                {
                    int szilva = Int32.Parse(plumCB.SelectedItem.ToString());
                    osszeg += 750 * szilva;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Nincs választott mennyiség!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (peachCbox.Checked == true)
            {
                try
                {
                    int oszibarack = Int32.Parse(peachCB.SelectedItem.ToString());
                    osszeg += 1200 * oszibarack;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Nincs választott mennyiség!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            vasarlasLabel.Text = $"A vásárlás összértéke: {osszeg}Ft";
        }
    }
}
