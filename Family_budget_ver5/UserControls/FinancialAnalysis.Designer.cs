namespace Family_budget_ver5.UserControls
{
    partial class FinancialAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialAnalysis));
            this.chartNameTypeMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonthLabel_base = new System.Windows.Forms.Label();
            this.panelTitleGrafs = new System.Windows.Forms.Panel();
            this.LabelTittleCostMonth = new System.Windows.Forms.Label();
            this.checkBoxTransaction = new System.Windows.Forms.CheckBox();
            this.comboBoxNameTypeFamily = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_MonthCost = new System.Windows.Forms.DateTimePicker();
            this.LabelCostMonth = new System.Windows.Forms.Label();
            this.panelGKX = new System.Windows.Forms.Panel();
            this.pictureBoxGkx = new System.Windows.Forms.PictureBox();
            this.labelCostGkx = new System.Windows.Forms.Label();
            this.labelTittleGkx = new System.Windows.Forms.Label();
            this.panelClothes = new System.Windows.Forms.Panel();
            this.pictureBoxClothes = new System.Windows.Forms.PictureBox();
            this.labelCostClothes = new System.Windows.Forms.Label();
            this.labelTittleClothes = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.labelCostCar = new System.Windows.Forms.Label();
            this.labelTittleCar = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panelOther = new System.Windows.Forms.Panel();
            this.labelCostOther = new System.Windows.Forms.Label();
            this.labelTittleOther = new System.Windows.Forms.Label();
            this.pictureBoxOther = new System.Windows.Forms.PictureBox();
            this.panelMedications = new System.Windows.Forms.Panel();
            this.labelCostMedications = new System.Windows.Forms.Label();
            this.labelTittleMedications = new System.Windows.Forms.Label();
            this.pictureBoxMedications = new System.Windows.Forms.PictureBox();
            this.panelSupermarket = new System.Windows.Forms.Panel();
            this.labelCostSupermarket = new System.Windows.Forms.Label();
            this.labelTittleSupermarket = new System.Windows.Forms.Label();
            this.pictureBoxSupermarket = new System.Windows.Forms.PictureBox();
            this.panelCostUp = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCostCostUp = new System.Windows.Forms.Label();
            this.labelTittleCostUp = new System.Windows.Forms.Label();
            this.panelCostDown = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCostCostDown = new System.Windows.Forms.Label();
            this.labelTittleCostDown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartNameTypeMonth)).BeginInit();
            this.panelTitleGrafs.SuspendLayout();
            this.panelGKX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGkx)).BeginInit();
            this.panelClothes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClothes)).BeginInit();
            this.panelCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.panelOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOther)).BeginInit();
            this.panelMedications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedications)).BeginInit();
            this.panelSupermarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupermarket)).BeginInit();
            this.panelCostUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCostDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartNameTypeMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNameTypeMonth.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartNameTypeMonth.Legends.Add(legend2);
            this.chartNameTypeMonth.Location = new System.Drawing.Point(633, 88);
            this.chartNameTypeMonth.Name = "chartNameTypeMonth";
            this.chartNameTypeMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "MonthNameCost";
            this.chartNameTypeMonth.Series.Add(series2);
            this.chartNameTypeMonth.Size = new System.Drawing.Size(400, 239);
            this.chartNameTypeMonth.TabIndex = 0;
            this.chartNameTypeMonth.Text = "chart1";
            // 
            // MonthLabel_base
            // 
            this.MonthLabel_base.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthLabel_base.AutoSize = true;
            this.MonthLabel_base.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MonthLabel_base.Location = new System.Drawing.Point(798, 197);
            this.MonthLabel_base.Name = "MonthLabel_base";
            this.MonthLabel_base.Size = new System.Drawing.Size(71, 23);
            this.MonthLabel_base.TabIndex = 1;
            this.MonthLabel_base.Text = "Month";
            // 
            // panelTitleGrafs
            // 
            this.panelTitleGrafs.Controls.Add(this.LabelTittleCostMonth);
            this.panelTitleGrafs.Controls.Add(this.checkBoxTransaction);
            this.panelTitleGrafs.Controls.Add(this.comboBoxNameTypeFamily);
            this.panelTitleGrafs.Controls.Add(this.dateTimePicker_MonthCost);
            this.panelTitleGrafs.Controls.Add(this.LabelCostMonth);
            this.panelTitleGrafs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleGrafs.Location = new System.Drawing.Point(0, 0);
            this.panelTitleGrafs.Name = "panelTitleGrafs";
            this.panelTitleGrafs.Size = new System.Drawing.Size(1393, 82);
            this.panelTitleGrafs.TabIndex = 2;
            // 
            // LabelTittleCostMonth
            // 
            this.LabelTittleCostMonth.AutoSize = true;
            this.LabelTittleCostMonth.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LabelTittleCostMonth.Location = new System.Drawing.Point(29, 17);
            this.LabelTittleCostMonth.Name = "LabelTittleCostMonth";
            this.LabelTittleCostMonth.Size = new System.Drawing.Size(162, 23);
            this.LabelTittleCostMonth.TabIndex = 4;
            this.LabelTittleCostMonth.Text = "Всего списано";
            // 
            // checkBoxTransaction
            // 
            this.checkBoxTransaction.AutoSize = true;
            this.checkBoxTransaction.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkBoxTransaction.Location = new System.Drawing.Point(774, 19);
            this.checkBoxTransaction.Name = "checkBoxTransaction";
            this.checkBoxTransaction.Size = new System.Drawing.Size(136, 27);
            this.checkBoxTransaction.TabIndex = 3;
            this.checkBoxTransaction.Text = "Списание";
            this.checkBoxTransaction.UseVisualStyleBackColor = true;
            this.checkBoxTransaction.CheckedChanged += new System.EventHandler(this.checkBoxTransaction_CheckedChanged);
            // 
            // comboBoxNameTypeFamily
            // 
            this.comboBoxNameTypeFamily.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.comboBoxNameTypeFamily.FormattingEnabled = true;
            this.comboBoxNameTypeFamily.Items.AddRange(new object[] {
            "Выберите члена семьи"});
            this.comboBoxNameTypeFamily.Location = new System.Drawing.Point(486, 17);
            this.comboBoxNameTypeFamily.Name = "comboBoxNameTypeFamily";
            this.comboBoxNameTypeFamily.Size = new System.Drawing.Size(282, 31);
            this.comboBoxNameTypeFamily.TabIndex = 2;
            this.comboBoxNameTypeFamily.Text = "Выберите члена семьи";
            this.comboBoxNameTypeFamily.TextChanged += new System.EventHandler(this.comboBoxNameTypeFamily_TextChanged);
            // 
            // dateTimePicker_MonthCost
            // 
            this.dateTimePicker_MonthCost.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker_MonthCost.Location = new System.Drawing.Point(230, 17);
            this.dateTimePicker_MonthCost.Name = "dateTimePicker_MonthCost";
            this.dateTimePicker_MonthCost.Size = new System.Drawing.Size(231, 32);
            this.dateTimePicker_MonthCost.TabIndex = 1;
            this.dateTimePicker_MonthCost.ValueChanged += new System.EventHandler(this.dateTimePicker_MonthCost_ValueChanged);
            // 
            // LabelCostMonth
            // 
            this.LabelCostMonth.AutoSize = true;
            this.LabelCostMonth.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LabelCostMonth.Location = new System.Drawing.Point(29, 40);
            this.LabelCostMonth.Name = "LabelCostMonth";
            this.LabelCostMonth.Size = new System.Drawing.Size(115, 23);
            this.LabelCostMonth.TabIndex = 0;
            this.LabelCostMonth.Text = "MonthCost";
            // 
            // panelGKX
            // 
            this.panelGKX.Controls.Add(this.pictureBoxGkx);
            this.panelGKX.Controls.Add(this.labelCostGkx);
            this.panelGKX.Controls.Add(this.labelTittleGkx);
            this.panelGKX.Location = new System.Drawing.Point(3, 88);
            this.panelGKX.Name = "panelGKX";
            this.panelGKX.Size = new System.Drawing.Size(200, 76);
            this.panelGKX.TabIndex = 3;
            // 
            // pictureBoxGkx
            // 
            this.pictureBoxGkx.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGkx.Image")));
            this.pictureBoxGkx.Location = new System.Drawing.Point(3, 13);
            this.pictureBoxGkx.Name = "pictureBoxGkx";
            this.pictureBoxGkx.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxGkx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGkx.TabIndex = 3;
            this.pictureBoxGkx.TabStop = false;
            // 
            // labelCostGkx
            // 
            this.labelCostGkx.AutoSize = true;
            this.labelCostGkx.Location = new System.Drawing.Point(78, 46);
            this.labelCostGkx.Name = "labelCostGkx";
            this.labelCostGkx.Size = new System.Drawing.Size(63, 16);
            this.labelCostGkx.TabIndex = 0;
            this.labelCostGkx.Text = "CostЖКX";
            // 
            // labelTittleGkx
            // 
            this.labelTittleGkx.AutoSize = true;
            this.labelTittleGkx.Location = new System.Drawing.Point(78, 13);
            this.labelTittleGkx.Name = "labelTittleGkx";
            this.labelTittleGkx.Size = new System.Drawing.Size(96, 16);
            this.labelTittleGkx.TabIndex = 0;
            this.labelTittleGkx.Text = "Всего за ЖКХ";
            // 
            // panelClothes
            // 
            this.panelClothes.Controls.Add(this.pictureBoxClothes);
            this.panelClothes.Controls.Add(this.labelCostClothes);
            this.panelClothes.Controls.Add(this.labelTittleClothes);
            this.panelClothes.Location = new System.Drawing.Point(209, 88);
            this.panelClothes.Name = "panelClothes";
            this.panelClothes.Size = new System.Drawing.Size(200, 76);
            this.panelClothes.TabIndex = 4;
            // 
            // pictureBoxClothes
            // 
            this.pictureBoxClothes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClothes.Image")));
            this.pictureBoxClothes.Location = new System.Drawing.Point(4, 13);
            this.pictureBoxClothes.Name = "pictureBoxClothes";
            this.pictureBoxClothes.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxClothes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClothes.TabIndex = 2;
            this.pictureBoxClothes.TabStop = false;
            // 
            // labelCostClothes
            // 
            this.labelCostClothes.AutoSize = true;
            this.labelCostClothes.Location = new System.Drawing.Point(79, 46);
            this.labelCostClothes.Name = "labelCostClothes";
            this.labelCostClothes.Size = new System.Drawing.Size(79, 16);
            this.labelCostClothes.TabIndex = 1;
            this.labelCostClothes.Text = "CostClothes";
            // 
            // labelTittleClothes
            // 
            this.labelTittleClothes.AutoSize = true;
            this.labelTittleClothes.Location = new System.Drawing.Point(79, 13);
            this.labelTittleClothes.Name = "labelTittleClothes";
            this.labelTittleClothes.Size = new System.Drawing.Size(118, 16);
            this.labelTittleClothes.TabIndex = 0;
            this.labelTittleClothes.Text = "Всего за Одежду";
            // 
            // panelCar
            // 
            this.panelCar.Controls.Add(this.labelCostCar);
            this.panelCar.Controls.Add(this.labelTittleCar);
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Location = new System.Drawing.Point(3, 170);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(200, 80);
            this.panelCar.TabIndex = 5;
            // 
            // labelCostCar
            // 
            this.labelCostCar.AutoSize = true;
            this.labelCostCar.Location = new System.Drawing.Point(78, 51);
            this.labelCostCar.Name = "labelCostCar";
            this.labelCostCar.Size = new System.Drawing.Size(55, 16);
            this.labelCostCar.TabIndex = 6;
            this.labelCostCar.Text = "CostCar";
            // 
            // labelTittleCar
            // 
            this.labelTittleCar.AutoSize = true;
            this.labelTittleCar.Location = new System.Drawing.Point(78, 17);
            this.labelTittleCar.Name = "labelTittleCar";
            this.labelTittleCar.Size = new System.Drawing.Size(99, 16);
            this.labelTittleCar.TabIndex = 5;
            this.labelTittleCar.Text = "Всего за Авто";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.Location = new System.Drawing.Point(3, 17);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 4;
            this.pictureBoxCar.TabStop = false;
            // 
            // panelOther
            // 
            this.panelOther.Controls.Add(this.labelCostOther);
            this.panelOther.Controls.Add(this.labelTittleOther);
            this.panelOther.Controls.Add(this.pictureBoxOther);
            this.panelOther.Location = new System.Drawing.Point(209, 170);
            this.panelOther.Name = "panelOther";
            this.panelOther.Size = new System.Drawing.Size(200, 80);
            this.panelOther.TabIndex = 6;
            // 
            // labelCostOther
            // 
            this.labelCostOther.AutoSize = true;
            this.labelCostOther.Location = new System.Drawing.Point(82, 49);
            this.labelCostOther.Name = "labelCostOther";
            this.labelCostOther.Size = new System.Drawing.Size(66, 16);
            this.labelCostOther.TabIndex = 7;
            this.labelCostOther.Text = "CostOther";
            // 
            // labelTittleOther
            // 
            this.labelTittleOther.AutoSize = true;
            this.labelTittleOther.Location = new System.Drawing.Point(82, 16);
            this.labelTittleOther.Name = "labelTittleOther";
            this.labelTittleOther.Size = new System.Drawing.Size(115, 16);
            this.labelTittleOther.TabIndex = 6;
            this.labelTittleOther.Text = "Всего за прочее";
            // 
            // pictureBoxOther
            // 
            this.pictureBoxOther.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOther.Image")));
            this.pictureBoxOther.Location = new System.Drawing.Point(4, 17);
            this.pictureBoxOther.Name = "pictureBoxOther";
            this.pictureBoxOther.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxOther.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOther.TabIndex = 5;
            this.pictureBoxOther.TabStop = false;
            // 
            // panelMedications
            // 
            this.panelMedications.Controls.Add(this.labelCostMedications);
            this.panelMedications.Controls.Add(this.labelTittleMedications);
            this.panelMedications.Controls.Add(this.pictureBoxMedications);
            this.panelMedications.Location = new System.Drawing.Point(415, 88);
            this.panelMedications.Name = "panelMedications";
            this.panelMedications.Size = new System.Drawing.Size(215, 76);
            this.panelMedications.TabIndex = 4;
            // 
            // labelCostMedications
            // 
            this.labelCostMedications.AutoSize = true;
            this.labelCostMedications.Location = new System.Drawing.Point(79, 45);
            this.labelCostMedications.Name = "labelCostMedications";
            this.labelCostMedications.Size = new System.Drawing.Size(107, 16);
            this.labelCostMedications.TabIndex = 4;
            this.labelCostMedications.Text = "CostMedications";
            // 
            // labelTittleMedications
            // 
            this.labelTittleMedications.AutoSize = true;
            this.labelTittleMedications.Location = new System.Drawing.Point(75, 13);
            this.labelTittleMedications.Name = "labelTittleMedications";
            this.labelTittleMedications.Size = new System.Drawing.Size(137, 16);
            this.labelTittleMedications.TabIndex = 3;
            this.labelTittleMedications.Text = "Всего за Лекарства";
            // 
            // pictureBoxMedications
            // 
            this.pictureBoxMedications.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMedications.Image")));
            this.pictureBoxMedications.Location = new System.Drawing.Point(3, 13);
            this.pictureBoxMedications.Name = "pictureBoxMedications";
            this.pictureBoxMedications.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxMedications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedications.TabIndex = 3;
            this.pictureBoxMedications.TabStop = false;
            // 
            // panelSupermarket
            // 
            this.panelSupermarket.Controls.Add(this.labelCostSupermarket);
            this.panelSupermarket.Controls.Add(this.labelTittleSupermarket);
            this.panelSupermarket.Controls.Add(this.pictureBoxSupermarket);
            this.panelSupermarket.Location = new System.Drawing.Point(415, 170);
            this.panelSupermarket.Name = "panelSupermarket";
            this.panelSupermarket.Size = new System.Drawing.Size(215, 80);
            this.panelSupermarket.TabIndex = 4;
            // 
            // labelCostSupermarket
            // 
            this.labelCostSupermarket.AutoSize = true;
            this.labelCostSupermarket.Location = new System.Drawing.Point(82, 50);
            this.labelCostSupermarket.Name = "labelCostSupermarket";
            this.labelCostSupermarket.Size = new System.Drawing.Size(111, 16);
            this.labelCostSupermarket.TabIndex = 7;
            this.labelCostSupermarket.Text = "CostSupermarket";
            // 
            // labelTittleSupermarket
            // 
            this.labelTittleSupermarket.AutoSize = true;
            this.labelTittleSupermarket.Location = new System.Drawing.Point(79, 17);
            this.labelTittleSupermarket.Name = "labelTittleSupermarket";
            this.labelTittleSupermarket.Size = new System.Drawing.Size(133, 16);
            this.labelTittleSupermarket.TabIndex = 6;
            this.labelTittleSupermarket.Text = "Всего за Магазины";
            // 
            // pictureBoxSupermarket
            // 
            this.pictureBoxSupermarket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSupermarket.Image")));
            this.pictureBoxSupermarket.Location = new System.Drawing.Point(3, 17);
            this.pictureBoxSupermarket.Name = "pictureBoxSupermarket";
            this.pictureBoxSupermarket.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxSupermarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSupermarket.TabIndex = 6;
            this.pictureBoxSupermarket.TabStop = false;
            // 
            // panelCostUp
            // 
            this.panelCostUp.Controls.Add(this.pictureBox1);
            this.panelCostUp.Controls.Add(this.labelCostCostUp);
            this.panelCostUp.Controls.Add(this.labelTittleCostUp);
            this.panelCostUp.Location = new System.Drawing.Point(3, 252);
            this.panelCostUp.Name = "panelCostUp";
            this.panelCostUp.Size = new System.Drawing.Size(200, 80);
            this.panelCostUp.TabIndex = 4;
            this.panelCostUp.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelCostCostUp
            // 
            this.labelCostCostUp.AutoSize = true;
            this.labelCostCostUp.Location = new System.Drawing.Point(78, 46);
            this.labelCostCostUp.Name = "labelCostCostUp";
            this.labelCostCostUp.Size = new System.Drawing.Size(52, 16);
            this.labelCostCostUp.TabIndex = 0;
            this.labelCostCostUp.Text = "CostUp";
            // 
            // labelTittleCostUp
            // 
            this.labelTittleCostUp.AutoSize = true;
            this.labelTittleCostUp.Location = new System.Drawing.Point(78, 13);
            this.labelTittleCostUp.Name = "labelTittleCostUp";
            this.labelTittleCostUp.Size = new System.Drawing.Size(71, 16);
            this.labelTittleCostUp.TabIndex = 0;
            this.labelTittleCostUp.Text = "Зарплата";
            // 
            // panelCostDown
            // 
            this.panelCostDown.Controls.Add(this.pictureBox2);
            this.panelCostDown.Controls.Add(this.labelCostCostDown);
            this.panelCostDown.Controls.Add(this.labelTittleCostDown);
            this.panelCostDown.Location = new System.Drawing.Point(209, 256);
            this.panelCostDown.Name = "panelCostDown";
            this.panelCostDown.Size = new System.Drawing.Size(200, 76);
            this.panelCostDown.TabIndex = 4;
            this.panelCostDown.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelCostCostDown
            // 
            this.labelCostCostDown.AutoSize = true;
            this.labelCostCostDown.Location = new System.Drawing.Point(78, 46);
            this.labelCostCostDown.Name = "labelCostCostDown";
            this.labelCostCostDown.Size = new System.Drawing.Size(68, 16);
            this.labelCostCostDown.TabIndex = 0;
            this.labelCostCostDown.Text = "CostDown";
            // 
            // labelTittleCostDown
            // 
            this.labelTittleCostDown.AutoSize = true;
            this.labelTittleCostDown.Location = new System.Drawing.Point(78, 13);
            this.labelTittleCostDown.Name = "labelTittleCostDown";
            this.labelTittleCostDown.Size = new System.Drawing.Size(55, 16);
            this.labelTittleCostDown.TabIndex = 0;
            this.labelTittleCostDown.Text = "Пенсия";
            // 
            // FinancialAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCostDown);
            this.Controls.Add(this.panelCostUp);
            this.Controls.Add(this.panelSupermarket);
            this.Controls.Add(this.panelMedications);
            this.Controls.Add(this.panelOther);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.panelClothes);
            this.Controls.Add(this.panelGKX);
            this.Controls.Add(this.panelTitleGrafs);
            this.Controls.Add(this.MonthLabel_base);
            this.Controls.Add(this.chartNameTypeMonth);
            this.Name = "FinancialAnalysis";
            this.Size = new System.Drawing.Size(1393, 656);
            ((System.ComponentModel.ISupportInitialize)(this.chartNameTypeMonth)).EndInit();
            this.panelTitleGrafs.ResumeLayout(false);
            this.panelTitleGrafs.PerformLayout();
            this.panelGKX.ResumeLayout(false);
            this.panelGKX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGkx)).EndInit();
            this.panelClothes.ResumeLayout(false);
            this.panelClothes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClothes)).EndInit();
            this.panelCar.ResumeLayout(false);
            this.panelCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.panelOther.ResumeLayout(false);
            this.panelOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOther)).EndInit();
            this.panelMedications.ResumeLayout(false);
            this.panelMedications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedications)).EndInit();
            this.panelSupermarket.ResumeLayout(false);
            this.panelSupermarket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSupermarket)).EndInit();
            this.panelCostUp.ResumeLayout(false);
            this.panelCostUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCostDown.ResumeLayout(false);
            this.panelCostDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartNameTypeMonth;
        private System.Windows.Forms.Label MonthLabel_base;
        private System.Windows.Forms.Panel panelTitleGrafs;
        private System.Windows.Forms.Label LabelCostMonth;
        private System.Windows.Forms.CheckBox checkBoxTransaction;
        private System.Windows.Forms.ComboBox comboBoxNameTypeFamily;
        private System.Windows.Forms.DateTimePicker dateTimePicker_MonthCost;
        private System.Windows.Forms.Panel panelGKX;
        private System.Windows.Forms.Panel panelClothes;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Panel panelOther;
        private System.Windows.Forms.Panel panelMedications;
        private System.Windows.Forms.Panel panelSupermarket;
        private System.Windows.Forms.Label labelCostGkx;
        private System.Windows.Forms.Label labelTittleGkx;
        private System.Windows.Forms.PictureBox pictureBoxGkx;
        private System.Windows.Forms.PictureBox pictureBoxClothes;
        private System.Windows.Forms.Label labelCostClothes;
        private System.Windows.Forms.Label labelTittleClothes;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.PictureBox pictureBoxOther;
        private System.Windows.Forms.Label labelTittleMedications;
        private System.Windows.Forms.PictureBox pictureBoxMedications;
        private System.Windows.Forms.PictureBox pictureBoxSupermarket;
        private System.Windows.Forms.Label labelCostCar;
        private System.Windows.Forms.Label labelTittleCar;
        private System.Windows.Forms.Label labelCostMedications;
        private System.Windows.Forms.Label labelTittleSupermarket;
        private System.Windows.Forms.Label labelCostOther;
        private System.Windows.Forms.Label labelTittleOther;
        private System.Windows.Forms.Label labelCostSupermarket;
        private System.Windows.Forms.Label LabelTittleCostMonth;
        private System.Windows.Forms.Panel panelCostUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCostCostUp;
        private System.Windows.Forms.Label labelTittleCostUp;
        private System.Windows.Forms.Panel panelCostDown;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelCostCostDown;
        private System.Windows.Forms.Label labelTittleCostDown;
    }
}
