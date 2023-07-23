using System;
using System.Windows.Forms;
using СrmTestLib;

namespace CrmTest
{
    public partial class QuestionMainPage : Form
    {
        public QuestionMainPage(MainPage parent)
        {
            InitializeComponent();
            this.FormClosed += delegate
            {
                if (!MainPage.qForms[MainPage.qIndex].Visible)
                    parent.Show();
            };
            this.StartPosition = FormStartPosition.Manual;
            Location = parent.Location;
            this.Size = parent.Size;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            parent.Hide();
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goTest_Click(object sender, EventArgs e)
        {
            if(Lib.startTest(MainPage.qForms, MainPage.userIndex, ref MainPage.qIndex))
                this.Close();
        }
    }
}
