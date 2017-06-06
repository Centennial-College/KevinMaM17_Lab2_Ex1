namespace MultipleChoiceQuiz
{
    partial class MultipleChoiceQuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.fourOptionsMCQUserControl = new KevinMaM17_Lab2_Ex1.FourOptionsMCQUserControl();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Enabled = false;
            this.backBtn.Location = new System.Drawing.Point(117, 379);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(153, 54);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(290, 379);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(153, 54);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // fourOptionsMCQUserControl
            // 
            this.fourOptionsMCQUserControl.Answer1 = "Answer1";
            this.fourOptionsMCQUserControl.Answer2 = "Answer2";
            this.fourOptionsMCQUserControl.Answer3 = "Answer3";
            this.fourOptionsMCQUserControl.Answer4 = "Answer4";
            this.fourOptionsMCQUserControl.GroupBoxTitle = "Title goes here";
            this.fourOptionsMCQUserControl.Location = new System.Drawing.Point(0, 2);
            this.fourOptionsMCQUserControl.Name = "fourOptionsMCQUserControl";
            this.fourOptionsMCQUserControl.QuestionLbl = "Question goes here...";
            this.fourOptionsMCQUserControl.Size = new System.Drawing.Size(640, 480);
            this.fourOptionsMCQUserControl.TabIndex = 0;
            // 
            // MultipleChoiceQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 454);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.fourOptionsMCQUserControl);
            this.Name = "MultipleChoiceQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Choice Quiz";
            this.Load += new System.EventHandler(this.MultipleChoiceQuizForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private KevinMaM17_Lab2_Ex1.FourOptionsMCQUserControl fourOptionsMCQUserControl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
    }
}

