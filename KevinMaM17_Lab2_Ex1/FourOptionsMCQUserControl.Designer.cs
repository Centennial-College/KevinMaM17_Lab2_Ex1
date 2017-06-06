namespace KevinMaM17_Lab2_Ex1
{
    partial class FourOptionsMCQUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonAnswer4 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer3 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAnswer1 = new System.Windows.Forms.RadioButton();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.radioButtonAnswer4);
            this.questionGroupBox.Controls.Add(this.radioButtonAnswer3);
            this.questionGroupBox.Controls.Add(this.radioButtonAnswer2);
            this.questionGroupBox.Controls.Add(this.radioButtonAnswer1);
            this.questionGroupBox.Controls.Add(this.questionLbl);
            this.questionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionGroupBox.Location = new System.Drawing.Point(57, 45);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(505, 307);
            this.questionGroupBox.TabIndex = 0;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "Title goes here";
            // 
            // radioButtonAnswer4
            // 
            this.radioButtonAnswer4.AutoSize = true;
            this.radioButtonAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer4.Location = new System.Drawing.Point(168, 253);
            this.radioButtonAnswer4.Name = "radioButtonAnswer4";
            this.radioButtonAnswer4.Size = new System.Drawing.Size(138, 35);
            this.radioButtonAnswer4.TabIndex = 4;
            this.radioButtonAnswer4.TabStop = true;
            this.radioButtonAnswer4.Text = "Answer4";
            this.radioButtonAnswer4.UseVisualStyleBackColor = true;
            this.radioButtonAnswer4.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // radioButtonAnswer3
            // 
            this.radioButtonAnswer3.AutoSize = true;
            this.radioButtonAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer3.Location = new System.Drawing.Point(168, 212);
            this.radioButtonAnswer3.Name = "radioButtonAnswer3";
            this.radioButtonAnswer3.Size = new System.Drawing.Size(138, 35);
            this.radioButtonAnswer3.TabIndex = 3;
            this.radioButtonAnswer3.TabStop = true;
            this.radioButtonAnswer3.Text = "Answer3";
            this.radioButtonAnswer3.UseVisualStyleBackColor = true;
            this.radioButtonAnswer3.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // radioButtonAnswer2
            // 
            this.radioButtonAnswer2.AutoSize = true;
            this.radioButtonAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer2.Location = new System.Drawing.Point(168, 171);
            this.radioButtonAnswer2.Name = "radioButtonAnswer2";
            this.radioButtonAnswer2.Size = new System.Drawing.Size(138, 35);
            this.radioButtonAnswer2.TabIndex = 2;
            this.radioButtonAnswer2.TabStop = true;
            this.radioButtonAnswer2.Text = "Answer2";
            this.radioButtonAnswer2.UseVisualStyleBackColor = true;
            this.radioButtonAnswer2.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // radioButtonAnswer1
            // 
            this.radioButtonAnswer1.AutoSize = true;
            this.radioButtonAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnswer1.Location = new System.Drawing.Point(168, 130);
            this.radioButtonAnswer1.Name = "radioButtonAnswer1";
            this.radioButtonAnswer1.Size = new System.Drawing.Size(138, 35);
            this.radioButtonAnswer1.TabIndex = 1;
            this.radioButtonAnswer1.TabStop = true;
            this.radioButtonAnswer1.Text = "Answer1";
            this.radioButtonAnswer1.UseVisualStyleBackColor = true;
            this.radioButtonAnswer1.CheckedChanged += new System.EventHandler(this.radioButtonAnswer_CheckedChanged);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(32, 55);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(287, 32);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Question goes here...";
            // 
            // FourOptionsMCQUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionGroupBox);
            this.Name = "FourOptionsMCQUserControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.questionGroupBox.ResumeLayout(false);
            this.questionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.RadioButton radioButtonAnswer4;
        private System.Windows.Forms.RadioButton radioButtonAnswer3;
        private System.Windows.Forms.RadioButton radioButtonAnswer2;
        private System.Windows.Forms.RadioButton radioButtonAnswer1;
    }
}
