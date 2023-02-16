namespace LoopConsecutiveNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam = 0;

        private void buttonSum_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            for (int i = 0; i <= 10; i++)
            {
                toplam += i;
            }
            label1.Text = toplam.ToString();
        }
    }
}