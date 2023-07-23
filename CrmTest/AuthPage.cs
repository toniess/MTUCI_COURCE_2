
using CrmTest;
using System.Windows.Forms;
using CrmTestLib;
using СrmTestLib;

namespace СrmTest
{
    public partial class AuthPage : Form
    {
        public AuthPage(Form parent)
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

        private void authButton_Click(object sender, System.EventArgs e)
        {
            if (Lib.Auth(authLoginInput, authPassInput, ref MainPage.userIndex, ref MainPage.userResult))
                this.Close();
        }

        private void regButton_Click(object sender, System.EventArgs e)
        {
            if (Lib.Reg(regLoginInput, regPassInput, ref MainPage.userIndex, ref MainPage.userResult))
                this.Close();
        }

        private void goBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
