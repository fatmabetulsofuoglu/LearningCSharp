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
            buttonNextQuestion.Enabled = true;

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
            buttonNextQuestion.Enabled = true;

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
            buttonNextQuestion.Enabled = true;

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
            buttonNextQuestion.Enabled = true;

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
            buttonNextQuestion.Enabled = false;
            label6.Visible = false;
            label5.Visible = false;
            pictureBoxCorrect.Visible = false;
            pictureBoxWrong.Visible = false;

            questionNo++;
            labelQuestionNo.Text = questionNo.ToString();

            if (questionNo == 1)
            {
                buttonNextQuestion.Text = "Sonraki";
                richTextBox1.Text = "Cumhuriyet ka?? y??l??nda ilan edilmi??tir?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label5.Text = "1923";
            }

            if (questionNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege b??lgemizde bulunmaz?";
                buttonA.Text = "??zmir";
                buttonB.Text = "Bal??kesir";
                buttonC.Text = "Ayd??n";
                buttonD.Text = "Manisa";
                label5.Text = "Bal??kesir";
            }

            if (questionNo == 3)
            {
                richTextBox1.Text = "Son Ku??lar hangi yazar??m??za aittir?";
                buttonA.Text = "Sait Faik Abas??yan??k";
                buttonB.Text = "Cemal S??reya";
                buttonC.Text = "Attila ??lhan";
                buttonD.Text = "Re??at Nuri G??ntekin";
                label5.Text = "Sait Faik Abas??yan??k";
            }

            if (questionNo == 4)
            {
                richTextBox1.Text = "T??rkiye'nin ba??kenti nedir?";
                buttonA.Text = "??stanbul";
                buttonB.Text = "Bursa";
                buttonC.Text = "Ankara";
                buttonD.Text = "Edirne";
                label5.Text = "Ankara";
            }

            if (questionNo == 5)
            {
                labelQuestionNo.Visible = false;
                buttonNextQuestion.Text = "Sonu??lar";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonNextQuestion.Enabled = false;
                label6.Visible = false;
                label5.Visible = false;
                pictureBoxCorrect.Visible = false;
                pictureBoxWrong.Visible = false;
                MessageBox.Show("Do??ru: " + correctNo + "\nYanl????: " + wrongNo);
            }
        }
    }
}