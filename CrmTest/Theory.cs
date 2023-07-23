using System;
using System.IO;
using System.Windows.Forms;

namespace CrmTest
{
    public partial class Theory : Form
    {
        public Theory(MainPage parent)
        {
            InitializeComponent();
            //Код для настройки окна во время инициализации (размер, положение итд.)
            this.FormClosed += delegate
            {
                parent.Show();
            };
            this.StartPosition = FormStartPosition.Manual;
            Location = parent.Location;
            this.Size = parent.Size;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            parent.Hide();

            //Код для открытия файла с теорией в окне WebBrowser;
            string curDir = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/../../Resources/Theory.html", curDir));
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
