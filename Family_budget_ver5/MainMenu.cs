using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Family_budget_ver5.UserControls;
using Guna.UI2;

namespace Family_budget_ver5
{
    public partial class FormMainMenuBudjet : Form
    {
        public FormMainMenuBudjet()
        {
            InitializeComponent();
            //FinancialAnalysis financialAnalysis = new FinancialAnalysis();
            //addUserControll(financialAnalysis);
            DateBaseEdit dateBaseEdit = new DateBaseEdit();
            addUserControll(dateBaseEdit);
        }

        private void addUserControll(UserControl userControl)
        {   userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnEditDateBase_Click(object sender, EventArgs e)
        {
            DateBaseEdit dateBaseEdit = new DateBaseEdit();
            addUserControll(dateBaseEdit);
        }

        private void btnMainGrafs_Click(object sender, EventArgs e)
        {
            GrafsDate grafsDate = new GrafsDate();
            addUserControll(grafsDate);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            FinancialAnalysis financialAnalysis = new FinancialAnalysis();
            addUserControll(financialAnalysis);
        }

        

        private void btnExcelDateBase_Click(object sender, EventArgs e)
        {
            ExcelControl excelControl = new ExcelControl();
            addUserControll(excelControl);
        }

        private void btnAddNameTypeFamily_Click(object sender, EventArgs e)
        {
            addNameTypeFamily addNameTypeFamily = new addNameTypeFamily();
            addUserControll(addNameTypeFamily);
        }
    }
}
