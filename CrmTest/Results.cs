using CrmTest;
using System;
using System.Windows.Forms;
using СrmTestLib;

namespace СrmTest
{
    public partial class Results : Form
    {
        public Results(MainPage parent)
        {
            InitializeComponent();
            this.FormClosed += delegate
            {
                parent.reBuildQuestions();
                parent.Show();
            };
            this.StartPosition = FormStartPosition.Manual;
            Location = parent.Location;
            this.Size = parent.Size;
            this.WindowState = FormWindowState.Normal;
            this.Show();
            parent.Hide();


            Lib.fillWithResults(grid, chart, rightAns, wrongAns,
                                percent, MainPage.resultArray,
                                MainPage.userResult);
            
            int[] array = Lib.getIntArray(MainPage.resultArray);
            Lib.bubbleSort(ref array, array.Length);
            Lib.Output_Mas(array, grid2);
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exportPDF_Click(object sender, EventArgs e)
        {
            int[] c = { 1, 2, 3, 4, 5 };
            Lib.exportPdf(MainPage.resultArray);
        }

        private void exportDB_Click(object sender, EventArgs e)
        {
            if (Lib.exportDB(MainPage.userIndex, MainPage.resultArray))
                MainPage.userResult = Lib.getResult(MainPage.resultArray);
        }

        private void exportExcel_Click(object sender, EventArgs e)
        {
            Lib.exportExcel1(MainPage.resultArray);
        }

        private void exportExcel2_Click(object sender, EventArgs e)
        {
            int result = Lib.exportExcel2(MainPage.resultArray);
            MessageBox.Show("Правильных ответов: "
                + Convert.ToString(result) + ". (Вычисленно встроенным методом Sum())",
                "Результат", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }
    }
}
