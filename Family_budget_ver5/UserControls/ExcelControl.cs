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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace Family_budget_ver5.UserControls
{
    public partial class ExcelControl : UserControl
    {
        public ExcelControl()
        {
            
            InitializeComponent();
            dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily;", dgv_FromSelect);
        }

        public void ExcelPrintBase()
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
            ExcelPrintBase();
        }

        private void btn_searchDate_click()
        {
            if(cmb_filter.Items.IndexOf(cmb_filter.Text) == 0)
            {
                dbFunctionMySQL.DisplayandSearch("select nametypefamily.NameTypeFamily, namecost.NameCost, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost From `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where datafamilybudget_dbb.DateCost between '" + dateTimePicker_First.Value.ToString("yyyy.MM.dd") + "' and '" + dateTimePicker_Last.Value.ToString("yyyy.MM.dd") + "';", dgv_FromSelect);
            }
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 1)
            {
                dbFunctionMySQL.DisplayandSearch("select nametypefamily.NameTypeFamily, namecost.NameCost, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where datafamilybudget_dbb.DateCost between '" + dateTimePicker_First.Value.ToString("yyyy.MM.dd") + "' and '" + dateTimePicker_Last.Value.ToString("yyyy.MM.dd") + "' and datafamilybudget_dbb.TypeCost = 0;", dgv_FromSelect);
            }
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 2)
            {
                dbFunctionMySQL.DisplayandSearch("select nametypefamily.NameTypeFamily, namecost.NameCost, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where datafamilybudget_dbb.DateCost between '" + dateTimePicker_First.Value.ToString("yyyy.MM.dd") + "' and '" + dateTimePicker_Last.Value.ToString("yyyy.MM.dd") + "' and datafamilybudget_dbb.TypeCost = 1;", dgv_FromSelect);
            }

        }

        private void SearchDateCustom()
        {
            if(cmb_filter.Items.IndexOf(cmb_filter.Text) == 0)
            {
                dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where concat_ws(datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost, namecost.NameCost, nametypefamily.NameTypeFamily) LIKE '%" + txtbox_Search.Text + "%';", dgv_FromSelect);
            }
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 1)
            {
                dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where concat_ws(datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost, namecost.NameCost, nametypefamily.NameTypeFamily) LIKE '%" + txtbox_Search.Text + "%' and datafamilybudget_dbb.TypeCost = 0;", dgv_FromSelect);
            }
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 2)
            {
                dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where concat_ws(datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost, namecost.NameCost, nametypefamily.NameTypeFamily) LIKE '%" + txtbox_Search.Text + "%' and datafamilybudget_dbb.TypeCost = 1;", dgv_FromSelect);
            }
        }
        
        public void filter_cmb()
        {
            
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 0)
            {
                dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily;", dgv_FromSelect);
            }
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 1)
            {
                dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where  datafamilybudget_dbb.TypeCost = 0 ;", dgv_FromSelect);
            }
            if (cmb_filter.Items.IndexOf(cmb_filter.Text) == 2)
            {
                dbFunctionMySQL.DisplayandSearch("select namecost.NameCost, nametypefamily.NameTypeFamily, datafamilybudget_dbb.PriceCost, datafamilybudget_dbb.DateCost\r\nFrom `22-ias_syskovdy`.datafamilybudget_dbb \r\nLeft join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost \r\nLeft join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where  datafamilybudget_dbb.TypeCost = 1 ;", dgv_FromSelect);
            }
        }

        

        private void cmb_filter_TextChanged(object sender, EventArgs e)
        {
            filter_cmb();
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            SearchDateCustom();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            btn_searchDate_click();
        }

        private void checkboxBoolSearchDate_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxBoolSearchDate.Checked == true)
            {
                panelSearchDate.Visible = true;
            }
            else
            {
                panelSearchDate.Visible = false;
            }
        }
    }
}
