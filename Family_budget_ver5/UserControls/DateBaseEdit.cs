using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Family_budget_ver5.UserControls
{
    public partial class DateBaseEdit : UserControl
    {

        public DateBaseEdit()
        {
            InitializeComponent();
            Display();
            CmbSqlConnTest();

        }

        public void Display()
        {
            //dbFunctionMySQL.DisplayandSearch("SELECT * FROM `22-ias_syskovdy`.datafamilybudget_db;", dgv_FromSelect);
            dbFunctionMySQL.DisplayandSearch("select datafamilybudget_dbb.iddatafamilybudget_db,datafamilybudget_dbb.TypeCost, nametypefamily.NameTypeFamily, namecost.NameCost, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily;", dgv_FromSelect);
            //dbFunctionMySQL.DisplayandSearch("SELECT iddatafamilybudget_db, TypeCost, idNameTypeFamily as NameTypeFamily, idNameCost as NameCost, PriceCost, DateCost FROM `22-ias_syskovdy`.datafamilybudget_dbb;", dgv_FromSelect);
        }

        private void CmbSqlConnTest()
        {
            dbFunctionMySQL.DisplayCombobox("Select nametypefamily.NameTypeFamily as FullName from `22-ias_syskovdy`.nametypefamily;", txtbox_NameTypeFamily);
        }


        private void Excel_import()
        {
            Excel.Application exApp = new Excel.Application(); exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dgv_FromSelect.RowCount - 1; i++)
            {
                for (j = 0; j <= dgv_FromSelect.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dgv_FromSelect[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }




        private void btn_Excel_Click(object sender, EventArgs e)
        {

            Excel_import();
        }

        

        public void Clear()
        {
            combobox_TypeCost.Text = txtbox_NameTypeFamily.Text = txtbox_NameCost.Text = txtbox_PriceCost.Text = dateTimePicker_DateCost.Text = "";
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e) //поиск по таблице
        {
            dbFunctionMySQL.DisplayandSearch("select datafamilybudget_dbb.iddatafamilybudget_db,datafamilybudget_dbb.TypeCost, nametypefamily.NameTypeFamily, namecost.NameCost, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily WHERE concat_ws(datafamilybudget_dbb.iddatafamilybudget_db,datafamilybudget_dbb.TypeCost,datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost, namecost.NameCost, nametypefamily.NameTypeFamily) LIKE '%" + txtbox_Search.Text + "%';", dgv_FromSelect);
        //    dbFunctionMySQL.DisplayandSearch("SELECT idDataFamilyBudget_db, TypeCost, idNameTypeFamily, idNameCost, PriceCost, DateCost FROM datafamilybudget_dbb WHERE concat_ws(idDataFamilyBudget_db, TypeCost, idNameTypeFamily, idNameCost, PriceCost, DateCost) LIKE '%" + txtbox_Search.Text + "%'", dgv_FromSelect);
        }

       

        private void btn_Change_Click(object sender, EventArgs e) //кнопка изменить
        {
            if (txtbox_NameTypeFamily.Items.IndexOf(txtbox_NameTypeFamily.Text) == 0 || txtbox_NameCost.Items.IndexOf(txtbox_NameCost.Text) == 0)
            {
                MessageBox.Show("Не была выбрана Категория Расхода или Член Семьи");
            }
            else
            {
                try
                {
                    int selItemTypeCost = combobox_TypeCost.Items.IndexOf(combobox_TypeCost.Text);
                    int selItemNameTypeFamily = txtbox_NameTypeFamily.Items.IndexOf(txtbox_NameTypeFamily.Text);
                    int selItemNameCost = txtbox_NameCost.Items.IndexOf(txtbox_NameCost.Text);
                    Budget_Family budget_Family = new Budget_Family(selItemTypeCost, selItemNameTypeFamily, selItemNameCost, int.Parse(txtbox_PriceCost.Text.Trim()), dateTimePicker_DateCost.Value.ToString("yyyy.MM.dd"));
                    dbFunctionMySQL.UpdateBudget(budget_Family, txtbox_idDataFamilyBudget_db.Text);
                    Display();
                }
                catch
                {
                    MessageBox.Show("Данные введены некоретно");

                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить эту запись ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                dbFunctionMySQL.DeleteBudget(txtbox_idDataFamilyBudget_db.Text);
                Display();
            }
            return;
        }

        private void txtbox_Search_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_Search.Text == "")
            {
                Display();
            }
        }

        private void dgv_FromSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)  /*чтобы можно было сортировать столбцы в датагридвью*/
            {
                //DataGridViewRow row = dgv_FromSelect.Rows[selectedRow];
                //txtbox_idDataFamilyBudget_db.Text = row.Cells[0].Value.ToString();
                //combobox_TypeCost.Text = row.Cells[1].Value.ToString();
                //txtbox_NameTypeFamily.Text = row.Cells[2].Value.ToString();
                //txtbox_NameCost.Text = row.Cells[3].Value.ToString();
                //txtbox_PriceCost.Text = row.Cells[4].Value.ToString();
                //dateTimePicker_DateCost.Text = row.Cells[5].Value.ToString();
                DataGridViewRow row = dgv_FromSelect.Rows[selectedRow];
                txtbox_idDataFamilyBudget_db.Text = row.Cells[0].Value.ToString();
                if(row.Cells[1].Value.ToString() == "0")
                {
                    combobox_TypeCost.Text = "Списание";
                }
               else
                {
                    combobox_TypeCost.Text = "Зачисление";
                }
                //combobox_TypeCost.Text = row.Cells[1].Value.ToString();
                txtbox_NameTypeFamily.Text = row.Cells[2].Value.ToString();
                txtbox_NameCost.Text = row.Cells[3].Value.ToString();
                txtbox_PriceCost.Text = row.Cells[4].Value.ToString();
                dateTimePicker_DateCost.Text = row.Cells[5].Value.ToString();

            }
        }

       

        private void btn_SearchDate_Sql_Click(object sender, EventArgs e)
        {
            dbFunctionMySQL.DisplayandSearch("select datafamilybudget_dbb.iddatafamilybudget_db,datafamilybudget_dbb.TypeCost, nametypefamily.NameTypeFamily, namecost.NameCost, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where datafamilybudget_dbb.DateCost between '" + dateTimePicker_fromdate.Value.ToString("yyyy.MM.dd") + "' and '" + dateTimePicker_todate.Value.ToString("yyyy.MM.dd") + "';", dgv_FromSelect);
            //dbFunctionMySQL.DisplayandSearch("select idDataFamilyBudget_db, TypeCost, NameTypeFamily, NameCost, PriceCost, DateCost from `22-ias_syskovdy`.datafamilybudget_db\r\nwhere DateCost between  '" + dateTimePicker_fromdate.Value.ToString("yyyy.MM.dd") + "' and '" + dateTimePicker_todate.Value.ToString("yyyy.MM.dd") + "';", dgv_FromSelect);
        }

        private void checkBox_SearchDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SearchDate.Checked == true)
            {
                pannel_editdate.Visible = false;
                panel_Search_Date.Visible = true;
            }
            else
            {
                pannel_editdate.Visible = true;
                panel_Search_Date.Visible = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtbox_NameTypeFamily.Items.IndexOf(txtbox_NameTypeFamily.Text) == 0 || txtbox_NameCost.Items.IndexOf(txtbox_NameCost.Text) == 0)
            {
                MessageBox.Show("Не была выбрана Категория Расхода или Член Семьи");
            }
            else
            {

                try
                {

                    int selItemTypeCost = combobox_TypeCost.Items.IndexOf(combobox_TypeCost.Text);
                    int selItemNameTypeFamily = txtbox_NameTypeFamily.Items.IndexOf(txtbox_NameTypeFamily.Text);
                    int selItemNameCost = txtbox_NameCost.Items.IndexOf(txtbox_NameCost.Text);
                    Budget_Family budget_Family = new Budget_Family(selItemTypeCost, selItemNameTypeFamily, selItemNameCost, int.Parse(txtbox_PriceCost.Text.Trim()), dateTimePicker_DateCost.Value.ToString("yyyy.MM.dd"));
                    dbFunctionMySQL.AddBudget(budget_Family);
                    Display();
                    Clear();
                }
                catch
                {
                    MessageBox.Show("Данные введены некоретно");
                }
            }
        }
    }
}
