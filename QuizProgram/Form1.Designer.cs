namespace QuizProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxWrong = new System.Windows.Forms.PictureBox();
            this.pictureBoxCorrect = new System.Windows.Forms.PictureBox();
            this.labelQuestionNo = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 157);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(12, 240);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(202, 40);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(224, 240);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(202, 40);
            this.buttonC.TabIndex = 4;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(12, 286);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(202, 40);
            this.buttonB.TabIndex = 5;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(224, 286);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(202, 40);
            this.buttonD.TabIndex = 6;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soru No: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(443, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Doğru: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(443, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yanlış: ";
            // 
            // pictureBoxWrong
            // 
            this.pictureBoxWrong.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWrong.Image")));
            this.pictureBoxWrong.Location = new System.Drawing.Point(443, 240);
            this.pictureBoxWrong.Name = "pictureBoxWrong";
            this.pictureBoxWrong.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWrong.TabIndex = 11;
            this.pictureBoxWrong.TabStop = false;
            this.pictureBoxWrong.Visible = false;
            // 
            // pictureBoxCorrect
            // 
            this.pictureBoxCorrect.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCorrect.Image")));
            this.pictureBoxCorrect.Location = new System.Drawing.Point(534, 240);
            this.pictureBoxCorrect.Name = "pictureBoxCorrect";
            this.pictureBoxCorrect.Size = new System.Drawing.Size(85, 85);
            this.pictureBoxCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCorrect.TabIndex = 12;
            this.pictureBoxCorrect.TabStop = false;
            this.pictureBoxCorrect.Visible = false;
            // 
            // labelQuestionNo
            // 
            this.labelQuestionNo.AutoSize = true;
            this.labelQuestionNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestionNo.Location = new System.Drawing.Point(524, 15);
            this.labelQuestionNo.Name = "labelQuestionNo";
            this.labelQuestionNo.Size = new System.Drawing.Size(19, 21);
            this.labelQuestionNo.TabIndex = 13;
            this.labelQuestionNo.Text = "0";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCorrect.Location = new System.Drawing.Point(524, 49);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(19, 21);
            this.labelCorrect.TabIndex = 14;
            this.labelCorrect.Text = "0";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWrong.Location = new System.Drawing.Point(524, 84);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(19, 21);
            this.labelWrong.TabIndex = 15;
            this.labelWrong.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(300, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cevabım";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(224, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cevap";
            this.label5.Visible = false;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Location = new System.Drawing.Point(443, 129);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(176, 40);
            this.buttonNextQuestion.TabIndex = 18;
            this.buttonNextQuestion.Text = "Başla";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(110, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Doğru Cevap:";
            this.label6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 348);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelQuestionNo);
            this.Controls.Add(this.pictureBoxCorrect);
            this.Controls.Add(this.pictureBoxWrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Bilgi Yarışması ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonA;
        private Button buttonC;
        private Button buttonB;
        private Button buttonD;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBoxWrong;
        private PictureBox pictureBoxCorrect;
        private PictureBox pictureBox1;
        private Label labelQuestionNo;
        private Label labelCorrect;
        private Label labelWrong;
        private Label label4;
        private Label label5;
        private Button buttonNextQuestion;
        private Label label6;
    }
}