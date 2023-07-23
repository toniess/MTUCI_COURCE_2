namespace CrmTest
{
    partial class QuestionMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionMainPage));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.goHome = new System.Windows.Forms.Button();
            this.goTest = new System.Windows.Forms.Button();
            this.testStartLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.testRules = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goHome
            // 
            this.goHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.goHome.Location = new System.Drawing.Point(0, 0);
            this.goHome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(210, 63);
            this.goHome.TabIndex = 0;
            this.goHome.Text = "На главную";
            this.goHome.UseVisualStyleBackColor = true;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // goTest
            // 
            this.goTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.goTest.Location = new System.Drawing.Point(1372, 0);
            this.goTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.goTest.Name = "goTest";
            this.goTest.Size = new System.Drawing.Size(228, 63);
            this.goTest.TabIndex = 1;
            this.goTest.Text = "Начать тест";
            this.goTest.UseVisualStyleBackColor = true;
            this.goTest.Click += new System.EventHandler(this.goTest_Click);
            // 
            // testStartLabel
            // 
            this.testStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testStartLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testStartLabel.Location = new System.Drawing.Point(210, 0);
            this.testStartLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.testStartLabel.Name = "testStartLabel";
            this.testStartLabel.Size = new System.Drawing.Size(1162, 63);
            this.testStartLabel.TabIndex = 2;
            this.testStartLabel.Text = "Правила тестирования";
            this.testStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.testStartLabel);
            this.splitContainer1.Panel1.Controls.Add(this.goTest);
            this.splitContainer1.Panel1.Controls.Add(this.goHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.testRules);
            this.splitContainer1.Size = new System.Drawing.Size(1600, 865);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // testRules
            // 
            this.testRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testRules.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testRules.Location = new System.Drawing.Point(0, 0);
            this.testRules.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.testRules.Name = "testRules";
            this.testRules.Size = new System.Drawing.Size(1600, 794);
            this.testRules.TabIndex = 0;
            this.testRules.Text = resources.GetString("testRules.Text");
            // 
            // QuestionMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "QuestionMainPage";
            this.Text = "Начало тестирования";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button goHome;
        private System.Windows.Forms.Button goTest;
        private System.Windows.Forms.Label testStartLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label testRules;
    }
}