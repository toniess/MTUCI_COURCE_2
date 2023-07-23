namespace СrmTest
{
    partial class AuthPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.title = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.authBox = new System.Windows.Forms.GroupBox();
            this.authButton = new System.Windows.Forms.Button();
            this.authPassInput = new System.Windows.Forms.TextBox();
            this.authLoginInput = new System.Windows.Forms.TextBox();
            this.authPassLabel = new System.Windows.Forms.Label();
            this.authLoginLabel = new System.Windows.Forms.Label();
            this.regBox = new System.Windows.Forms.GroupBox();
            this.regButton = new System.Windows.Forms.Button();
            this.regLoginInput = new System.Windows.Forms.TextBox();
            this.regPassInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.authBox.SuspendLayout();
            this.regBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.title);
            this.splitContainer1.Panel1.Controls.Add(this.goBack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(642, 450);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(90, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(552, 31);
            this.title.TabIndex = 1;
            this.title.Text = "Для доступа к статистике и тесту необходимо авторизоваться.";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goBack
            // 
            this.goBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.goBack.Location = new System.Drawing.Point(0, 0);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(90, 31);
            this.goBack.TabIndex = 0;
            this.goBack.Text = "<- Назад";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.authBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.regBox);
            this.splitContainer2.Size = new System.Drawing.Size(642, 415);
            this.splitContainer2.SplitterDistance = 304;
            this.splitContainer2.TabIndex = 0;
            // 
            // authBox
            // 
            this.authBox.Controls.Add(this.authButton);
            this.authBox.Controls.Add(this.authPassInput);
            this.authBox.Controls.Add(this.authLoginInput);
            this.authBox.Controls.Add(this.authPassLabel);
            this.authBox.Controls.Add(this.authLoginLabel);
            this.authBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.authBox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authBox.Location = new System.Drawing.Point(0, 0);
            this.authBox.Name = "authBox";
            this.authBox.Size = new System.Drawing.Size(304, 415);
            this.authBox.TabIndex = 1;
            this.authBox.TabStop = false;
            this.authBox.Text = "Авторизация";
            // 
            // authButton
            // 
            this.authButton.AutoSize = true;
            this.authButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.authButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authButton.ForeColor = System.Drawing.Color.White;
            this.authButton.Location = new System.Drawing.Point(79, 217);
            this.authButton.Margin = new System.Windows.Forms.Padding(0);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(198, 46);
            this.authButton.TabIndex = 4;
            this.authButton.Text = "Войти";
            this.authButton.UseVisualStyleBackColor = false;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // authPassInput
            // 
            this.authPassInput.Location = new System.Drawing.Point(138, 176);
            this.authPassInput.Name = "authPassInput";
            this.authPassInput.PasswordChar = '●';
            this.authPassInput.Size = new System.Drawing.Size(139, 26);
            this.authPassInput.TabIndex = 3;
            // 
            // authLoginInput
            // 
            this.authLoginInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLoginInput.Location = new System.Drawing.Point(138, 138);
            this.authLoginInput.Name = "authLoginInput";
            this.authLoginInput.Size = new System.Drawing.Size(139, 26);
            this.authLoginInput.TabIndex = 2;
            // 
            // authPassLabel
            // 
            this.authPassLabel.AutoSize = true;
            this.authPassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authPassLabel.Location = new System.Drawing.Point(79, 179);
            this.authPassLabel.Name = "authPassLabel";
            this.authPassLabel.Size = new System.Drawing.Size(58, 19);
            this.authPassLabel.TabIndex = 1;
            this.authPassLabel.Text = "Пароль";
            // 
            // authLoginLabel
            // 
            this.authLoginLabel.AutoSize = true;
            this.authLoginLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authLoginLabel.Location = new System.Drawing.Point(79, 140);
            this.authLoginLabel.Name = "authLoginLabel";
            this.authLoginLabel.Size = new System.Drawing.Size(52, 19);
            this.authLoginLabel.TabIndex = 0;
            this.authLoginLabel.Text = "Логин";
            // 
            // regBox
            // 
            this.regBox.Controls.Add(this.regButton);
            this.regBox.Controls.Add(this.regLoginInput);
            this.regBox.Controls.Add(this.regPassInput);
            this.regBox.Controls.Add(this.label2);
            this.regBox.Controls.Add(this.label1);
            this.regBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regBox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regBox.Location = new System.Drawing.Point(0, 0);
            this.regBox.Name = "regBox";
            this.regBox.Size = new System.Drawing.Size(334, 415);
            this.regBox.TabIndex = 1;
            this.regBox.TabStop = false;
            this.regBox.Text = "Регистрация";
            // 
            // regButton
            // 
            this.regButton.AutoSize = true;
            this.regButton.BackColor = System.Drawing.Color.Blue;
            this.regButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.ForeColor = System.Drawing.Color.White;
            this.regButton.Location = new System.Drawing.Point(67, 217);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(198, 46);
            this.regButton.TabIndex = 9;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regLoginInput
            // 
            this.regLoginInput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLoginInput.Location = new System.Drawing.Point(126, 138);
            this.regLoginInput.Name = "regLoginInput";
            this.regLoginInput.Size = new System.Drawing.Size(139, 26);
            this.regLoginInput.TabIndex = 7;
            // 
            // regPassInput
            // 
            this.regPassInput.Location = new System.Drawing.Point(126, 176);
            this.regPassInput.Name = "regPassInput";
            this.regPassInput.PasswordChar = '●';
            this.regPassInput.Size = new System.Drawing.Size(139, 26);
            this.regPassInput.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(67, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пароль";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // AuthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AuthPage";
            this.Text = "Авторизация";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.authBox.ResumeLayout(false);
            this.authBox.PerformLayout();
            this.regBox.ResumeLayout(false);
            this.regBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox authBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.TextBox authPassInput;
        private System.Windows.Forms.TextBox authLoginInput;
        private System.Windows.Forms.Label authPassLabel;
        private System.Windows.Forms.Label authLoginLabel;
        private System.Windows.Forms.GroupBox regBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox regLoginInput;
        private System.Windows.Forms.TextBox regPassInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
    }
}