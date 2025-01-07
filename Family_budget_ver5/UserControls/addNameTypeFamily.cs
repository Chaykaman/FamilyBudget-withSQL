using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Family_budget_ver5.UserControls
{
    public partial class addNameTypeFamily : UserControl
    {
        public addNameTypeFamily()
        {
            InitializeComponent();
            DisplayNameTypeFamily();
        }


        public void Clear()
        {
            txtboxAnVisibleIDNameTypeFamily.Text = txtBoxAdd_NameTypeFamily.Text = "";
        }

        public void DisplayNameTypeFamily()
        {
            
            dbFunctionMySQL.DisplayandSearch("SELECT * FROM `22-ias_syskovdy`.nametypefamily;", dgv_FromSelect);
            
        }

        private void btnAddNameTypeFamily_Click(object sender, EventArgs e)
        {
            if (txtBoxAdd_NameTypeFamily.Text == "")
            {
                MessageBox.Show("Вы не ввели имя!");
            }
            else
            {


                dbFunctionMySQL.AddNameTypeFamily(txtBoxAdd_NameTypeFamily.Text.Trim());
                DisplayNameTypeFamily();
                Clear();
            }
        }

        private void btnUpdateNameCost_Click(object sender, EventArgs e)
        {
            if (txtboxAnVisibleIDNameTypeFamily.Text == "")
            {
                MessageBox.Show("Вы не выбрали члена семьи в таблице!");
            }
            else
            {


                dbFunctionMySQL.UpdateNameTypeFamily(txtBoxAdd_NameTypeFamily.Text.Trim(), txtboxAnVisibleIDNameTypeFamily.Text.Trim());
                DisplayNameTypeFamily();
                Clear();
            }

        }

        private void dgv_FromSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dgv_FromSelect.Rows[selectedRow];
                txtboxAnVisibleIDNameTypeFamily.Text = row.Cells[0].Value.ToString();
                txtBoxAdd_NameTypeFamily.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
