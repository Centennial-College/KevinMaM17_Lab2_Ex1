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
        private double gradeReceived;

        public MultipleChoiceQuizForm()
        {
            InitializeComponent();
        }

        private void MultipleChoiceQuizForm_Load(object sender, EventArgs e)
        {
            this.goToIntro();
        }

        private void goToIntro()
        {
            this.startQuizBtn.Show();
            this.fourOptionsMCQUserControl.Hide();
            this.backBtn.Hide();
            this.nextBtn.Hide();
        }

        private void startQuiz()
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
            //update UI to reflect 2nd question and evaluate selected answer
            if (this.questionNum == 1)
            {
                this.nextBtn.Text = "Submit Quiz";

                if (this.fourOptionsMCQUserControl.SelectedAnswer.Equals("Timer"))
                {
                    this.numCorrectAns++;
                    MessageBox.Show("You are correct!\nTimer is invisible at run time.");
                }
                else
                {
                    MessageBox.Show($"Sorry, you are incorrect.\n{this.fourOptionsMCQUserControl.SelectedAnswer} is visible during run time.");
                }

                this.questionNum = 2;
                this.backBtn.Enabled = true;
                this.fourOptionsMCQUserControl.GroupBoxTitle = "Question #2";
                this.fourOptionsMCQUserControl.QuestionLbl = "Which of the following is not an\napproach of Entity Framework?";
                this.fourOptionsMCQUserControl.Answer1 = "Code First";
                this.fourOptionsMCQUserControl.Answer2 = "Model First";
                this.fourOptionsMCQUserControl.Answer3 = "Data First";
                this.fourOptionsMCQUserControl.Answer4 = "Database First";

                //prevents quiz submission from clicking next just once
                return;
            }

            //submitting quiz
            if (this.questionNum == 2)
            {
                this.gradeReceived = (double)this.numCorrectAns / 2 * 100;

                MessageBox.Show($"You have submitted the quiz.\nThe following are your results:\n\nYou have correctly answered {this.numCorrectAns} questions.\nYou have incorrectly answered {2 - this.numCorrectAns} questions.\n\nYou have achieved a mark of {this.gradeReceived}%.");

                MessageBox.Show(this.gradeReceived > 50 ? "You passed!" : "You failed...");

                this.goToIntro();
            }
        }

        private void startQuizBtn_Click(object sender, EventArgs e)
        {
            this.startQuizBtn.Hide();
            this.fourOptionsMCQUserControl.Show();
            this.backBtn.Show();
            this.nextBtn.Show();
            this.startQuiz();
        }
    }
}
