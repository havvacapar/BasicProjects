namespace OgrenciNotHesabı_IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum ;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);           
            ort = (s1 + s2 + proje) / 3;


            if (ort >= 50)
            {
                durum = "Geçtiniz!";

            }
            else
            {
                durum = "Kaldınız!";
            }
            textBox5.Text = ort.ToString("0.00"); 
            label6.Text = durum;    


        }
    }
}