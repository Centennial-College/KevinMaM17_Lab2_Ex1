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

    }
}
