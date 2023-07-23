using CrmTestLib; using CrmTest;
using System.Windows.Forms;
using СrmTestLib;

namespace СrmTest
{
    public partial class Question8 : Form
    {
        public Question8()
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

        private void Question8_Resize(object sender, System.EventArgs e)
        {
            int buttonWidth = (splitContainer2.Width - exit.Width)/16;
            foreach (Button b in splitContainer2.Panel2.Controls)
            {
                b.Width = buttonWidth;
            }
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
            Lib.CheckQ8(answerBox, MainPage.resultArray, MainPage.qIndex);
            Lib.configureButton(bQuest8, check, MainPage.resultArray, MainPage.qIndex, MainPage.qIndex);
        }

        private void Question8_VisibleChanged(object sender, System.EventArgs e)
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
