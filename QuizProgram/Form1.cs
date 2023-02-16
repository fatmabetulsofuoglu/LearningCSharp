namespace QuizProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNo = 0, correctNo = 0, wrongNo = 0;

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label4.Text = buttonA.Text;

            if (label5.Text == label4.Text)
            {
                correctNo++;
                labelCorrect.Text = correctNo.ToString();
                pictureBoxCorrect.Visible = true;
            }
            else
            {
                wrongNo++;
                labelWrong.Text = wrongNo.ToString();
                pictureBoxWrong.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label4.Text = buttonB.Text;

            if (label5.Text == label4.Text)
            {
                correctNo++;
                labelCorrect.Text = correctNo.ToString();
                pictureBoxCorrect.Visible = true;
            }
            else
            {
                wrongNo++;
                labelWrong.Text = wrongNo.ToString();
                pictureBoxWrong.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label4.Text = buttonC.Text;

            if (label5.Text == label4.Text)
            {
                correctNo++;
                labelCorrect.Text = correctNo.ToString();
                pictureBoxCorrect.Visible = true;
            }
            else
            {
                wrongNo++;
                labelWrong.Text = wrongNo.ToString();
                pictureBoxWrong.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;

            label4.Text = buttonD.Text;

            if (label5.Text == label4.Text)
            {
                correctNo++;
                labelCorrect.Text = correctNo.ToString();
                pictureBoxCorrect.Visible = true;
            }
            else
            {
                wrongNo++;
                labelWrong.Text = wrongNo.ToString();
                pictureBoxWrong.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
            }
        }

        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;

            questionNo++;
            labelQuestionNo.Text = questionNo.ToString();

            if (questionNo == 1)
            {
                buttonNextQuestion.Text = "Sonraki";
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label5.Text = "1923";
            }

            if (questionNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz?";
                buttonA.Text = "İzmir";
                buttonB.Text = "Balıkesir";
                buttonC.Text = "Aydın";
                buttonD.Text = "Manisa";
                label5.Text = "Balıkesir";
            }

            if (questionNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir?";
                buttonA.Text = "Sait Faik Abasıyanık";
                buttonB.Text = "Cemal Süreya";
                buttonC.Text = "Attila İlhan";
                buttonD.Text = "Reşat Nuri Güntekin";
                label5.Text = "Sait Faik Abasıyanık";
            }
        }

    }
}