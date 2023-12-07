namespace AlisveriIndirimTutari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kitapAdet;
            double tutar;
            kitapAdet=Convert.ToInt32(textBox1.Text);

            if (kitapAdet == 0 && kitapAdet <= 20)
            {
                label2.Text = "%20 indirim kazandýnýz!";
                tutar = (kitapAdet * 8) * 0.8;
                label2.Text = tutar.ToString() + "TL";
            }
            if (kitapAdet == 21 && kitapAdet <= 40)
            {
                label2.Text = "%40 indirim kazandýnýz!";
                tutar = (kitapAdet * 8) * 0.6;
                label2.Text = tutar.ToString() + "TL";
            }
            if (kitapAdet <= 41)
            {
                label2.Text = "%50 indirim kazandýnýz!";
                tutar = (kitapAdet * 8) * 0.5;
                label2.Text = tutar.ToString() + "TL";
            }

        }
    }
}

//0-20 ==> %20 indirim
//21-40 ==> %40 indirim
//+41 ==> %50 indirim
//Kitap fiyatý=8 TL
