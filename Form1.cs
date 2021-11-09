using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        uint soruNo = 0, dogru = 0, yanlis = 0;
        string key;

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            btnNext.Text = "İlerle";
            btnNext.Enabled = false;
            soruNo++;
            lblNo.Text = soruNo.ToString();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnD.BackColor = Color.White;


            if (soruNo == 1)
            {
                richtxtBox.Text = "Türkiye'nin başkenti neresidir ?";

                btnA.Text = "İstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "İzmir";
                btnD.Text = "Yalova";
                key = btnB.Text;
            }
            if (soruNo == 2)
            {
                richtxtBox.Text = "Matrix serisi kaç tane filmden oluşur ?";

                btnA.Text = "3";
                btnB.Text = "4";
                btnC.Text = "5";
                btnD.Text = "6";
                key = btnA.Text;
            }
            if (soruNo == 3)
            {
                richtxtBox.Text = "Haftaya dün çarşambaysa bu hafta yarın hangi gündür ?";

                btnA.Text = "perşembe";
                btnB.Text = "pazar";
                btnC.Text = "salı";
                btnD.Text = "cuma";
                key = btnD.Text;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            if (btnA.Text == key)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnA.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btnA.BackColor = Color.Red;

                if (btnB.Text == key)
                {
                    btnB.BackColor = Color.Green;
                }
                else if (btnC.Text == key)
                {
                    btnC.BackColor = Color.Green;
                }
                else if (btnD.Text == key)
                {
                    btnD.BackColor = Color.Green;
                }
            }
            if(soruNo == 3) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            if (btnB.Text == key)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnB.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btnB.BackColor = Color.Red;

                if (btnA.Text == key)
                {
                    btnA.BackColor = Color.Green;
                }
                else if (btnC.Text == key)
                {
                    btnC.BackColor = Color.Green;
                }
                else if (btnD.Text == key)
                {
                    btnD.BackColor = Color.Green;
                }

            }
            if (soruNo == 3) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            if (btnC.Text == key)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnC.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btnC.BackColor = Color.Red;

                if (btnA.Text == key)
                {
                    btnA.BackColor = Color.Green;
                }
                else if (btnB.Text == key)
                {
                    btnB.BackColor = Color.Green;
                }
                else if (btnD.Text == key)
                {
                    btnD.BackColor = Color.Green;
                }
            }
            if (soruNo == 3) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;

            if (btnD.Text == key)
            {
                dogru++;
                lblTrue.Text = dogru.ToString();
                pictureBox1.Visible = true;
                btnD.BackColor = Color.Green;
            }
            else
            {
                yanlis++;
                lblFalse.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                btnD.BackColor = Color.Red;

                if (btnA.Text == key)
                {
                    btnA.BackColor = Color.Green;
                }
                else if (btnB.Text == key)
                {
                    btnB.BackColor = Color.Green;
                }
                else if (btnC.Text == key)
                {
                    btnC.BackColor = Color.Green;
                }
            }
            if (soruNo == 3) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }


    }
}
