using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinMaM17_Lab2_Ex1
{
    public partial class FourOptionsMCQUserControl : UserControl
    {
        public FourOptionsMCQUserControl()
        {
            InitializeComponent();
        }

        //stores the selected answer for the question
        private string selectedAnswer;

        //property for setting and getting the question
        public string QuestionLbl
        {
            get { return this.questionLbl.Text; }
            set { this.questionLbl.Text = value; }
        }

        //properties for setting and getting the answers
        public string Answer1
        {
            get { return this.radioButtonAnswer1.Text; }
            set { this.radioButtonAnswer1.Text = value; }
        }
        public string Answer2
        {
            get { return this.radioButtonAnswer2.Text; }
            set { this.radioButtonAnswer2.Text = value; }
        }
        public string Answer3
        {
            get { return this.radioButtonAnswer3.Text; }
            set { this.radioButtonAnswer3.Text = value; }
        }
        public string Answer4
        {
            get { return this.radioButtonAnswer4.Text; }
            set { this.radioButtonAnswer4.Text = value; }
        }

        //property for setting and getting the title of the group box
        public string GroupBoxTitle
        {
            get { return this.questionGroupBox.Text; }
            set { this.questionGroupBox.Text = value; }
        }

        //Read-only Property
        public string SelectedAnswer
        {
            get { return this.selectedAnswer; }
        }

        //public method
        public void ClearSelection()
        {
            this.radioButtonAnswer1.Checked = false;
            this.radioButtonAnswer2.Checked = false;
            this.radioButtonAnswer3.Checked = false;
            this.radioButtonAnswer4.Checked = false;
        }

        private void radioButtonAnswer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton checkChangedRadioBtn = (RadioButton)sender;

            //if new answer is checked, update the selected answer
            selectedAnswer = checkChangedRadioBtn.Checked ? checkChangedRadioBtn.Text : selectedAnswer;
        }
    }
}
