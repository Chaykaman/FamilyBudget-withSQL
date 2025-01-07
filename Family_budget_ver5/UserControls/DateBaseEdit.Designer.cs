namespace Family_budget_ver5.UserControls
{
    partial class DateBaseEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateBaseEdit));
            this.paneldatagridMenu = new System.Windows.Forms.Panel();
            this.checkBox_SearchDate = new System.Windows.Forms.CheckBox();
            this.dgv_FromSelect = new System.Windows.Forms.DataGridView();
            this.idDataFamilyBudget_db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTypeFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbox_Search = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.combobox_TypeCost = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DateCost = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateCost = new System.Windows.Forms.Label();
            this.txtbox_PriceCost = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_PriceCost = new System.Windows.Forms.Label();
            this.lbl_NameCost = new System.Windows.Forms.Label();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.lbl_NameTypeFamily = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lbl_TypeCost = new System.Windows.Forms.Label();
            this.txtbox_idDataFamilyBudget_db = new System.Windows.Forms.TextBox();
            this.pannel_editdate = new System.Windows.Forms.Panel();
            this.txtbox_NameTypeFamily = new System.Windows.Forms.ComboBox();
            this.txtbox_NameCost = new System.Windows.Forms.ComboBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.panel_Search_Date = new System.Windows.Forms.Panel();
            this.btn_SearchDate_Sql = new System.Windows.Forms.Button();
            this.dateTimePicker_todate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fromdate = new System.Windows.Forms.DateTimePicker();
            this.paneldatagridMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FromSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.pannel_editdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            this.panel_Search_Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldatagridMenu
            // 
            this.paneldatagridMenu.Controls.Add(this.checkBox_SearchDate);
            this.paneldatagridMenu.Controls.Add(this.dgv_FromSelect);
            this.paneldatagridMenu.Controls.Add(this.txtbox_Search);
            this.paneldatagridMenu.Controls.Add(this.pictureBoxSearch);
            this.paneldatagridMenu.Location = new System.Drawing.Point(392, 11);
            this.paneldatagridMenu.Name = "paneldatagridMenu";
            this.paneldatagridMenu.Size = new System.Drawing.Size(991, 617);
            this.paneldatagridMenu.TabIndex = 27;
            // 
            // checkBox_SearchDate
            // 
            this.checkBox_SearchDate.AutoSize = true;
            this.checkBox_SearchDate.Location = new System.Drawing.Point(21, 15);
            this.checkBox_SearchDate.Name = "checkBox_SearchDate";
            this.checkBox_SearchDate.Size = new System.Drawing.Size(178, 27);
            this.checkBox_SearchDate.TabIndex = 25;
            this.checkBox_SearchDate.Text = "Поиск по дате";
            this.checkBox_SearchDate.UseVisualStyleBackColor = true;
            this.checkBox_SearchDate.CheckedChanged += new System.EventHandler(this.checkBox_SearchDate_CheckedChanged);
            // 
            // dgv_FromSelect
            // 
            this.dgv_FromSelect.AllowUserToAddRows = false;
            this.dgv_FromSelect.AllowUserToDeleteRows = false;
            this.dgv_FromSelect.AllowUserToResizeColumns = false;
            this.dgv_FromSelect.AllowUserToResizeRows = false;
            this.dgv_FromSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_FromSelect.BackgroundColor = System.Drawing.Color.White;
            this.dgv_FromSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_FromSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FromSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataFamilyBudget_db,
            this.TypeCost,
            this.NameTypeFamily,
            this.NameCost,
            this.PriceCost,
            this.DateCost});
            this.dgv_FromSelect.Location = new System.Drawing.Point(3, 73);
            this.dgv_FromSelect.Name = "dgv_FromSelect";
            this.dgv_FromSelect.ReadOnly = true;
            this.dgv_FromSelect.RowHeadersWidth = 51;
            this.dgv_FromSelect.RowTemplate.Height = 24;
            this.dgv_FromSelect.Size = new System.Drawing.Size(972, 540);
            this.dgv_FromSelect.TabIndex = 15;
            this.dgv_FromSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FromSelect_CellClick);
            // 
            // idDataFamilyBudget_db
            // 
            this.idDataFamilyBudget_db.DataPropertyName = "idDataFamilyBudget_db";
            this.idDataFamilyBudget_db.HeaderText = "ID";
            this.idDataFamilyBudget_db.MinimumWidth = 6;
            this.idDataFamilyBudget_db.Name = "idDataFamilyBudget_db";
            this.idDataFamilyBudget_db.ReadOnly = true;
            // 
            // TypeCost
            // 
            this.TypeCost.DataPropertyName = "TypeCost";
            this.TypeCost.HeaderText = "Тип Транзакции";
            this.TypeCost.MinimumWidth = 6;
            this.TypeCost.Name = "TypeCost";
            this.TypeCost.ReadOnly = true;
            // 
            // NameTypeFamily
            // 
            this.NameTypeFamily.DataPropertyName = "NameTypeFamily";
            this.NameTypeFamily.HeaderText = "Потребитель";
            this.NameTypeFamily.MinimumWidth = 6;
            this.NameTypeFamily.Name = "NameTypeFamily";
            this.NameTypeFamily.ReadOnly = true;
            // 
            // NameCost
            // 
            this.NameCost.DataPropertyName = "NameCost";
            this.NameCost.HeaderText = "Наименование Расхода";
            this.NameCost.MinimumWidth = 6;
            this.NameCost.Name = "NameCost";
            this.NameCost.ReadOnly = true;
            // 
            // PriceCost
            // 
            this.PriceCost.DataPropertyName = "PriceCost";
            this.PriceCost.HeaderText = "Сумма";
            this.PriceCost.MinimumWidth = 6;
            this.PriceCost.Name = "PriceCost";
            this.PriceCost.ReadOnly = true;
            // 
            // DateCost
            // 
            this.DateCost.DataPropertyName = "DateCost";
            this.DateCost.HeaderText = "Дата Транзакции";
            this.DateCost.MinimumWidth = 6;
            this.DateCost.Name = "DateCost";
            this.DateCost.ReadOnly = true;
            // 
            // txtbox_Search
            // 
            this.txtbox_Search.Location = new System.Drawing.Point(578, 13);
            this.txtbox_Search.Name = "txtbox_Search";
            this.txtbox_Search.Size = new System.Drawing.Size(320, 32);
            this.txtbox_Search.TabIndex = 19;
            this.txtbox_Search.TextChanged += new System.EventHandler(this.txtbox_Search_TextChanged);
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(904, 3);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(38, 48);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 20;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // combobox_TypeCost
            // 
            this.combobox_TypeCost.BackColor = System.Drawing.Color.White;
            this.combobox_TypeCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_TypeCost.FormattingEnabled = true;
            this.combobox_TypeCost.Items.AddRange(new object[] {
            "Списание",
            "Зачисление"});
            this.combobox_TypeCost.Location = new System.Drawing.Point(32, 203);
            this.combobox_TypeCost.Name = "combobox_TypeCost";
            this.combobox_TypeCost.Size = new System.Drawing.Size(283, 31);
            this.combobox_TypeCost.TabIndex = 14;
            // 
            // dateTimePicker_DateCost
            // 
            this.dateTimePicker_DateCost.CalendarMonthBackground = System.Drawing.Color.Gold;
            this.dateTimePicker_DateCost.Location = new System.Drawing.Point(32, 482);
            this.dateTimePicker_DateCost.Name = "dateTimePicker_DateCost";
            this.dateTimePicker_DateCost.Size = new System.Drawing.Size(283, 32);
            this.dateTimePicker_DateCost.TabIndex = 11;
            // 
            // lbl_DateCost
            // 
            this.lbl_DateCost.AutoSize = true;
            this.lbl_DateCost.Location = new System.Drawing.Point(23, 442);
            this.lbl_DateCost.Name = "lbl_DateCost";
            this.lbl_DateCost.Size = new System.Drawing.Size(184, 23);
            this.lbl_DateCost.TabIndex = 10;
            this.lbl_DateCost.Text = "Дата Транзакции";
            // 
            // txtbox_PriceCost
            // 
            this.txtbox_PriceCost.BackColor = System.Drawing.Color.White;
            this.txtbox_PriceCost.Location = new System.Drawing.Point(32, 407);
            this.txtbox_PriceCost.Name = "txtbox_PriceCost";
            this.txtbox_PriceCost.Size = new System.Drawing.Size(283, 32);
            this.txtbox_PriceCost.TabIndex = 9;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(21, 576);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(144, 37);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_PriceCost
            // 
            this.lbl_PriceCost.AutoSize = true;
            this.lbl_PriceCost.Location = new System.Drawing.Point(16, 376);
            this.lbl_PriceCost.Name = "lbl_PriceCost";
            this.lbl_PriceCost.Size = new System.Drawing.Size(87, 23);
            this.lbl_PriceCost.TabIndex = 8;
            this.lbl_PriceCost.Text = "Сумма";
            // 
            // lbl_NameCost
            // 
            this.lbl_NameCost.AutoSize = true;
            this.lbl_NameCost.Location = new System.Drawing.Point(16, 308);
            this.lbl_NameCost.Name = "lbl_NameCost";
            this.lbl_NameCost.Size = new System.Drawing.Size(260, 23);
            this.lbl_NameCost.TabIndex = 6;
            this.lbl_NameCost.Text = "Наименование Расхода";
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(171, 576);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(144, 37);
            this.btn_Excel.TabIndex = 21;
            this.btn_Excel.Text = "Распечатать";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Visible = false;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // lbl_NameTypeFamily
            // 
            this.lbl_NameTypeFamily.AutoSize = true;
            this.lbl_NameTypeFamily.Location = new System.Drawing.Point(16, 240);
            this.lbl_NameTypeFamily.Name = "lbl_NameTypeFamily";
            this.lbl_NameTypeFamily.Size = new System.Drawing.Size(131, 23);
            this.lbl_NameTypeFamily.TabIndex = 4;
            this.lbl_NameTypeFamily.Text = "Член Семьи";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(16, 108);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(153, 23);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "ID Транзакции";
            // 
            // lbl_TypeCost
            // 
            this.lbl_TypeCost.AutoSize = true;
            this.lbl_TypeCost.Location = new System.Drawing.Point(16, 172);
            this.lbl_TypeCost.Name = "lbl_TypeCost";
            this.lbl_TypeCost.Size = new System.Drawing.Size(165, 23);
            this.lbl_TypeCost.TabIndex = 2;
            this.lbl_TypeCost.Text = "Тип Транзакции";
            // 
            // txtbox_idDataFamilyBudget_db
            // 
            this.txtbox_idDataFamilyBudget_db.BackColor = System.Drawing.Color.White;
            this.txtbox_idDataFamilyBudget_db.Location = new System.Drawing.Point(32, 140);
            this.txtbox_idDataFamilyBudget_db.Name = "txtbox_idDataFamilyBudget_db";
            this.txtbox_idDataFamilyBudget_db.ReadOnly = true;
            this.txtbox_idDataFamilyBudget_db.Size = new System.Drawing.Size(283, 32);
            this.txtbox_idDataFamilyBudget_db.TabIndex = 23;
            // 
            // pannel_editdate
            // 
            this.pannel_editdate.Controls.Add(this.txtbox_NameTypeFamily);
            this.pannel_editdate.Controls.Add(this.txtbox_NameCost);
            this.pannel_editdate.Controls.Add(this.pictureBoxTitle);
            this.pannel_editdate.Controls.Add(this.txtbox_idDataFamilyBudget_db);
            this.pannel_editdate.Controls.Add(this.lbl_TypeCost);
            this.pannel_editdate.Controls.Add(this.lblID);
            this.pannel_editdate.Controls.Add(this.lbl_NameTypeFamily);
            this.pannel_editdate.Controls.Add(this.btn_Excel);
            this.pannel_editdate.Controls.Add(this.lbl_NameCost);
            this.pannel_editdate.Controls.Add(this.btn_Change);
            this.pannel_editdate.Controls.Add(this.lbl_PriceCost);
            this.pannel_editdate.Controls.Add(this.btn_Delete);
            this.pannel_editdate.Controls.Add(this.txtbox_PriceCost);
            this.pannel_editdate.Controls.Add(this.btn_Add);
            this.pannel_editdate.Controls.Add(this.lbl_DateCost);
            this.pannel_editdate.Controls.Add(this.dateTimePicker_DateCost);
            this.pannel_editdate.Controls.Add(this.combobox_TypeCost);
            this.pannel_editdate.Location = new System.Drawing.Point(18, 11);
            this.pannel_editdate.Name = "pannel_editdate";
            this.pannel_editdate.Size = new System.Drawing.Size(329, 617);
            this.pannel_editdate.TabIndex = 25;
            // 
            // txtbox_NameTypeFamily
            // 
            this.txtbox_NameTypeFamily.BackColor = System.Drawing.Color.White;
            this.txtbox_NameTypeFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbox_NameTypeFamily.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbox_NameTypeFamily.FormattingEnabled = true;
            this.txtbox_NameTypeFamily.Items.AddRange(new object[] {
            "Выбери члена семьи"});
            this.txtbox_NameTypeFamily.Location = new System.Drawing.Point(32, 266);
            this.txtbox_NameTypeFamily.Name = "txtbox_NameTypeFamily";
            this.txtbox_NameTypeFamily.Size = new System.Drawing.Size(283, 31);
            this.txtbox_NameTypeFamily.TabIndex = 27;
            // 
            // txtbox_NameCost
            // 
            this.txtbox_NameCost.BackColor = System.Drawing.Color.White;
            this.txtbox_NameCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbox_NameCost.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbox_NameCost.FormattingEnabled = true;
            this.txtbox_NameCost.Items.AddRange(new object[] {
            "Выберите наименование расхода",
            "Пенсия",
            "Зарплата",
            "Одежда",
            "Супермаркет",
            "Автомобиль",
            "Лекарства",
            "ЖКХ",
            "Прочее"});
            this.txtbox_NameCost.Location = new System.Drawing.Point(32, 334);
            this.txtbox_NameCost.Name = "txtbox_NameCost";
            this.txtbox_NameCost.Size = new System.Drawing.Size(283, 31);
            this.txtbox_NameCost.TabIndex = 26;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTitle.Image")));
            this.pictureBoxTitle.Location = new System.Drawing.Point(114, 30);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(93, 75);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 13;
            this.pictureBoxTitle.TabStop = false;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(171, 533);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(144, 37);
            this.btn_Change.TabIndex = 18;
            this.btn_Change.Text = "Изменить";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(21, 533);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(144, 37);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // panel_Search_Date
            // 
            this.panel_Search_Date.Controls.Add(this.btn_SearchDate_Sql);
            this.panel_Search_Date.Controls.Add(this.dateTimePicker_todate);
            this.panel_Search_Date.Controls.Add(this.dateTimePicker_fromdate);
            this.panel_Search_Date.Location = new System.Drawing.Point(18, 11);
            this.panel_Search_Date.Name = "panel_Search_Date";
            this.panel_Search_Date.Size = new System.Drawing.Size(326, 195);
            this.panel_Search_Date.TabIndex = 25;
            this.panel_Search_Date.Visible = false;
            // 
            // btn_SearchDate_Sql
            // 
            this.btn_SearchDate_Sql.Location = new System.Drawing.Point(107, 140);
            this.btn_SearchDate_Sql.Name = "btn_SearchDate_Sql";
            this.btn_SearchDate_Sql.Size = new System.Drawing.Size(100, 38);
            this.btn_SearchDate_Sql.TabIndex = 2;
            this.btn_SearchDate_Sql.Text = "Поиск по дате";
            this.btn_SearchDate_Sql.UseVisualStyleBackColor = true;
            this.btn_SearchDate_Sql.Click += new System.EventHandler(this.btn_SearchDate_Sql_Click);
            // 
            // dateTimePicker_todate
            // 
            this.dateTimePicker_todate.Location = new System.Drawing.Point(39, 78);
            this.dateTimePicker_todate.Name = "dateTimePicker_todate";
            this.dateTimePicker_todate.Size = new System.Drawing.Size(240, 32);
            this.dateTimePicker_todate.TabIndex = 1;
            // 
            // dateTimePicker_fromdate
            // 
            this.dateTimePicker_fromdate.Location = new System.Drawing.Point(39, 38);
            this.dateTimePicker_fromdate.Name = "dateTimePicker_fromdate";
            this.dateTimePicker_fromdate.Size = new System.Drawing.Size(240, 32);
            this.dateTimePicker_fromdate.TabIndex = 0;
            // 
            // DateBaseEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.paneldatagridMenu);
            this.Controls.Add(this.pannel_editdate);
            this.Controls.Add(this.panel_Search_Date);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DateBaseEdit";
            this.Size = new System.Drawing.Size(1393, 656);
            this.paneldatagridMenu.ResumeLayout(false);
            this.paneldatagridMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FromSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.pannel_editdate.ResumeLayout(false);
            this.pannel_editdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            this.panel_Search_Date.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneldatagridMenu;
        private System.Windows.Forms.DataGridView dgv_FromSelect;
        private System.Windows.Forms.TextBox txtbox_Search;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.ComboBox combobox_TypeCost;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateCost;
        private System.Windows.Forms.Label lbl_DateCost;
        private System.Windows.Forms.TextBox txtbox_PriceCost;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_PriceCost;
        private System.Windows.Forms.Label lbl_NameCost;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Label lbl_NameTypeFamily;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbl_TypeCost;
        private System.Windows.Forms.TextBox txtbox_idDataFamilyBudget_db;
        private System.Windows.Forms.Panel pannel_editdate;
        private System.Windows.Forms.Panel panel_Search_Date;
        private System.Windows.Forms.Button btn_SearchDate_Sql;
        private System.Windows.Forms.DateTimePicker dateTimePicker_todate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fromdate;
        private System.Windows.Forms.CheckBox checkBox_SearchDate;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox txtbox_NameCost;
        private System.Windows.Forms.ComboBox txtbox_NameTypeFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataFamilyBudget_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTypeFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCost;
    }
}
