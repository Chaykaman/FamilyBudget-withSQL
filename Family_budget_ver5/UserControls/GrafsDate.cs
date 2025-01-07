using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class GrafsDate : UserControl
    {
        public GrafsDate()
        {
            InitializeComponent();
            ChartTransaction1();
            LabelMaxValuseAddSales();
            LabelMaxValuseCost();
        }


        public void LabelMaxValuseAddSales()
        {
            dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1;", label_titleSearchMaxValuesSales);
        }

        public void LabelMaxValuseCost()
        {
            dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0;", label_titleSearchMaxValuesCost);
        }

        public void ChartTransaction0()
        {

            dbFunctionMySQL.DisplChart("SELECT datafamilybudget_dbb.PriceCost as PriceCost, nametypefamily.NameTypeFamily as NameType from `22-ias_syskovdy`.datafamilybudget_dbb Left join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where TypeCost = 0 group by nametypefamily.idNameTypeFamily;", ChartTransaction0_family);
            ChartTransaction0_family.Series["Write-off"].YValueMembers = "PriceCost";
            ChartTransaction0_family.Series["Write-off"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            ChartTransaction0_family.Series["Write-off"].XValueMember = "NameType";
            ChartTransaction0_family.Series["Write-off"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

        }
        public void ChartTransaction1()
        {
            dbFunctionMySQL.DisplChart("SELECT datafamilybudget_dbb.PriceCost as PriceCost, nametypefamily.NameTypeFamily as NameType from `22-ias_syskovdy`.datafamilybudget_dbb Left join `22-ias_syskovdy`.nametypefamily on nametypefamily.idNameTypeFamily = datafamilybudget_dbb.idNameTypeFamily where TypeCost = 1 group by nametypefamily.idNameTypeFamily;", ChartTransaction1_family);
            ChartTransaction1_family.Series["Profit"].YValueMembers = "PriceCost";
            ChartTransaction1_family.Series["Profit"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            ChartTransaction1_family.Series["Profit"].XValueMember = "NameType";
            ChartTransaction1_family.Series["Profit"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        private void cmbbox_transaction_chart_TextChanged(object sender, EventArgs e)
        {
            if (cmbbox_transaction_chart.SelectedIndex == 0)
            {
                ChartTransaction0_family.Visible = true;
                ChartTransaction1_family.Visible = false;
                ChartTransaction0();
                //ChartTransaction0_family.Titles.Add("Списания");
            }
            if (cmbbox_transaction_chart.SelectedIndex == 1)
            {
                ChartTransaction0_family.Visible = false;
                ChartTransaction1_family.Visible = true;
                ChartTransaction1();
                //ChartTransaction1_family.Titles.Add("Зачисление");
            }
        }

        private void btnSearchThisMonth_Click(object sender, EventArgs e)
        {
            if (checkBoxAllYearSearch.Checked == true)
            {
                dbFunctionMySQL.DisplChart("select DateCost, sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = month(now()) group by  DateCost;", ChartAllYearSearch);
            }
            else
            {
                dbFunctionMySQL.DisplChart("select DateCost, sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1 and month(DateCost) = month(now()) group by  DateCost;", ChartAllYearSearch);
            }
            
            ChartAllYearSearch.Series["Sales"].XValueMember = "DateCost";
            ChartAllYearSearch.Series["Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            ChartAllYearSearch.Series["Sales"].YValueMembers = "Sales";
            ChartAllYearSearch.Series["Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        private void btnSearchThisYear_Click(object sender, EventArgs e)
        {
            if (checkBoxAllYearSearch.Checked == true)
            {
          
                dbFunctionMySQL.DisplChart("select DateCost, sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and year(DateCost) = year(now()) group by  DateCost;", ChartAllYearSearch);
            }
            else
            {
          
                dbFunctionMySQL.DisplChart("select DateCost, sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1 and year(DateCost) = year(now()) group by  DateCost;", ChartAllYearSearch);
            }
            
            ChartAllYearSearch.Series["Sales"].XValueMember = "DateCost";
            ChartAllYearSearch.Series["Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            ChartAllYearSearch.Series["Sales"].YValueMembers = "Sales";
            ChartAllYearSearch.Series["Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        private void btnSearchThisDay_Click(object sender, EventArgs e)
        {
            if(checkBoxAllYearSearch.Checked == true)
            {
                dbFunctionMySQL.DisplChart("select DateCost, sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and day(DateCost) = day(now()) group by  DateCost;", ChartAllYearSearch);
            }
            else
            {
                dbFunctionMySQL.DisplChart("select DateCost, sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1 and day(DateCost) = day(now()) group by  DateCost;", ChartAllYearSearch);
            }
            ChartAllYearSearch.Series["Sales"].XValueMember = "DateCost";
            ChartAllYearSearch.Series["Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            ChartAllYearSearch.Series["Sales"].YValueMembers = "Sales";
            ChartAllYearSearch.Series["Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        }

        private void checkBoxAllYearSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAllYearSearch.Checked == true)
            {
                checkBoxAllYearSearch.Text = "Списание";
            }
            else
            {
                checkBoxAllYearSearch.Text = "Зачисление";
            }

        }
    }
}
