namespace Family_budget_ver5.UserControls
{
    partial class GrafsDate
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafsDate));
            this.ChartTransaction0_family = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTransaction1_family = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbbox_transaction_chart = new System.Windows.Forms.ComboBox();
            this.btnSearchThisDay = new System.Windows.Forms.Button();
            this.btnSearchThisMonth = new System.Windows.Forms.Button();
            this.btnSearchThisYear = new System.Windows.Forms.Button();
            this.ChartAllYearSearch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxAllYearSearch = new System.Windows.Forms.CheckBox();
            this.panel_maxValueSales = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_titleSearchMaxValuesSales = new System.Windows.Forms.Label();
            this.label_maxValueSales_title = new System.Windows.Forms.Label();
            this.panel_maxValueCost = new System.Windows.Forms.Panel();
            this.label_titleSearchMaxValuesCost = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_maxValueCost_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTransaction0_family)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTransaction1_family)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAllYearSearch)).BeginInit();
            this.panel_maxValueSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_maxValueCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTransaction0_family
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartTransaction0_family.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.ChartTransaction0_family.Legends.Add(legend1);
            this.ChartTransaction0_family.Location = new System.Drawing.Point(638, 57);
            this.ChartTransaction0_family.Name = "ChartTransaction0_family";
            this.ChartTransaction0_family.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Write-off";
            this.ChartTransaction0_family.Series.Add(series1);
            this.ChartTransaction0_family.Size = new System.Drawing.Size(398, 266);
            this.ChartTransaction0_family.TabIndex = 6;
            this.ChartTransaction0_family.Text = "Списание";
            this.ChartTransaction0_family.Visible = false;
            // 
            // ChartTransaction1_family
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartTransaction1_family.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.ChartTransaction1_family.Legends.Add(legend2);
            this.ChartTransaction1_family.Location = new System.Drawing.Point(638, 45);
            this.ChartTransaction1_family.Name = "ChartTransaction1_family";
            this.ChartTransaction1_family.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Profit";
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.ChartTransaction1_family.Series.Add(series2);
            this.ChartTransaction1_family.Size = new System.Drawing.Size(398, 266);
            this.ChartTransaction1_family.TabIndex = 5;
            this.ChartTransaction1_family.Text = "chart1";
            // 
            // cmbbox_transaction_chart
            // 
            this.cmbbox_transaction_chart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbbox_transaction_chart.FormattingEnabled = true;
            this.cmbbox_transaction_chart.Items.AddRange(new object[] {
            "Списание",
            "Зачисление"});
            this.cmbbox_transaction_chart.Location = new System.Drawing.Point(706, 3);
            this.cmbbox_transaction_chart.Name = "cmbbox_transaction_chart";
            this.cmbbox_transaction_chart.Size = new System.Drawing.Size(230, 36);
            this.cmbbox_transaction_chart.TabIndex = 3;
            this.cmbbox_transaction_chart.Text = "Зачисление";
            this.cmbbox_transaction_chart.TextChanged += new System.EventHandler(this.cmbbox_transaction_chart_TextChanged);
            // 
            // btnSearchThisDay
            // 
            this.btnSearchThisDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchThisDay.Location = new System.Drawing.Point(171, 134);
            this.btnSearchThisDay.Name = "btnSearchThisDay";
            this.btnSearchThisDay.Size = new System.Drawing.Size(129, 35);
            this.btnSearchThisDay.TabIndex = 7;
            this.btnSearchThisDay.Text = "День";
            this.btnSearchThisDay.UseVisualStyleBackColor = true;
            this.btnSearchThisDay.Click += new System.EventHandler(this.btnSearchThisDay_Click);
            // 
            // btnSearchThisMonth
            // 
            this.btnSearchThisMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchThisMonth.Location = new System.Drawing.Point(306, 134);
            this.btnSearchThisMonth.Name = "btnSearchThisMonth";
            this.btnSearchThisMonth.Size = new System.Drawing.Size(94, 35);
            this.btnSearchThisMonth.TabIndex = 8;
            this.btnSearchThisMonth.Text = "Месяц";
            this.btnSearchThisMonth.UseVisualStyleBackColor = true;
            this.btnSearchThisMonth.Click += new System.EventHandler(this.btnSearchThisMonth_Click);
            // 
            // btnSearchThisYear
            // 
            this.btnSearchThisYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchThisYear.Location = new System.Drawing.Point(406, 134);
            this.btnSearchThisYear.Name = "btnSearchThisYear";
            this.btnSearchThisYear.Size = new System.Drawing.Size(122, 35);
            this.btnSearchThisYear.TabIndex = 9;
            this.btnSearchThisYear.Text = "Год";
            this.btnSearchThisYear.UseVisualStyleBackColor = true;
            this.btnSearchThisYear.Click += new System.EventHandler(this.btnSearchThisYear_Click);
            // 
            // ChartAllYearSearch
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartAllYearSearch.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.ChartAllYearSearch.Legends.Add(legend3);
            this.ChartAllYearSearch.Location = new System.Drawing.Point(3, 175);
            this.ChartAllYearSearch.Name = "ChartAllYearSearch";
            this.ChartAllYearSearch.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Sales";
            series3.YValuesPerPoint = 2;
            this.ChartAllYearSearch.Series.Add(series3);
            this.ChartAllYearSearch.Size = new System.Drawing.Size(658, 302);
            this.ChartAllYearSearch.TabIndex = 10;
            this.ChartAllYearSearch.Text = "chart1";
            // 
            // checkBoxAllYearSearch
            // 
            this.checkBoxAllYearSearch.AutoSize = true;
            this.checkBoxAllYearSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAllYearSearch.Location = new System.Drawing.Point(12, 140);
            this.checkBoxAllYearSearch.Name = "checkBoxAllYearSearch";
            this.checkBoxAllYearSearch.Size = new System.Drawing.Size(153, 27);
            this.checkBoxAllYearSearch.TabIndex = 11;
            this.checkBoxAllYearSearch.Text = "Зачисление";
            this.checkBoxAllYearSearch.UseVisualStyleBackColor = true;
            this.checkBoxAllYearSearch.CheckedChanged += new System.EventHandler(this.checkBoxAllYearSearch_CheckedChanged);
            // 
            // panel_maxValueSales
            // 
            this.panel_maxValueSales.Controls.Add(this.pictureBox1);
            this.panel_maxValueSales.Controls.Add(this.label_titleSearchMaxValuesSales);
            this.panel_maxValueSales.Controls.Add(this.label_maxValueSales_title);
            this.panel_maxValueSales.Location = new System.Drawing.Point(12, 15);
            this.panel_maxValueSales.Name = "panel_maxValueSales";
            this.panel_maxValueSales.Size = new System.Drawing.Size(276, 78);
            this.panel_maxValueSales.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_titleSearchMaxValuesSales
            // 
            this.label_titleSearchMaxValuesSales.AutoSize = true;
            this.label_titleSearchMaxValuesSales.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_titleSearchMaxValuesSales.Location = new System.Drawing.Point(90, 38);
            this.label_titleSearchMaxValuesSales.Name = "label_titleSearchMaxValuesSales";
            this.label_titleSearchMaxValuesSales.Size = new System.Drawing.Size(65, 23);
            this.label_titleSearchMaxValuesSales.TabIndex = 1;
            this.label_titleSearchMaxValuesSales.Text = "10000";
            // 
            // label_maxValueSales_title
            // 
            this.label_maxValueSales_title.AutoSize = true;
            this.label_maxValueSales_title.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_maxValueSales_title.Location = new System.Drawing.Point(90, 15);
            this.label_maxValueSales_title.Name = "label_maxValueSales_title";
            this.label_maxValueSales_title.Size = new System.Drawing.Size(167, 23);
            this.label_maxValueSales_title.TabIndex = 0;
            this.label_maxValueSales_title.Text = "Всего получено";
            // 
            // panel_maxValueCost
            // 
            this.panel_maxValueCost.Controls.Add(this.label_titleSearchMaxValuesCost);
            this.panel_maxValueCost.Controls.Add(this.pictureBox2);
            this.panel_maxValueCost.Controls.Add(this.label_maxValueCost_title);
            this.panel_maxValueCost.Location = new System.Drawing.Point(306, 15);
            this.panel_maxValueCost.Name = "panel_maxValueCost";
            this.panel_maxValueCost.Size = new System.Drawing.Size(287, 78);
            this.panel_maxValueCost.TabIndex = 13;
            // 
            // label_titleSearchMaxValuesCost
            // 
            this.label_titleSearchMaxValuesCost.AutoSize = true;
            this.label_titleSearchMaxValuesCost.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_titleSearchMaxValuesCost.Location = new System.Drawing.Point(90, 42);
            this.label_titleSearchMaxValuesCost.Name = "label_titleSearchMaxValuesCost";
            this.label_titleSearchMaxValuesCost.Size = new System.Drawing.Size(65, 23);
            this.label_titleSearchMaxValuesCost.TabIndex = 3;
            this.label_titleSearchMaxValuesCost.Text = "10000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label_maxValueCost_title
            // 
            this.label_maxValueCost_title.AutoSize = true;
            this.label_maxValueCost_title.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label_maxValueCost_title.Location = new System.Drawing.Point(90, 15);
            this.label_maxValueCost_title.Name = "label_maxValueCost_title";
            this.label_maxValueCost_title.Size = new System.Drawing.Size(183, 23);
            this.label_maxValueCost_title.TabIndex = 0;
            this.label_maxValueCost_title.Text = "Всего Потрачено";
            // 
            // GrafsDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_maxValueCost);
            this.Controls.Add(this.panel_maxValueSales);
            this.Controls.Add(this.ChartAllYearSearch);
            this.Controls.Add(this.cmbbox_transaction_chart);
            this.Controls.Add(this.checkBoxAllYearSearch);
            this.Controls.Add(this.ChartTransaction1_family);
            this.Controls.Add(this.btnSearchThisDay);
            this.Controls.Add(this.btnSearchThisMonth);
            this.Controls.Add(this.ChartTransaction0_family);
            this.Controls.Add(this.btnSearchThisYear);
            this.Name = "GrafsDate";
            this.Size = new System.Drawing.Size(1166, 591);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTransaction0_family)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTransaction1_family)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAllYearSearch)).EndInit();
            this.panel_maxValueSales.ResumeLayout(false);
            this.panel_maxValueSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_maxValueCost.ResumeLayout(false);
            this.panel_maxValueCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTransaction0_family;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTransaction1_family;
        private System.Windows.Forms.ComboBox cmbbox_transaction_chart;
        private System.Windows.Forms.Button btnSearchThisDay;
        private System.Windows.Forms.Button btnSearchThisMonth;
        private System.Windows.Forms.Button btnSearchThisYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAllYearSearch;
        private System.Windows.Forms.CheckBox checkBoxAllYearSearch;
        private System.Windows.Forms.Panel panel_maxValueSales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_titleSearchMaxValuesSales;
        private System.Windows.Forms.Label label_maxValueSales_title;
        private System.Windows.Forms.Panel panel_maxValueCost;
        private System.Windows.Forms.Label label_titleSearchMaxValuesCost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_maxValueCost_title;
    }
}
