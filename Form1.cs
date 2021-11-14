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

        uint soruNo = 0, dogru = 0, yanlis = 0, sayac;
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

            sayac = 30;
            label8.Text = sayac.ToString();
            progressBar1.Value = 30;
            timer1.Start();


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
            if (soruNo == 4)
            {
                richtxtBox.Text = "Irkçı Ceyhun Türkmen sıradan bir günde en çok kullandığı kelime aşağıdakilerden hangisidir ?";
                btnA.Text = "Araplara vurmam";
                btnB.Text = "Odadaki çoçuğu dövdüm";
                btnC.Text = "Camiye gitmem abi";
                btnD.Text = "7.5 cm uzunmu beyler";
                key = btnC.Text;
            }
            if (soruNo == 5)
            {
                richtxtBox.Text = "Sıradan bir yüksel alkış günde kaç kez berbere vurdurur ?";

                btnA.Text = "31";
                btnB.Text = "69";
                btnC.Text = "Ben vurdurmam abi";
                btnD.Text = "3";
                key = btnC.Text;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            timer1.Stop();

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
            if (soruNo == 5) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            timer1.Stop();

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
            if (soruNo == 5) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 1;
            sayac--;
            label8.Text = sayac.ToString();
            if (progressBar1.Value == 0)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                timer1.Stop(); MessageBox.Show("Süreniz Bitii !");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            timer1.Stop();

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
            if (soruNo == 5) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            timer1.Stop();

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
            if (soruNo == 5) { btnNext.Text = "Bitti !"; btnNext.Enabled = false; MessageBox.Show(soruNo + " Soruda " + dogru + " Doğru " + yanlis + " Yanlış"); }
        }
    }
}
