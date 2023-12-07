namespace BilgiYarismasi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo, dogru, yanlis;
        private void bntSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;  
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;

            soruNo++;
            lblSoru.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyetimiz kaç yýlýnda ilan edilmiþtir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi þehir ege bölgemizde bulunur?";
                btnA.Text = "Kütahya";
                btnB.Text = "Bursa";
                btnC.Text = "Antalya";
                btnD.Text = "Ýstanbul";
                label4.Text = "Kütahya";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuþlar hangi yazarýmýza aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla Ýlhan";
                btnD.Text = "Reþat Nuri";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar";
            }

            if(soruNo == 4) 
            {

                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;

                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ: " + yanlis);

            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}