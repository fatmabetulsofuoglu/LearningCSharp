namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHour.Location = new System.Drawing.Point(122, 102);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(32, 37);
            this.labelHour.TabIndex = 0;
            this.labelHour.Text = "0";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinute.Location = new System.Drawing.Point(266, 102);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(32, 37);
            this.labelMinute.TabIndex = 1;
            this.labelMinute.Text = "0";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecond.Location = new System.Drawing.Point(405, 102);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(32, 37);
            this.labelSecond.TabIndex = 2;
            this.labelSecond.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 254);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelHour;
        private Label labelMinute;
        private Label labelSecond;
    }
}