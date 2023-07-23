namespace СrmTest
{
    partial class Results
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.theoryLabel = new System.Windows.Forms.Label();
            this.goHome = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.grid = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportExcel2 = new System.Windows.Forms.Button();
            this.exportExcel = new System.Windows.Forms.Button();
            this.exportPDF = new System.Windows.Forms.Button();
            this.exportDB = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Label();
            this.wrongAns = new System.Windows.Forms.Label();
            this.rightAns = new System.Windows.Forms.Label();
            this.qNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.theoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.goHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(706, 460);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 2;
            // 
            // theoryLabel
            // 
            this.theoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theoryLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryLabel.Location = new System.Drawing.Point(105, 0);
            this.theoryLabel.Name = "theoryLabel";
            this.theoryLabel.Size = new System.Drawing.Size(601, 30);
            this.theoryLabel.TabIndex = 2;
            this.theoryLabel.Text = "Результаты тестирования";
            this.theoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goHome
            // 
            this.goHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.goHome.Location = new System.Drawing.Point(0, 0);
            this.goHome.Name = "goHome";
            this.goHome.Size = new System.Drawing.Size(105, 30);
            this.goHome.TabIndex = 0;
            this.goHome.Text = "На главную";
            this.goHome.UseVisualStyleBackColor = true;
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.exportExcel2);
            this.splitContainer2.Panel2.Controls.Add(this.exportExcel);
            this.splitContainer2.Panel2.Controls.Add(this.exportPDF);
            this.splitContainer2.Panel2.Controls.Add(this.exportDB);
            this.splitContainer2.Panel2.Controls.Add(this.percent);
            this.splitContainer2.Panel2.Controls.Add(this.wrongAns);
            this.splitContainer2.Panel2.Controls.Add(this.rightAns);
            this.splitContainer2.Size = new System.Drawing.Size(706, 426);
            this.splitContainer2.SplitterDistance = 544;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grid2);
            this.splitContainer3.Panel1.Controls.Add(this.grid);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chart);
            this.splitContainer3.Size = new System.Drawing.Size(544, 426);
            this.splitContainer3.SplitterDistance = 261;
            this.splitContainer3.SplitterWidth = 2;
            this.splitContainer3.TabIndex = 0;
            // 
            // grid2
            // 
            this.grid2.AllowUserToAddRows = false;
            this.grid2.AllowUserToDeleteRows = false;
            this.grid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.grid2.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid2.Location = new System.Drawing.Point(133, 0);
            this.grid2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid2.MultiSelect = false;
            this.grid2.Name = "grid2";
            this.grid2.ReadOnly = true;
            this.grid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid2.RowHeadersVisible = false;
            this.grid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid2.RowTemplate.Height = 33;
            this.grid2.Size = new System.Drawing.Size(128, 426);
            this.grid2.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qNumber,
            this.result});
            this.grid.Dock = System.Windows.Forms.DockStyle.Left;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid.RowTemplate.Height = 33;
            this.grid.Size = new System.Drawing.Size(133, 426);
            this.grid.TabIndex = 0;
            // 
            // chart
            // 
            customLabel1.FromPosition = 2D;
            customLabel1.Text = "Было";
            customLabel2.FromPosition = 4D;
            customLabel2.Text = "Стало";
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.CustomLabels.Add(customLabel2);
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 70F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 20F;
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.IsSoftShadows = false;
            legend1.AutoFitMinFontSize = 5;
            legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5.647059F;
            legend1.Position.Width = 100F;
            legend1.Position.Y = 3F;
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green,
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Верно";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Неверно";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(281, 426);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // exportExcel2
            // 
            this.exportExcel2.AutoSize = true;
            this.exportExcel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exportExcel2.Location = new System.Drawing.Point(0, 235);
            this.exportExcel2.Name = "exportExcel2";
            this.exportExcel2.Size = new System.Drawing.Size(158, 56);
            this.exportExcel2.TabIndex = 6;
            this.exportExcel2.Text = "Записать результат в Excel c диаграммой и снимком экрана";
            this.exportExcel2.UseVisualStyleBackColor = true;
            this.exportExcel2.Click += new System.EventHandler(this.exportExcel2_Click);
            // 
            // exportExcel
            // 
            this.exportExcel.AutoSize = true;
            this.exportExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exportExcel.Location = new System.Drawing.Point(0, 291);
            this.exportExcel.Name = "exportExcel";
            this.exportExcel.Size = new System.Drawing.Size(158, 45);
            this.exportExcel.TabIndex = 5;
            this.exportExcel.Text = "Записать результат в Excel c созданием макроса";
            this.exportExcel.UseVisualStyleBackColor = true;
            this.exportExcel.Click += new System.EventHandler(this.exportExcel_Click);
            // 
            // exportPDF
            // 
            this.exportPDF.AutoSize = true;
            this.exportPDF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exportPDF.Location = new System.Drawing.Point(0, 336);
            this.exportPDF.Name = "exportPDF";
            this.exportPDF.Size = new System.Drawing.Size(158, 45);
            this.exportPDF.TabIndex = 4;
            this.exportPDF.Text = "Записать результат в PFD";
            this.exportPDF.UseVisualStyleBackColor = true;
            this.exportPDF.Click += new System.EventHandler(this.exportPDF_Click);
            // 
            // exportDB
            // 
            this.exportDB.AutoSize = true;
            this.exportDB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exportDB.Location = new System.Drawing.Point(0, 381);
            this.exportDB.Name = "exportDB";
            this.exportDB.Size = new System.Drawing.Size(158, 45);
            this.exportDB.TabIndex = 3;
            this.exportDB.Text = "Записать результат в базу данных";
            this.exportDB.UseVisualStyleBackColor = true;
            this.exportDB.Click += new System.EventHandler(this.exportDB_Click);
            // 
            // percent
            // 
            this.percent.Dock = System.Windows.Forms.DockStyle.Top;
            this.percent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percent.Location = new System.Drawing.Point(0, 62);
            this.percent.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(158, 30);
            this.percent.TabIndex = 2;
            this.percent.Text = "Усвоение темы: ";
            this.percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wrongAns
            // 
            this.wrongAns.Dock = System.Windows.Forms.DockStyle.Top;
            this.wrongAns.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongAns.Location = new System.Drawing.Point(0, 34);
            this.wrongAns.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.wrongAns.Name = "wrongAns";
            this.wrongAns.Size = new System.Drawing.Size(158, 28);
            this.wrongAns.TabIndex = 1;
            this.wrongAns.Text = "Неверных ответов: ";
            this.wrongAns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightAns
            // 
            this.rightAns.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightAns.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightAns.Location = new System.Drawing.Point(0, 0);
            this.rightAns.Name = "rightAns";
            this.rightAns.Size = new System.Drawing.Size(158, 34);
            this.rightAns.TabIndex = 0;
            this.rightAns.Text = "Верных ответов: ";
            this.rightAns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qNumber
            // 
            this.qNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qNumber.FillWeight = 30F;
            this.qNumber.HeaderText = "№";
            this.qNumber.MinimumWidth = 10;
            this.qNumber.Name = "qNumber";
            this.qNumber.ReadOnly = true;
            this.qNumber.Width = 43;
            // 
            // result
            // 
            this.result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.result.FillWeight = 50F;
            this.result.HeaderText = "Результат";
            this.result.MinimumWidth = 10;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.FillWeight = 120F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Результат (сорт.)";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 150;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 117;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 460);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Results";
            this.Text = "Результаты тестирования";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label theoryLabel;
        private System.Windows.Forms.Button goHome;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button exportPDF;
        private System.Windows.Forms.Button exportDB;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label wrongAns;
        private System.Windows.Forms.Label rightAns;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button exportExcel;
        private System.Windows.Forms.Button exportExcel2;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}