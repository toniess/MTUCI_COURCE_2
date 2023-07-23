using System;
using System.Windows.Forms;
using СrmTest;

namespace CrmTest
{
    public partial class MainPage : Form
    {
        //Массив форм с вопросами
        public static Form[] qForms = new Form[16];
        //Индекс текущего вопроса
        public static int qIndex = 0;
        //Массив ответов
        public static string[,] resultArray = new string[16, 2];

        //ID пользователя в базе данных (-1 если не авториован)
        public static int userIndex = -1;
        //Результат пользователя в базу данных (-1 если нет результата)
        public static int userResult = -1;
        public MainPage()
        {
            InitializeComponent();
            reBuildQuestions();
        }

        //Функция для заполнения массива форм с вопросами
        //и настройки этих форм
        public void reBuildQuestions()
        {
            qForms[0] = new Question1();
            qForms[1] = new Question2();
            qForms[2] = new Question3();
            qForms[3] = new Question4();
            qForms[4] = new Question5();
            qForms[5] = new Question6();
            qForms[6] = new Question7();
            qForms[7] = new Question8();
            qForms[8] = new Question9();
            qForms[9] = new Question10();
            qForms[10] = new Question11();
            qForms[11] = new Question12();
            qForms[12] = new Question13();
            qForms[13] = new Question14();
            qForms[14] = new Question15();
            qForms[15] = new Question16();

            //На каждой форме при попытке закрыть вызывается функция
            //которая уточняет намерения пользователя
            foreach (Form f in qForms)
            {
                f.FormClosing += SomeForm_FormClosing;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Size = this.Size;
            }

            //Массив ответов сбрасывается
            for (int i = 0; i < 16; i++)
            {
                resultArray[i, 0] = (i + 1).ToString();
                resultArray[i, 1] = "";                
            }
        }

        //Данная функция выполняется при попытке закрыть приложение во время тестирования
        private void SomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите завершить тестирование?",
                "Завершение тестирования",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
                new Results(this);
            else
                e.Cancel = true;
        }

        //Функция, которая открывает страницу с теорией
        private void showTheory_Click(object sender, EventArgs e)
        {
            new Theory(this);
        }

        //Функция, которая открывает страницу с правилами тестирования
        private void showTest_Click(object sender, EventArgs e)
        {
            new QuestionMainPage(this);
        }

        //Функция, которая открывает страницу с авторизацией и регистрацией
        private void authorize_Click(object sender, EventArgs e)
        {
            new AuthPage(this);
        }

        //Функция, которая закрывает приложение
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
