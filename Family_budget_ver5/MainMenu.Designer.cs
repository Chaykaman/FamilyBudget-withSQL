namespace Family_budget_ver5
{
    partial class FormMainMenuBudjet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenuBudjet));
            this.panel_header_title = new System.Windows.Forms.Panel();
            this.label_header_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Main_button = new System.Windows.Forms.Panel();
            this.btnAddNameTypeFamily = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcelDateBase = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditDateBase = new Guna.UI2.WinForms.Guna2Button();
            this.btnMainGrafs = new Guna.UI2.WinForms.Guna2Button();
            this.btnMain = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel_header_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Main_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header_title
            // 
            this.panel_header_title.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_header_title.Controls.Add(this.label_header_title);
            this.panel_header_title.Controls.Add(this.pictureBox1);
            this.panel_header_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header_title.Location = new System.Drawing.Point(0, 0);
            this.panel_header_title.Name = "panel_header_title";
            this.panel_header_title.Size = new System.Drawing.Size(1393, 108);
            this.panel_header_title.TabIndex = 0;
            // 
            // label_header_title
            // 
            this.label_header_title.AutoSize = true;
            this.label_header_title.Location = new System.Drawing.Point(147, 44);
            this.label_header_title.Name = "label_header_title";
            this.label_header_title.Size = new System.Drawing.Size(203, 23);
            this.label_header_title.TabIndex = 1;
            this.label_header_title.Text = "Семейный бюджет";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Main_button
            // 
            this.panel_Main_button.BackColor = System.Drawing.Color.White;
            this.panel_Main_button.Controls.Add(this.btnAddNameTypeFamily);
            this.panel_Main_button.Controls.Add(this.btnExcelDateBase);
            this.panel_Main_button.Controls.Add(this.btnEditDateBase);
            this.panel_Main_button.Controls.Add(this.btnMainGrafs);
            this.panel_Main_button.Controls.Add(this.btnMain);
            this.panel_Main_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Main_button.Location = new System.Drawing.Point(0, 108);
            this.panel_Main_button.Name = "panel_Main_button";
            this.panel_Main_button.Size = new System.Drawing.Size(1393, 52);
            this.panel_Main_button.TabIndex = 1;
            // 
            // btnAddNameTypeFamily
            // 
            this.btnAddNameTypeFamily.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNameTypeFamily.CheckedState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnAddNameTypeFamily.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnAddNameTypeFamily.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAddNameTypeFamily.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNameTypeFamily.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNameTypeFamily.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNameTypeFamily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNameTypeFamily.FillColor = System.Drawing.Color.White;
            this.btnAddNameTypeFamily.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNameTypeFamily.ForeColor = System.Drawing.Color.Black;
            this.btnAddNameTypeFamily.HoverState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnAddNameTypeFamily.Location = new System.Drawing.Point(1048, 7);
            this.btnAddNameTypeFamily.Name = "btnAddNameTypeFamily";
            this.btnAddNameTypeFamily.Size = new System.Drawing.Size(324, 45);
            this.btnAddNameTypeFamily.TabIndex = 5;
            this.btnAddNameTypeFamily.Text = "Управление Членами Семьи";
            this.btnAddNameTypeFamily.Click += new System.EventHandler(this.btnAddNameTypeFamily_Click);
            // 
            // btnExcelDateBase
            // 
            this.btnExcelDateBase.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnExcelDateBase.CheckedState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnExcelDateBase.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnExcelDateBase.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnExcelDateBase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelDateBase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelDateBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelDateBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelDateBase.FillColor = System.Drawing.Color.White;
            this.btnExcelDateBase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExcelDateBase.ForeColor = System.Drawing.Color.Black;
            this.btnExcelDateBase.HoverState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnExcelDateBase.Location = new System.Drawing.Point(818, 7);
            this.btnExcelDateBase.Name = "btnExcelDateBase";
            this.btnExcelDateBase.Size = new System.Drawing.Size(170, 45);
            this.btnExcelDateBase.TabIndex = 4;
            this.btnExcelDateBase.Text = "Распечатать";
            this.btnExcelDateBase.Click += new System.EventHandler(this.btnExcelDateBase_Click);
            // 
            // btnEditDateBase
            // 
            this.btnEditDateBase.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEditDateBase.CheckedState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnEditDateBase.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnEditDateBase.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnEditDateBase.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDateBase.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditDateBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditDateBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditDateBase.FillColor = System.Drawing.Color.White;
            this.btnEditDateBase.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditDateBase.ForeColor = System.Drawing.Color.Black;
            this.btnEditDateBase.HoverState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnEditDateBase.Location = new System.Drawing.Point(527, 7);
            this.btnEditDateBase.Name = "btnEditDateBase";
            this.btnEditDateBase.Size = new System.Drawing.Size(236, 45);
            this.btnEditDateBase.TabIndex = 3;
            this.btnEditDateBase.Text = "Управление базой";
            this.btnEditDateBase.Click += new System.EventHandler(this.btnEditDateBase_Click);
            // 
            // btnMainGrafs
            // 
            this.btnMainGrafs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMainGrafs.CheckedState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnMainGrafs.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnMainGrafs.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnMainGrafs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMainGrafs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMainGrafs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMainGrafs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMainGrafs.FillColor = System.Drawing.Color.White;
            this.btnMainGrafs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainGrafs.ForeColor = System.Drawing.Color.Black;
            this.btnMainGrafs.HoverState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnMainGrafs.Location = new System.Drawing.Point(288, 7);
            this.btnMainGrafs.Name = "btnMainGrafs";
            this.btnMainGrafs.Size = new System.Drawing.Size(180, 45);
            this.btnMainGrafs.TabIndex = 2;
            this.btnMainGrafs.Text = "Графики";
            this.btnMainGrafs.Click += new System.EventHandler(this.btnMainGrafs_Click);
            // 
            // btnMain
            // 
            this.btnMain.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMain.Checked = true;
            this.btnMain.CheckedState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnMain.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMain.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnMain.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnMain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMain.FillColor = System.Drawing.Color.White;
            this.btnMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMain.ForeColor = System.Drawing.Color.Black;
            this.btnMain.HoverState.CustomBorderColor = System.Drawing.Color.Olive;
            this.btnMain.Location = new System.Drawing.Point(12, 6);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(236, 45);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Анализ Финансов";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 160);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1393, 656);
            this.panelContainer.TabIndex = 2;
            // 
            // FormMainMenuBudjet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1393, 816);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel_Main_button);
            this.Controls.Add(this.panel_header_title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenuBudjet";
            this.Text = "Семейный бюджет";
            this.panel_header_title.ResumeLayout(false);
            this.panel_header_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Main_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header_title;
        private System.Windows.Forms.Label label_header_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Main_button;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnEditDateBase;
        private Guna.UI2.WinForms.Guna2Button btnMainGrafs;
        private Guna.UI2.WinForms.Guna2Button btnMain;
        private Guna.UI2.WinForms.Guna2Button btnExcelDateBase;
        private Guna.UI2.WinForms.Guna2Button btnAddNameTypeFamily;
    }
}

