using CrmTestLib; using CrmTest;
using System.Windows.Forms;
using СrmTestLib;

namespace СrmTest
{
    public partial class Question15 : Form
    {
        public Question15()
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

        private void Question15_Resize(object sender, System.EventArgs e)
        {
            int buttonWidth = (splitContainer2.Width - exit.Width)/16;
            foreach (Button b in splitContainer2.Panel2.Controls)
            {
                b.Width = buttonWidth;
            }

            int scrollWidth = answer.Width / 4;
            label1.Location = new System.Drawing.Point(scrollWidth * 0 + (scrollWidth - label1.Width) / 2, answer.Location.Y + 20);
            label2.Location = new System.Drawing.Point(scrollWidth * 1 + (scrollWidth - label2.Width) / 2, answer.Location.Y + 20);
            label3.Location = new System.Drawing.Point(scrollWidth * 2 + (scrollWidth - label3.Width) / 2, answer.Location.Y + 20);
            label4.Location = new System.Drawing.Point(scrollWidth * 3 + (scrollWidth - label4.Width) / 2, answer.Location.Y + 20);
        }

        private void goNext_Click(object sender, System.EventArgs e)
        {
            Lib.nextQuestion(MainPage.qForms, ref MainPage.qIndex);
        }

        private void goBack_Click(object sender, System.EventArgs e)
        {
            Lib.prevQuestion(MainPage.qForms, ref MainPage.qIndex);
        }

        private void check_Click(object sender, System.EventArgs e)
        {
            Lib.CheckQ15(answer, MainPage.resultArray, MainPage.qIndex);
            Lib.configureButton(bQuest15, check, MainPage.resultArray, MainPage.qIndex, MainPage.qIndex);
        }

        private void Question15_VisibleChanged(object sender, System.EventArgs e)
        {
            if (this.Visible)
                foreach (Button b in splitContainer2.Panel2.Controls)
                {
                    if (int.TryParse(b.Text, out int index))
                        Lib.configureButton(b, check, MainPage.resultArray, index - 1, MainPage.qIndex);
                }
        }
    }
}
