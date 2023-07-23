namespace CrmTest
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DownText = new System.Windows.Forms.Label();
            this.MiddleText = new System.Windows.Forms.Label();
            this.TopText = new System.Windows.Forms.Label();
            this.authorize = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.showTest = new System.Windows.Forms.Button();
            this.showTheory = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.DownText);
            this.splitContainer1.Panel1.Controls.Add(this.MiddleText);
            this.splitContainer1.Panel1.Controls.Add(this.TopText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.authorize);
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Panel2.Controls.Add(this.showTest);
            this.splitContainer1.Panel2.Controls.Add(this.showTheory);
            this.splitContainer1.Size = new System.Drawing.Size(642, 469);
            this.splitContainer1.SplitterDistance = 514;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // DownText
            // 
            this.DownText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownText.Location = new System.Drawing.Point(0, 439);
            this.DownText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DownText.Name = "DownText";
            this.DownText.Size = new System.Drawing.Size(512, 28);
            this.DownText.TabIndex = 2;
            this.DownText.Text = "Москва, 2023";
            this.DownText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MiddleText
            // 
            this.MiddleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddleText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MiddleText.Location = new System.Drawing.Point(0, 313);
            this.MiddleText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MiddleText.Name = "MiddleText";
            this.MiddleText.Size = new System.Drawing.Size(512, 83);
            this.MiddleText.TabIndex = 1;
            this.MiddleText.Text = "\r\nВыполнил: \r\nстудент группы БФИ2202\r\nГлушков И.И.\r\n\r\nПроверил: \r\nдоц. кафедры «И" +
    "нформатика», к.п.н.\r\nГуриков С. Р.\r\n";
            this.MiddleText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TopText
            // 
            this.TopText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopText.Location = new System.Drawing.Point(0, 0);
            this.TopText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(512, 313);
            this.TopText.TabIndex = 0;
            this.TopText.Text = resources.GetString("TopText.Text");
            this.TopText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authorize
            // 
            this.authorize.Dock = System.Windows.Forms.DockStyle.Top;
            this.authorize.Location = new System.Drawing.Point(0, 56);
            this.authorize.Margin = new System.Windows.Forms.Padding(2);
            this.authorize.Name = "authorize";
            this.authorize.Size = new System.Drawing.Size(124, 28);
            this.authorize.TabIndex = 6;
            this.authorize.Text = "Авторизация";
            this.authorize.UseVisualStyleBackColor = true;
            this.authorize.Click += new System.EventHandler(this.authorize_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.Location = new System.Drawing.Point(0, 439);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 28);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showTest
            // 
            this.showTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.showTest.Location = new System.Drawing.Point(0, 28);
            this.showTest.Margin = new System.Windows.Forms.Padding(2);
            this.showTest.Name = "showTest";
            this.showTest.Size = new System.Drawing.Size(124, 28);
            this.showTest.TabIndex = 1;
            this.showTest.Text = "Тест";
            this.showTest.UseVisualStyleBackColor = true;
            this.showTest.Click += new System.EventHandler(this.showTest_Click);
            // 
            // showTheory
            // 
            this.showTheory.Dock = System.Windows.Forms.DockStyle.Top;
            this.showTheory.Location = new System.Drawing.Point(0, 0);
            this.showTheory.Margin = new System.Windows.Forms.Padding(2);
            this.showTheory.Name = "showTheory";
            this.showTheory.Size = new System.Drawing.Size(124, 28);
            this.showTheory.TabIndex = 0;
            this.showTheory.Text = "Теория";
            this.showTheory.UseVisualStyleBackColor = true;
            this.showTheory.Click += new System.EventHandler(this.showTheory_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 469);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label DownText;
        private System.Windows.Forms.Label MiddleText;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button showTest;
        private System.Windows.Forms.Button showTheory;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button authorize;
    }
}

