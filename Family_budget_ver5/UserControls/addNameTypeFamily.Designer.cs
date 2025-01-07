namespace Family_budget_ver5.UserControls
{
    partial class addNameTypeFamily
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
            this.dgv_FromSelect = new System.Windows.Forms.DataGridView();
            this.txtBoxAdd_NameTypeFamily = new System.Windows.Forms.TextBox();
            this.btnAddNameTypeFamily = new System.Windows.Forms.Button();
            this.txtboxAnVisibleIDNameTypeFamily = new System.Windows.Forms.TextBox();
            this.btnUpdateNameCost = new System.Windows.Forms.Button();
            this.idDataFamilyBudget_db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FromSelect)).BeginInit();
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
            this.idDataFamilyBudget_db,
            this.DateCost});
            this.dgv_FromSelect.Location = new System.Drawing.Point(413, 18);
            this.dgv_FromSelect.Name = "dgv_FromSelect";
            this.dgv_FromSelect.ReadOnly = true;
            this.dgv_FromSelect.RowHeadersWidth = 51;
            this.dgv_FromSelect.RowTemplate.Height = 24;
            this.dgv_FromSelect.Size = new System.Drawing.Size(376, 405);
            this.dgv_FromSelect.TabIndex = 16;
            this.dgv_FromSelect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FromSelect_CellClick);
            // 
            // txtBoxAdd_NameTypeFamily
            // 
            this.txtBoxAdd_NameTypeFamily.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBoxAdd_NameTypeFamily.Location = new System.Drawing.Point(226, 18);
            this.txtBoxAdd_NameTypeFamily.Name = "txtBoxAdd_NameTypeFamily";
            this.txtBoxAdd_NameTypeFamily.Size = new System.Drawing.Size(164, 32);
            this.txtBoxAdd_NameTypeFamily.TabIndex = 17;
            // 
            // btnAddNameTypeFamily
            // 
            this.btnAddNameTypeFamily.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAddNameTypeFamily.Location = new System.Drawing.Point(226, 65);
            this.btnAddNameTypeFamily.Name = "btnAddNameTypeFamily";
            this.btnAddNameTypeFamily.Size = new System.Drawing.Size(153, 33);
            this.btnAddNameTypeFamily.TabIndex = 18;
            this.btnAddNameTypeFamily.Text = "Добавить";
            this.btnAddNameTypeFamily.UseVisualStyleBackColor = true;
            this.btnAddNameTypeFamily.Click += new System.EventHandler(this.btnAddNameTypeFamily_Click);
            // 
            // txtboxAnVisibleIDNameTypeFamily
            // 
            this.txtboxAnVisibleIDNameTypeFamily.Location = new System.Drawing.Point(46, 460);
            this.txtboxAnVisibleIDNameTypeFamily.Name = "txtboxAnVisibleIDNameTypeFamily";
            this.txtboxAnVisibleIDNameTypeFamily.Size = new System.Drawing.Size(164, 22);
            this.txtboxAnVisibleIDNameTypeFamily.TabIndex = 19;
            this.txtboxAnVisibleIDNameTypeFamily.Visible = false;
            // 
            // btnUpdateNameCost
            // 
            this.btnUpdateNameCost.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUpdateNameCost.Location = new System.Drawing.Point(226, 104);
            this.btnUpdateNameCost.Name = "btnUpdateNameCost";
            this.btnUpdateNameCost.Size = new System.Drawing.Size(153, 29);
            this.btnUpdateNameCost.TabIndex = 20;
            this.btnUpdateNameCost.Text = "Изменить";
            this.btnUpdateNameCost.UseVisualStyleBackColor = true;
            this.btnUpdateNameCost.Click += new System.EventHandler(this.btnUpdateNameCost_Click);
            // 
            // idDataFamilyBudget_db
            // 
            this.idDataFamilyBudget_db.DataPropertyName = "idNameTypeFamily";
            this.idDataFamilyBudget_db.HeaderText = "ID";
            this.idDataFamilyBudget_db.MinimumWidth = 6;
            this.idDataFamilyBudget_db.Name = "idDataFamilyBudget_db";
            this.idDataFamilyBudget_db.ReadOnly = true;
            // 
            // DateCost
            // 
            this.DateCost.DataPropertyName = "NameTypeFamily";
            this.DateCost.HeaderText = "Члены Семьи";
            this.DateCost.MinimumWidth = 6;
            this.DateCost.Name = "DateCost";
            this.DateCost.ReadOnly = true;
            // 
            // addNameTypeFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdateNameCost);
            this.Controls.Add(this.txtboxAnVisibleIDNameTypeFamily);
            this.Controls.Add(this.btnAddNameTypeFamily);
            this.Controls.Add(this.txtBoxAdd_NameTypeFamily);
            this.Controls.Add(this.dgv_FromSelect);
            this.Name = "addNameTypeFamily";
            this.Size = new System.Drawing.Size(995, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FromSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_FromSelect;
        private System.Windows.Forms.TextBox txtBoxAdd_NameTypeFamily;
        private System.Windows.Forms.Button btnAddNameTypeFamily;
        private System.Windows.Forms.TextBox txtboxAnVisibleIDNameTypeFamily;
        private System.Windows.Forms.Button btnUpdateNameCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataFamilyBudget_db;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCost;
    }
}
