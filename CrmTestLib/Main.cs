using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;
using Axis = Microsoft.Office.Interop.Excel.Axis;

namespace СrmTestLib
{
    public static class Lib
    {
        // Метод определяет, авторизован ли пользователь
        public static bool isUserAuthed(int userIndex)
        {
            return userIndex != -1;
        }

        // Метод для начала теста
        // Если пользователь авторизован, то запускает тест
        // иначе выводит сообщение об ошибке.
        // Возвращает true, если тест был начат
        public static bool startTest(Form[] qForms, int userIndex, ref int qIndex)
        {
            if (isUserAuthed(userIndex))
                goQuestion(qForms, ref qIndex, qIndex);
            else
                MessageBox.Show("Для доступа к тесту необходимо авторизоваться.",
                    "Необходима авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return isUserAuthed(userIndex);
        }

        // Метод для перехода на определенный вопрос по его номеру
        public static void goQuestion(Form[] qForms, ref int qIndex, int index)
        {
            qForms[qIndex].Hide();
            qIndex = index;
            qForms[qIndex].Show();
        }

        // Метод для перехода к следующему вопросу
        public static void nextQuestion(Form[] qForms, ref int qIndex)
        {
            goQuestion(qForms, ref qIndex, qIndex + 1);
        }

        // Метод для перехода к предыдущему вопросу
        public static void prevQuestion(Form[] qForms, ref int qIndex)
        {
            goQuestion(qForms, ref qIndex, qIndex - 1);
        }

        // Метод вызывается при правильном ответе на вопрос
        private static void Right(string[,] resultArray, int qIndex)
        {
            MessageBox.Show("Вы ответили верно", "Проверка ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resultArray[qIndex, 1] = "Верно";
        }
        
        // Метод вызывается при неправильном ответе на вопрос
        private static void Wrong(string[,] resultArray, int qIndex)
        {
            MessageBox.Show("Вы ответили неверно", "Проверка ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resultArray[qIndex, 1] = "Неверно";
        }

        // Метод вызывается, если на вопрос не был дан ответ
        private static void Empty()
        {
            MessageBox.Show("Вы не дали ответ", "Проверка ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод для проверки 1 вопроса
        public static void CheckQ1(TextBox b1, TextBox b2,
                                   TextBox b3, TextBox b4,
                                   string[,] resultArray, int qIndex)
        {
            if (b1.Text == "" || b2.Text == "" ||
                b3.Text == "" || b4.Text == "")
                Empty();
            else if (b1.Text.ToLower() == "организаций" &&
                     b2.Text.ToLower() == "уровня" &&
                     b3.Text.ToLower() == "маркетинга" &&
                     b4.Text.ToLower() == "истории")
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 2 вопроса
        public static void CheckQ2(TextBox b1, TextBox b2,
                                   TextBox b3, TextBox b4,
                                   string[,] resultArray, int qIndex)
        {
            if (b1.Text == "" || b2.Text == "" ||
                b3.Text == "" || b4.Text == "")
                Empty();
            else if (b1.Text.ToLower() == "15" &&
                     b2.Text.ToLower() == "компаний" &&
                     b3.Text.ToLower() == "3" &&
                     b4.Text.ToLower() == "руководителю")
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 3 вопроса
        public static void CheckQ3(CheckBox b1, CheckBox b2,
                                   CheckBox b3, CheckBox b4,
                                   CheckBox b5, CheckBox b6,
                                   string[,] resultArray, int qIndex)
        {
            if (!b1.Checked && !b2.Checked && !b3.Checked &&
                !b4.Checked && !b5.Checked && !b6.Checked)
                Empty();
            else if (!b1.Checked && b2.Checked && !b3.Checked &&
                      b4.Checked && !b5.Checked && b6.Checked)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 4 вопроса
        public static void CheckQ4(CheckBox b1, CheckBox b2,
                                   CheckBox b3, CheckBox b4,
                                   CheckBox b5, CheckBox b6,
                                   string[,] resultArray, int qIndex)
        {
            if (!b1.Checked && !b2.Checked && !b3.Checked &&
                !b4.Checked && !b5.Checked && !b6.Checked)
                Empty();
            else if (!b1.Checked && !b2.Checked && b3.Checked &&
                      b4.Checked && !b5.Checked && b6.Checked)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 5 вопроса
        public static void CheckQ5(RadioButton b1, RadioButton b2,
                                   RadioButton b3, RadioButton b4,
                                   RadioButton b5, RadioButton b6,
                                   string[,] resultArray, int qIndex)
        {
            if (!b1.Checked && !b2.Checked && !b3.Checked &&
                !b4.Checked && !b5.Checked && !b6.Checked)
                Empty();
            else if (b4.Checked)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 6 вопроса
        public static void CheckQ6(RadioButton b1, RadioButton b2,
                                   RadioButton b3, RadioButton b4,
                                   string[,] resultArray, int qIndex)
        {
            if (!b1.Checked && !b2.Checked &&
                !b3.Checked && !b4.Checked)
                Empty();
            else if (b2.Checked)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 7 вопроса
        public static void CheckQ7(ListBox b,
                                   string[,] resultArray, int qIndex)
        {
            if (b.Text == "")
                Empty();
            else if (b.SelectedIndex == 1)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 8 вопроса
        public static void CheckQ8(ListBox b,
                                   string[,] resultArray, int qIndex)
        {
            if (b.Text == "")
                Empty();
            else if (b.SelectedIndex == 2)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 9 вопроса
        public static void CheckQ9(CheckedListBox b,
                                   string[,] resultArray, int qIndex)
        {
            if (b.CheckedIndices.Count == 0)
                Empty();
            else if (!b.GetItemChecked(0) && b.GetItemChecked(1) &&
                     !b.GetItemChecked(2) && b.GetItemChecked(3) &&
                     !b.GetItemChecked(4))
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 10 вопроса
        public static void CheckQ10(CheckedListBox b,
                                    string[,] resultArray, int qIndex)
        {
            if (b.CheckedIndices.Count == 0)
                Empty();
            else if (b.GetItemChecked(0) && !b.GetItemChecked(1) &&
                     b.GetItemChecked(2) && b.GetItemChecked(3))
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 11 вопроса
        public static void CheckQ11(ComboBox b1, ComboBox b2,
                                    ComboBox b3,
                                    string[,] resultArray, int qIndex)
        {
            if (b1.Text == "" || b2.Text == "" ||
                b3.Text == "")
                Empty();
            else if (b1.SelectedIndex == 1 &&
                     b2.SelectedIndex == 2 &&
                     b3.SelectedIndex == 0)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 12 вопроса
        public static void CheckQ12(ComboBox b1, ComboBox b2,
                                    ComboBox b3, ComboBox b4,
                                    string[,] resultArray, int qIndex)
        {
            if (b1.Text == "" || b2.Text == "" ||
                b3.Text == "" || b4.Text == "")
                Empty();
            else if (b1.SelectedIndex == 1 &&
                     b2.SelectedIndex == 0 &&
                     b3.SelectedIndex == 3 &&
                     b4.SelectedIndex == 2)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 13 вопроса
        public static void CheckQ13(TrackBar b,
                                    string[,] resultArray, int qIndex)
        {
            if (b.Value == 18)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 14 вопроса
        public static void CheckQ14(TrackBar b,
                                    string[,] resultArray, int qIndex)
        {
            if (b.Value == 15)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 15 вопроса
        public static void CheckQ15(HScrollBar b,
                                    string[,] resultArray, int qIndex)
        {
            if (b.Value == 3)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для проверки 16 вопроса
        public static void CheckQ16(HScrollBar b,
                                    string[,] resultArray, int qIndex)
        {
            if (b.Value == 1)
                Right(resultArray, qIndex);
            else
                Wrong(resultArray, qIndex);
        }

        // Метод для настройки цвета и активности кнопок при переходе к другому вопросу
        public static void configureButton(Button b, Button check,
                                           string[,] resultArray, int qIndex, int qIndex_)
        {
            string qResult = resultArray[qIndex, 1];
            if (qResult == "Верно" || qResult == "Неверно")
            {
                if (qIndex == qIndex_)
                    check.Enabled = false;
                if (qResult == "Верно")
                {
                    b.ForeColor = System.Drawing.Color.White;
                    b.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    b.ForeColor = System.Drawing.Color.White;
                    b.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        // Метод для получения количества верных ответов из массива ответов
        public static int getResult(string[,] arr)
        {
            int count = 0;
            for (int i = 0; i < 16; i++)
                if (arr[i, 1] == "Верно")
                    count++;
            return count;
        }

        // Метод для авторизации пользователя
        public static bool Auth(TextBox login_, TextBox pass_, ref int userID, ref int result)
        {
            string login = login_.Text;
            string pass = pass_.Text;

            var con = new SQLiteConnection("Data Source=./../../Resources/test.db; Version=3;", true);

            con.Open();

            string stm = "SELECT id, result FROM users where name = $name and password = $pass";

            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("$name", login);
            cmd.Parameters.AddWithValue("$pass", pass);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            bool isOk = rdr.HasRows;
            if (isOk)
            {
                rdr.Read();
                userID = rdr.GetInt32(0);
                result = rdr.GetInt32(1);
                MessageBox.Show("Вы успешно авторизовались! Вам доступен тест",
                    "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Повторите попытку или зарегистрируйтесь",
                    "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

            return isOk;
        }

        // Метод для регистрации пользователя
        public static bool Reg(TextBox login_, TextBox pass_, ref int userID, ref int result)
        {
            string login = login_.Text;
            string pass = pass_.Text;

            if (login == "" || pass == "")
            {
                MessageBox.Show("Пароль и логин не могут быть пустыми",
                 "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var con = new SQLiteConnection("Data Source=./../../Resources/test.db; Version=3;", true);

            con.Open();

            string stm = "INSERT INTO users (name, password, result) values ($name, $pass, -1)";

            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("$name", login);
            cmd.Parameters.AddWithValue("$pass", pass);
            try
            {
                cmd.ExecuteNonQuery();


                cmd.CommandText = @"select last_insert_rowid()";

                userID = Convert.ToInt32((Int64)cmd.ExecuteScalar());
                result = -1;
                MessageBox.Show("Вы успешно авторизовались! Вам доступны статистика и тест",
                    "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch
            {
                MessageBox.Show("Не удалось зарегистрироваться. Пользователь с таким именем существует",
                 "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Метод для генерации графиков и таблиц на странице результатов
        public static void fillWithResults(DataGridView grid, Chart chart,
                                        Label l1, Label l2, Label l3, string[,] results, int lastResult)
        {
            int countRight = getResult(results);
            for (int i = 0; i < 16; i++)
            {
                if (results[i, 1] == "Верно")
                    grid.Rows.Add(i + 1, "Верно");
                else
                    grid.Rows.Add(i + 1, "Неверно");
            }
            if (lastResult != -1)
            {
                chart.Series[0].Points.Add(lastResult);
                chart.Series[1].Points.Add(16 - lastResult);
            }
            else
            {
                chart.Series[0].Points.Add(0);
                chart.Series[1].Points.Add(0);
            }
            chart.Series[0].Points.Add(countRight);
            chart.Series[1].Points.Add(16 - countRight);

            l1.Text = l1.Text + countRight.ToString();
            int wrong = 16 - countRight;
            l2.Text += wrong.ToString();
            int p = countRight * 100 / 16;
            l3.Text += p.ToString() + "%";
        }

        // Метод для экспорта резльтатов в pdf файл
        public static void exportPdf(string[,] arr)
        {
            int countRight = getResult(arr);
            var document = new Document();
            var fd = new SaveFileDialog();
            fd.FileName = "crmTestResult.pdf";
            fd.AddExtension = true;
            fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            fd.InitialDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var res = fd.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Ответы не были записаны", "Запись результата", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            var zap = PdfWriter.GetInstance(document, new System.IO.FileStream(fd.FileName, System.IO.FileMode.Create));
            document.Open();
            var Shrift = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\times.ttf", "CP1251", BaseFont.EMBEDDED);
            var font = new Font(Shrift, 10, Font.NORMAL, BaseColor.BLACK);
            var fontRight = new Font(Shrift, 10, Font.NORMAL, BaseColor.GREEN);
            var fontWrong = new Font(Shrift, 10, Font.NORMAL, BaseColor.RED);
            var tabl = new PdfPTable(1);
            var cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Colspan = 2;
            cell.Border = 0;
            cell.FixedHeight = 16.0F;
            cell.Phrase = new Phrase("Количество правильных ответов: " + countRight, font);
            tabl.AddCell(cell);
            cell.Phrase = new Phrase("Количество неправильных ответов: " + (16 - countRight), font);
            tabl.AddCell(cell);
            cell.BackgroundColor = BaseColor.WHITE;
            cell.Colspan = 1;
            cell.Border = 15;
            for (int i = 0; i < 16; i++)
            {
                if (arr[i, 1].ToString() == "Верно")
                    cell.Phrase = new Phrase((i + 1).ToString() + ".  Верно", fontRight);
                else
                    cell.Phrase = new Phrase((i + 1).ToString() + ".  Неверно", fontWrong);
                tabl.AddCell(cell);
            }
            tabl.TotalWidth = document.PageSize.Width / 2;
            tabl.WriteSelectedRows(0, -1, 150, 750, zap.DirectContent);
            document.Close();
            zap.Close();
            MessageBox.Show("Ответы успешно записаны", "Запись результата", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            System.Diagnostics.Process.Start("msedge.exe", fd.FileName);
        }

        // Метод для сохранения результатов в базу данных
        public static bool exportDB(int id, string[,] arr)
        {
            int result = getResult(arr);
            var con = new SQLiteConnection("Data Source=./../../Resources/test.db; Version=3;", true);

            con.Open();

            string stm = "UPDATE users SET result = $res WHERE id = $id";

            var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWithValue("$res", result);
            cmd.Parameters.AddWithValue("$id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Результаты успешно занесены в базу данных",
                    "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Результаты не были занесены в базу данных",
                    "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Метод для записи результатов в excel
        // Записывается в файл Excel из ресурсов, на листе уже есть кнопка с
        // вызовом макроса для форматирования таблицы
        public static void exportExcel1(string[,] mas)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            string curDir = Directory.GetCurrentDirectory();
            workBook = excelApp.Workbooks.Open(String.Format("file:///{0}/../../Resources/results.xlsm", curDir));
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            Excel.Range range = workSheet.Range["A1:Q3"];
            range.Clear();
            workSheet.Name = "Результаты теста"; workSheet.Cells[1, 1] = "Результаты теста";

            int countResult = 0;
            for (int i = 0; i < 16; i++)
            {
                workSheet.Cells[2, i + 1] = "[" + mas[i, 0] + "]";
                if (mas[i, 1] == "Верно")
                {
                    countResult++;
                    workSheet.Cells[3, i + 1] = 1;
                }
                else
                    workSheet.Cells[3, i + 1] = 0;
            }

            workSheet.Cells[2, 17] = "Итого";
            workSheet.Cells[3, 17] = countResult;

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        // Метод для записи результатов в excel
        // Записывается в файл Excel, создается диаграмма и снимок диаграммы
        // Снимок сохраняется по указанному пользователем пути
        public static int exportExcel2(string[,] mas)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            var t = Type.Missing;
            var Book = excelApp.Workbooks.Add(t);
            var Lists = Book.Worksheets;
            Excel.Worksheet List = Lists.Item[1];
            List.Cells[1, 1] = "Результаты тестирования";
            for (int i = 0; i < 16; i++)
            {
                List.Range["A" + (i + 2), t].Value2 = "Вопрос " + (i + 1);
                int value;
                if (mas[i, 1] == "Верно")
                    value = 1;
                else
                    value = 0;
                List.Range["B" + (i + 2), t].Value2 = value;
            }
            
            List.Range["B1", t].Value2 = "Ответ";
            Excel.Chart Diagr = excelApp.Charts.Add(t, t, t, t);
            Diagr.SetSourceData(List.Range["A2", "B17"],
            Excel.XlRowCol.xlColumns);
            Diagr.ChartType = Excel.XlChartType.xlColumnClustered;
            Diagr.HasLegend = false;
            Diagr.HasTitle = true;
            Diagr.ChartTitle.Text = "РЕЗУЛЬТАТЫ ТЕСТА";
            Axis Goriz_Os = Diagr.Axes(Excel.XlAxisType.xlCategory,
            Excel.XlAxisGroup.xlPrimary);
            Goriz_Os.HasTitle = true;
            Goriz_Os.AxisTitle.Text = "ОТВЕТЫ";
            Axis Vertic_Os =
            Diagr.Axes(Excel.XlAxisType.xlValue,
            Excel.XlAxisGroup.xlPrimary);
            Vertic_Os.HasTitle = true;
            Vertic_Os.AxisTitle.Text = "ВОПРОСЫ";

            var fd = new SaveFileDialog();
            fd.FileName = "Excel.jpg";
            fd.AddExtension = true;
            fd.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            fd.InitialDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Excel.Range resultCell = List.Range["B18"];
            List.Range["A18"].Value = "Сумма: ";
            resultCell.Formula = "=SUM(B2:B17)";
            int sum = (int)resultCell.Value;

            var res = fd.ShowDialog();
            try
            {
                if (res != DialogResult.OK)
                    throw new Exception();
                excelApp.ActiveChart.Export(fd.FileName);
                MessageBox.Show("Снимок диаграммы успешно сохранен", "Сохранение диаграммы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Снимок диаграммы не был сохранен", "Сохранение диаграммы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            return sum;
        }

        // Метод для формирования одномерного массива результатов тестирования из двумерного
        public static int[] getIntArray(string[,] resultArray)
        {
            int[] array = new int[16];
            for(int i = 0; i < 16; i++)
                if (resultArray[i, 1] == "Верно")
                    array[i] = 1;
                else
                    array[i] = 0;
            return array;
        }

        // Метод для сортировки массива простым обменом (1 способ) и вывода его в таблицу grid
        public static void bubbleSort(ref int[] mas, int length)
        {
            int x;
            for (int i = 1; i < length; i++)
                for (int j = length - 1; j >= i; j--)
                    if (mas[j - 1] < mas[j])
                    {
                        x = mas[j - 1];
                        mas[j - 1] = mas[j];
                        mas[j] = x;
                    }
        }

        // Метод для вывода одномерного ответа результатов в таблицу
        public static void Output_Mas(int[] mas, DataGridView grid)
        {
            grid.Rows.Clear();
            for (int i = 0; i < 16; i++)
                grid.Rows.Add(Convert.ToString(mas[i]));
        }
    }
}
