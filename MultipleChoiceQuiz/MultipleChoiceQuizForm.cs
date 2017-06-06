using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceQuiz
{
    public partial class MultipleChoiceQuizForm : Form
    {
        //counter for question currently on
        private int questionNum;
        private int numCorrectAns;

        public MultipleChoiceQuizForm()
        {
            InitializeComponent();
        }

        private void MultipleChoiceQuizForm_Load(object sender, EventArgs e)
        {
            this.questionNum = 1;
            this.numCorrectAns = 0;
            this.fourOptionsMCQUserControl.GroupBoxTitle = "Question #1";
            this.fourOptionsMCQUserControl.QuestionLbl = "Which of the following controls is\ninvisible at run time?";
            this.fourOptionsMCQUserControl.Answer1 = "Button";
            this.fourOptionsMCQUserControl.Answer2 = "Timer";
            this.fourOptionsMCQUserControl.Answer3 = "Label";
            this.fourOptionsMCQUserControl.Answer4 = "PictureBox";
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (this.questionNum == 1)
            {
                //this.questionNum = 2;
                this.nextBtn.Text = "Submit Quiz";

                MessageBox.Show($"The selected answer was {this.fourOptionsMCQUserControl.SelectedAnswer}.");
            }
        }
    }
}
