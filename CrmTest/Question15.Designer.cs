﻿namespace СrmTest
{
    partial class Question15
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.goNext = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.check = new System.Windows.Forms.Button();
            this.questionTitle = new System.Windows.Forms.Label();
            this.goBack = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.questionTask = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.bQuest16 = new System.Windows.Forms.Button();
            this.bQuest15 = new System.Windows.Forms.Button();
            this.bQuest14 = new System.Windows.Forms.Button();
            this.bQuest13 = new System.Windows.Forms.Button();
            this.bQuest12 = new System.Windows.Forms.Button();
            this.bQuest11 = new System.Windows.Forms.Button();
            this.bQuest10 = new System.Windows.Forms.Button();
            this.bQuest9 = new System.Windows.Forms.Button();
            this.bQuest8 = new System.Windows.Forms.Button();
            this.bQuest7 = new System.Windows.Forms.Button();
            this.bQuest6 = new System.Windows.Forms.Button();
            this.bQuest5 = new System.Windows.Forms.Button();
            this.bQuest4 = new System.Windows.Forms.Button();
            this.bQuest3 = new System.Windows.Forms.Button();
            this.bQuest2 = new System.Windows.Forms.Button();
            this.bQuest1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // goNext
            // 
            this.goNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.goNext.Location = new System.Drawing.Point(1112, 0);
            this.goNext.Margin = new System.Windows.Forms.Padding(6);
            this.goNext.Name = "goNext";
            this.goNext.Size = new System.Drawing.Size(172, 33);
            this.goNext.TabIndex = 1;
            this.goNext.Text = "Далее ->";
            this.goNext.UseVisualStyleBackColor = true;
            this.goNext.Click += new System.EventHandler(this.goNext_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.check);
            this.splitContainer1.Panel1.Controls.Add(this.questionTitle);
            this.splitContainer1.Panel1.Controls.Add(this.goNext);
            this.splitContainer1.Panel1.Controls.Add(this.goBack);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 781);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 16;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.check.Dock = System.Windows.Forms.DockStyle.Right;
            this.check.Location = new System.Drawing.Point(922, 0);
            this.check.Margin = new System.Windows.Forms.Padding(6);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(190, 33);
            this.check.TabIndex = 19;
            this.check.Text = "Проверить ответ";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // questionTitle
            // 
            this.questionTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.questionTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTitle.Location = new System.Drawing.Point(210, 0);
            this.questionTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(902, 33);
            this.questionTitle.TabIndex = 2;
            this.questionTitle.Text = "Вопрос 15 из 16";
            this.questionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goBack
            // 
            this.goBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.goBack.Location = new System.Drawing.Point(0, 0);
            this.goBack.Margin = new System.Windows.Forms.Padding(6);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(210, 33);
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
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.answer);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.questionTask);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.exit);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest16);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest15);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest14);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest13);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest12);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest11);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest10);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest9);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest8);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest7);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest6);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest5);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest4);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest3);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest2);
            this.splitContainer2.Panel2.Controls.Add(this.bQuest1);
            this.splitContainer2.Size = new System.Drawing.Size(1284, 740);
            this.splitContainer2.SplitterDistance = 691;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(994, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Профессиональный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Стандартный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Базовый";
            // 
            // answer
            // 
            this.answer.Dock = System.Windows.Forms.DockStyle.Top;
            this.answer.LargeChange = 1;
            this.answer.Location = new System.Drawing.Point(0, 81);
            this.answer.Maximum = 3;
            this.answer.Name = "answer";
            this.answer.Padding = new System.Windows.Forms.Padding(0, 192, 0, 0);
            this.answer.Size = new System.Drawing.Size(1284, 17);
            this.answer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бесплатный";
            // 
            // questionTask
            // 
            this.questionTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionTask.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTask.Location = new System.Drawing.Point(0, 0);
            this.questionTask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionTask.Name = "questionTask";
            this.questionTask.Size = new System.Drawing.Size(1284, 81);
            this.questionTask.TabIndex = 0;
            this.questionTask.Text = "Какому тарифу соответствует функционал демо-доступа?";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1008, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(276, 41);
            this.exit.TabIndex = 17;
            this.exit.Text = "Завершить тестирование";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // bQuest16
            // 
            this.bQuest16.AutoEllipsis = true;
            this.bQuest16.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest16.Location = new System.Drawing.Point(1500, 0);
            this.bQuest16.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest16.Name = "bQuest16";
            this.bQuest16.Size = new System.Drawing.Size(100, 41);
            this.bQuest16.TabIndex = 16;
            this.bQuest16.Text = "16";
            this.bQuest16.UseVisualStyleBackColor = true;
            // 
            // bQuest15
            // 
            this.bQuest15.AutoEllipsis = true;
            this.bQuest15.BackColor = System.Drawing.Color.Blue;
            this.bQuest15.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest15.ForeColor = System.Drawing.Color.White;
            this.bQuest15.Location = new System.Drawing.Point(1400, 0);
            this.bQuest15.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest15.Name = "bQuest15";
            this.bQuest15.Size = new System.Drawing.Size(100, 41);
            this.bQuest15.TabIndex = 15;
            this.bQuest15.Text = "15";
            this.bQuest15.UseVisualStyleBackColor = false;
            // 
            // bQuest14
            // 
            this.bQuest14.AutoEllipsis = true;
            this.bQuest14.BackColor = System.Drawing.Color.White;
            this.bQuest14.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest14.ForeColor = System.Drawing.Color.Black;
            this.bQuest14.Location = new System.Drawing.Point(1300, 0);
            this.bQuest14.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest14.Name = "bQuest14";
            this.bQuest14.Size = new System.Drawing.Size(100, 41);
            this.bQuest14.TabIndex = 14;
            this.bQuest14.Text = "14";
            this.bQuest14.UseVisualStyleBackColor = false;
            // 
            // bQuest13
            // 
            this.bQuest13.AutoEllipsis = true;
            this.bQuest13.BackColor = System.Drawing.Color.White;
            this.bQuest13.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest13.ForeColor = System.Drawing.Color.Black;
            this.bQuest13.Location = new System.Drawing.Point(1200, 0);
            this.bQuest13.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest13.Name = "bQuest13";
            this.bQuest13.Size = new System.Drawing.Size(100, 41);
            this.bQuest13.TabIndex = 12;
            this.bQuest13.Text = "13";
            this.bQuest13.UseVisualStyleBackColor = false;
            // 
            // bQuest12
            // 
            this.bQuest12.AutoEllipsis = true;
            this.bQuest12.BackColor = System.Drawing.Color.White;
            this.bQuest12.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest12.ForeColor = System.Drawing.Color.Black;
            this.bQuest12.Location = new System.Drawing.Point(1100, 0);
            this.bQuest12.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest12.Name = "bQuest12";
            this.bQuest12.Size = new System.Drawing.Size(100, 41);
            this.bQuest12.TabIndex = 11;
            this.bQuest12.Text = "12";
            this.bQuest12.UseVisualStyleBackColor = false;
            // 
            // bQuest11
            // 
            this.bQuest11.AutoEllipsis = true;
            this.bQuest11.BackColor = System.Drawing.Color.White;
            this.bQuest11.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest11.ForeColor = System.Drawing.Color.Black;
            this.bQuest11.Location = new System.Drawing.Point(1000, 0);
            this.bQuest11.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest11.Name = "bQuest11";
            this.bQuest11.Size = new System.Drawing.Size(100, 41);
            this.bQuest11.TabIndex = 10;
            this.bQuest11.Text = "11";
            this.bQuest11.UseVisualStyleBackColor = false;
            // 
            // bQuest10
            // 
            this.bQuest10.AutoEllipsis = true;
            this.bQuest10.BackColor = System.Drawing.Color.White;
            this.bQuest10.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest10.ForeColor = System.Drawing.Color.Black;
            this.bQuest10.Location = new System.Drawing.Point(900, 0);
            this.bQuest10.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest10.Name = "bQuest10";
            this.bQuest10.Size = new System.Drawing.Size(100, 41);
            this.bQuest10.TabIndex = 9;
            this.bQuest10.Text = "10";
            this.bQuest10.UseVisualStyleBackColor = false;
            // 
            // bQuest9
            // 
            this.bQuest9.AutoEllipsis = true;
            this.bQuest9.BackColor = System.Drawing.Color.White;
            this.bQuest9.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest9.ForeColor = System.Drawing.Color.Black;
            this.bQuest9.Location = new System.Drawing.Point(800, 0);
            this.bQuest9.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest9.Name = "bQuest9";
            this.bQuest9.Size = new System.Drawing.Size(100, 41);
            this.bQuest9.TabIndex = 8;
            this.bQuest9.Text = "9";
            this.bQuest9.UseVisualStyleBackColor = false;
            // 
            // bQuest8
            // 
            this.bQuest8.AutoEllipsis = true;
            this.bQuest8.BackColor = System.Drawing.Color.White;
            this.bQuest8.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest8.ForeColor = System.Drawing.Color.Black;
            this.bQuest8.Location = new System.Drawing.Point(700, 0);
            this.bQuest8.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest8.Name = "bQuest8";
            this.bQuest8.Size = new System.Drawing.Size(100, 41);
            this.bQuest8.TabIndex = 7;
            this.bQuest8.Text = "8";
            this.bQuest8.UseVisualStyleBackColor = false;
            // 
            // bQuest7
            // 
            this.bQuest7.AutoEllipsis = true;
            this.bQuest7.BackColor = System.Drawing.Color.White;
            this.bQuest7.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest7.ForeColor = System.Drawing.Color.Black;
            this.bQuest7.Location = new System.Drawing.Point(600, 0);
            this.bQuest7.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest7.Name = "bQuest7";
            this.bQuest7.Size = new System.Drawing.Size(100, 41);
            this.bQuest7.TabIndex = 6;
            this.bQuest7.Text = "7";
            this.bQuest7.UseVisualStyleBackColor = false;
            // 
            // bQuest6
            // 
            this.bQuest6.AutoEllipsis = true;
            this.bQuest6.BackColor = System.Drawing.Color.White;
            this.bQuest6.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest6.ForeColor = System.Drawing.Color.Black;
            this.bQuest6.Location = new System.Drawing.Point(500, 0);
            this.bQuest6.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest6.Name = "bQuest6";
            this.bQuest6.Size = new System.Drawing.Size(100, 41);
            this.bQuest6.TabIndex = 5;
            this.bQuest6.Text = "6";
            this.bQuest6.UseVisualStyleBackColor = false;
            // 
            // bQuest5
            // 
            this.bQuest5.AutoEllipsis = true;
            this.bQuest5.BackColor = System.Drawing.Color.White;
            this.bQuest5.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest5.ForeColor = System.Drawing.Color.Black;
            this.bQuest5.Location = new System.Drawing.Point(400, 0);
            this.bQuest5.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest5.Name = "bQuest5";
            this.bQuest5.Size = new System.Drawing.Size(100, 41);
            this.bQuest5.TabIndex = 4;
            this.bQuest5.Text = "5";
            this.bQuest5.UseVisualStyleBackColor = false;
            // 
            // bQuest4
            // 
            this.bQuest4.AutoEllipsis = true;
            this.bQuest4.BackColor = System.Drawing.Color.White;
            this.bQuest4.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest4.ForeColor = System.Drawing.Color.Black;
            this.bQuest4.Location = new System.Drawing.Point(300, 0);
            this.bQuest4.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest4.Name = "bQuest4";
            this.bQuest4.Size = new System.Drawing.Size(100, 41);
            this.bQuest4.TabIndex = 3;
            this.bQuest4.Text = "4";
            this.bQuest4.UseVisualStyleBackColor = false;
            // 
            // bQuest3
            // 
            this.bQuest3.AutoEllipsis = true;
            this.bQuest3.BackColor = System.Drawing.Color.White;
            this.bQuest3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest3.ForeColor = System.Drawing.Color.Black;
            this.bQuest3.Location = new System.Drawing.Point(200, 0);
            this.bQuest3.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest3.Name = "bQuest3";
            this.bQuest3.Size = new System.Drawing.Size(100, 41);
            this.bQuest3.TabIndex = 2;
            this.bQuest3.Text = "3";
            this.bQuest3.UseVisualStyleBackColor = false;
            // 
            // bQuest2
            // 
            this.bQuest2.AutoEllipsis = true;
            this.bQuest2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest2.Location = new System.Drawing.Point(100, 0);
            this.bQuest2.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest2.Name = "bQuest2";
            this.bQuest2.Size = new System.Drawing.Size(100, 41);
            this.bQuest2.TabIndex = 1;
            this.bQuest2.Text = "2";
            this.bQuest2.UseVisualStyleBackColor = true;
            // 
            // bQuest1
            // 
            this.bQuest1.AutoEllipsis = true;
            this.bQuest1.BackColor = System.Drawing.Color.White;
            this.bQuest1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bQuest1.ForeColor = System.Drawing.Color.Black;
            this.bQuest1.Location = new System.Drawing.Point(0, 0);
            this.bQuest1.Margin = new System.Windows.Forms.Padding(6);
            this.bQuest1.Name = "bQuest1";
            this.bQuest1.Size = new System.Drawing.Size(100, 41);
            this.bQuest1.TabIndex = 0;
            this.bQuest1.Text = "1";
            this.bQuest1.UseVisualStyleBackColor = false;
            // 
            // Question15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Question15";
            this.Text = "Тестирование";
            this.VisibleChanged += new System.EventHandler(this.Question15_VisibleChanged);
            this.Resize += new System.EventHandler(this.Question15_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button goNext;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label questionTitle;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionTask;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button bQuest16;
        private System.Windows.Forms.Button bQuest15;
        private System.Windows.Forms.Button bQuest14;
        private System.Windows.Forms.Button bQuest13;
        private System.Windows.Forms.Button bQuest12;
        private System.Windows.Forms.Button bQuest11;
        private System.Windows.Forms.Button bQuest10;
        private System.Windows.Forms.Button bQuest9;
        private System.Windows.Forms.Button bQuest8;
        private System.Windows.Forms.Button bQuest7;
        private System.Windows.Forms.Button bQuest6;
        private System.Windows.Forms.Button bQuest5;
        private System.Windows.Forms.Button bQuest4;
        private System.Windows.Forms.Button bQuest3;
        private System.Windows.Forms.Button bQuest2;
        private System.Windows.Forms.Button bQuest1;
    }
}