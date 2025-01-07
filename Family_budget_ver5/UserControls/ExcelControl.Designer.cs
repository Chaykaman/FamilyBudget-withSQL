namespace Family_budget_ver5.UserControls
{
    partial class ExcelControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelControl));
            this.dgv_FromSelect = new System.Windows.Forms.DataGridView();
            this.NameCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTypeFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.lblTittle_filter = new System.Windows.Forms.Label();
            this.lblTittle_Date = new System.Windows.Forms.Label();
            this.dateTimePicker_First = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Last = new System.Windows.Forms.DateTimePicker();
            this.txtbox_Search = new System.Windows.Forms.TextBox();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.panelSearchDate = new System.Windows.Forms.Panel();
            this.checkboxBoolSearchDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FromSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            this.panelSearchDate.SuspendLayout();
            this.SuspendLayout();
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
            this.NameCost,
            this.NameTypeFamily,
            this.PriceCost,
            this.DateCost});
            this.dgv_FromSelect.Location = new System.Drawing.Point(425, 14);
            this.dgv_FromSelect.Name = "dgv_FromSelect";
            this.dgv_FromSelect.ReadOnly = true;
            this.dgv_FromSelect.RowHeadersWidth = 51;
            this.dgv_FromSelect.RowTemplate.Height = 24;
            this.dgv_FromSelect.Size = new System.Drawing.Size(678, 508);
            this.dgv_FromSelect.TabIndex = 16;
            // 
            // NameCost
            // 
            this.NameCost.DataPropertyName = "NameCost";
            this.NameCost.HeaderText = "Наименование Расхода";
            this.NameCost.MinimumWidth = 6;
            this.NameCost.Name = "NameCost";
            this.NameCost.ReadOnly = true;
            // 
            // NameTypeFamily
            // 
            this.NameTypeFamily.DataPropertyName = "NameTypeFamily";
            this.NameTypeFamily.HeaderText = "Потребитель";
            this.NameTypeFamily.MinimumWidth = 6;
            this.NameTypeFamily.Name = "NameTypeFamily";
            this.NameTypeFamily.ReadOnly = true;
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
            // btn_Excel
            // 
            this.btn_Excel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_Excel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Excel.Location = new System.Drawing.Point(238, 53);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(144, 37);
            this.btn_Excel.TabIndex = 22;
            this.btn_Excel.Text = "Распечатать";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // cmb_filter
            // 
            this.cmb_filter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cmb_filter.Items.AddRange(new object[] {
            "Общей базе",
            "Списанию",
            "Зачислению"});
            this.cmb_filter.Location = new System.Drawing.Point(171, 16);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(211, 31);
            this.cmb_filter.TabIndex = 28;
            this.cmb_filter.Text = "Общей базе";
            this.cmb_filter.TextChanged += new System.EventHandler(this.cmb_filter_TextChanged);
            // 
            // lblTittle_filter
            // 
            this.lblTittle_filter.AutoSize = true;
            this.lblTittle_filter.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTittle_filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTittle_filter.Location = new System.Drawing.Point(27, 19);
            this.lblTittle_filter.Name = "lblTittle_filter";
            this.lblTittle_filter.Size = new System.Drawing.Size(138, 23);
            this.lblTittle_filter.TabIndex = 29;
            this.lblTittle_filter.Text = "Выберите по";
            // 
            // lblTittle_Date
            // 
            this.lblTittle_Date.AutoSize = true;
            this.lblTittle_Date.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTittle_Date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTittle_Date.Location = new System.Drawing.Point(22, 13);
            this.lblTittle_Date.Name = "lblTittle_Date";
            this.lblTittle_Date.Size = new System.Drawing.Size(61, 23);
            this.lblTittle_Date.TabIndex = 30;
            this.lblTittle_Date.Text = "Дата";
            // 
            // dateTimePicker_First
            // 
            this.dateTimePicker_First.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker_First.Location = new System.Drawing.Point(57, 39);
            this.dateTimePicker_First.Name = "dateTimePicker_First";
            this.dateTimePicker_First.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_First.TabIndex = 31;
            // 
            // dateTimePicker_Last
            // 
            this.dateTimePicker_Last.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateTimePicker_Last.Location = new System.Drawing.Point(57, 77);
            this.dateTimePicker_Last.Name = "dateTimePicker_Last";
            this.dateTimePicker_Last.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_Last.TabIndex = 32;
            // 
            // txtbox_Search
            // 
            this.txtbox_Search.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbox_Search.Location = new System.Drawing.Point(31, 96);
            this.txtbox_Search.Name = "txtbox_Search";
            this.txtbox_Search.Size = new System.Drawing.Size(311, 32);
            this.txtbox_Search.TabIndex = 33;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(348, 96);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(34, 32);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 34;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSearchDate.Location = new System.Drawing.Point(72, 125);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(185, 29);
            this.btnSearchDate.TabIndex = 36;
            this.btnSearchDate.Text = "Найти по дате";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // panelSearchDate
            // 
            this.panelSearchDate.Controls.Add(this.dateTimePicker_Last);
            this.panelSearchDate.Controls.Add(this.lblTittle_Date);
            this.panelSearchDate.Controls.Add(this.btnSearchDate);
            this.panelSearchDate.Controls.Add(this.dateTimePicker_First);
            this.panelSearchDate.Location = new System.Drawing.Point(31, 144);
            this.panelSearchDate.Name = "panelSearchDate";
            this.panelSearchDate.Size = new System.Drawing.Size(320, 194);
            this.panelSearchDate.TabIndex = 38;
            this.panelSearchDate.Visible = false;
            // 
            // checkboxBoolSearchDate
            // 
            this.checkboxBoolSearchDate.AutoSize = true;
            this.checkboxBoolSearchDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.checkboxBoolSearchDate.Location = new System.Drawing.Point(31, 59);
            this.checkboxBoolSearchDate.Name = "checkboxBoolSearchDate";
            this.checkboxBoolSearchDate.Size = new System.Drawing.Size(178, 27);
            this.checkboxBoolSearchDate.TabIndex = 39;
            this.checkboxBoolSearchDate.Text = "Поиск по дате";
            this.checkboxBoolSearchDate.UseVisualStyleBackColor = true;
            this.checkboxBoolSearchDate.CheckedChanged += new System.EventHandler(this.checkboxBoolSearchDate_CheckedChanged);
            // 
            // ExcelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkboxBoolSearchDate);
            this.Controls.Add(this.panelSearchDate);
            this.Controls.Add(this.txtbox_Search);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.lblTittle_filter);
            this.Controls.Add(this.cmb_filter);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.dgv_FromSelect);
            this.Name = "ExcelControl";
            this.Size = new System.Drawing.Size(1393, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FromSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            this.panelSearchDate.ResumeLayout(false);
            this.panelSearchDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FromSelect;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Label lblTittle_filter;
        private System.Windows.Forms.Label lblTittle_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_First;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Last;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTypeFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCost;
        private System.Windows.Forms.TextBox txtbox_Search;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Panel panelSearchDate;
        private System.Windows.Forms.CheckBox checkboxBoolSearchDate;
    }
}
