using System;
using System.Drawing;
using System.Windows.Forms;
using СrmTestLib;

namespace CrmTest
{
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
            foreach (Button b in splitContainer2.Panel2.Controls)
            {
                b.Click += delegate
                {
                    if (int.TryParse(b.Text, out int index))
                        Lib.goQuestion(MainPage.qForms, ref MainPage.qIndex, index - 1);
                    else
                        this.Close();
                };
            }
        }

        private void Question1_Resize(object sender, System.EventArgs e)
        {
            int buttonWidth = (splitContainer2.Width - exit.Width) / 16;
            foreach (Button b in splitContainer2.Panel2.Controls)
            {
                b.Width = buttonWidth;
            }

            int charPos = questionBody.Find("(1)");
            int x = questionBody.Location.X + questionBody.GetPositionFromCharIndex(charPos).X;
            int y = questionBody.Location.Y + questionBody.GetPositionFromCharIndex(charPos).Y;
            answerBox1.Location = new Point(x, y);

            charPos = questionBody.Find("(2)");
            x = questionBody.Location.X + questionBody.GetPositionFromCharIndex(charPos).X;
            y = questionBody.Location.Y + questionBody.GetPositionFromCharIndex(charPos).Y;
            answerBox2.Location = new Point(x, y);

            charPos = questionBody.Find("(3)");
            x = questionBody.Location.X + questionBody.GetPositionFromCharIndex(charPos).X;
            y = questionBody.Location.Y + questionBody.GetPositionFromCharIndex(charPos).Y;
            answerBox3.Location = new Point(x, y);

            charPos = questionBody.Find("(4)");
            x = questionBody.Location.X + questionBody.GetPositionFromCharIndex(charPos).X;
            y = questionBody.Location.Y + questionBody.GetPositionFromCharIndex(charPos).Y;
            answerBox4.Location = new Point(x, y);
        }

        private void goNext_Click(object sender, EventArgs e)
        {
            Lib.nextQuestion(MainPage.qForms, ref MainPage.qIndex);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Lib.CheckQ1(answerBox1, answerBox2, answerBox3, answerBox4,
                MainPage.resultArray, MainPage.qIndex);
            Lib.configureButton(bQuest1, check, MainPage.resultArray, MainPage.qIndex, MainPage.qIndex);
        }

        private void Question1_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
                foreach (Button b in splitContainer2.Panel2.Controls)
                {
                    if (int.TryParse(b.Text, out int index))
                       Lib.configureButton(b, check, MainPage.resultArray, index - 1, MainPage.qIndex);
                }
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }
    }

}