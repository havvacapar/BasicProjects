namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo, dogru, yanlis;
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soruNo++;
            lblSoru.Text = soruNo.ToString();   

        }
    }
}