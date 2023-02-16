namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hour = 0, minute = 0, second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            labelSecond.Text = second.ToString();
            if (second == 60)
            {
                minute++;
                labelMinute.Text = minute.ToString();
                second = 0;

                if (minute == 60)
                {
                    hour++;
                    labelHour.Text = hour.ToString();
                    minute = 0;
                    labelMinute.Text = minute.ToString();
                }
            }
        }
    }
}