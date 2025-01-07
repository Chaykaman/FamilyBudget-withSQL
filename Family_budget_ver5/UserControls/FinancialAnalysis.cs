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
    public partial class FinancialAnalysis : UserControl
    {

        
        public FinancialAnalysis()
        {
            InitializeComponent();
            MaxMonthValueLabelTransaction0();
            MonthLabel_base.Text = dateTimePicker_MonthCost.Value.ToString("MMMM");
            NameCostonLabelTransaction0();
            ChartNameTransaction0();
            CmbSqlConnTest();
        }

        public void MaxMonthValueLabelTransaction0() //списание за месяц
        {
            int selItemNameTypeFamily = comboBoxNameTypeFamily.Items.IndexOf(comboBoxNameTypeFamily.Text);

            if (checkBoxTransaction.Checked == true)
            {
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", LabelCostMonth);
            }
            else 
            { 
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", LabelCostMonth);
            }
        }

        private void CmbSqlConnTest()
        {
            dbFunctionMySQL.DisplayCombobox("Select nametypefamily.NameTypeFamily as FullName from `22-ias_syskovdy`.nametypefamily;", comboBoxNameTypeFamily);
        }


        public void NameCostonLabelTransaction0()
        {
            int selItemNameTypeFamily = comboBoxNameTypeFamily.Items.IndexOf(comboBoxNameTypeFamily.Text);

            if (checkBoxTransaction.Checked == true)
            {
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 2 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostCostUp);
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 1 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 1 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostCostDown);
            }
            else
            {
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 7 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostGkx);
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 3 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostClothes);
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 6 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostMedications);
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 5 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostCar);
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 8 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostOther);
                dbFunctionMySQL.Displlabel("select sum(PriceCost) as Sales from `22-ias_syskovdy`.datafamilybudget_dbb where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +" and datafamilybudget_dbb.idNameCost = 4 and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + ";", labelCostSupermarket);
            }

        }

        public void ChartNameTransaction0()
        {
            int selItemNameTypeFamily = comboBoxNameTypeFamily.Items.IndexOf(comboBoxNameTypeFamily.Text);

            if (checkBoxTransaction.Checked ==  true)
            {
                
                dbFunctionMySQL.DisplChart("select datafamilybudget_dbb.PriceCost as PriceCost, namecost.NameCost as NameCostB from `22-ias_syskovdy`.datafamilybudget_dbb Left join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost where TypeCost = 1 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +"  and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + " group by datafamilybudget_dbb.idNameCost; ", chartNameTypeMonth);
                //dbFunctionMySQL.DisplChart("select PriceCost, group_concat(distinct NameCost) as NameCostB from `22-ias_syskovdy`.datafamilybudget_db where TypeCost = 1 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and NameTypeFamily = " + comboBoxNameTypeFamily.Text + " group by NameCost;", chartNameTypeMonth);
            }
            else
            {
                dbFunctionMySQL.DisplChart("select datafamilybudget_dbb.PriceCost as PriceCost, namecost.NameCost as NameCostB from `22-ias_syskovdy`.datafamilybudget_dbb Left join `22-ias_syskovdy`.namecost on  namecost.idNameCost = datafamilybudget_dbb.idNameCost where TypeCost = 0 and month(DateCost) = " + dateTimePicker_MonthCost.Value.ToString("MM") + " and year(DateCost)= "+ dateTimePicker_MonthCost.Value.ToString("yyyy") +"  and datafamilybudget_dbb.idNameTypeFamily = " + selItemNameTypeFamily + " group by datafamilybudget_dbb.idNameCost; ", chartNameTypeMonth);
            }
            
            chartNameTypeMonth.Series["MonthNameCost"].YValueMembers = "PriceCost";
            chartNameTypeMonth.Series["MonthNameCost"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chartNameTypeMonth.Series["MonthNameCost"].XValueMember = "NameCostB";
            chartNameTypeMonth.Series["MonthNameCost"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        private void dateTimePicker_MonthCost_ValueChanged(object sender, EventArgs e) //изменение с зачислений на списание
        {


            MaxMonthValueLabelTransaction0();
            NameCostonLabelTransaction0();
            ChartNameTransaction0();
          
            
            MonthLabel_base.Text = dateTimePicker_MonthCost.Value.ToString("MMMM");
        }

        private void checkBoxTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTransaction.Checked == true)
            {
                checkBoxTransaction.Text = "Зачисление";
                LabelTittleCostMonth.Text = "Всего Зачислено";
                panelCostUp.Visible = true;
                panelCostDown.Visible = true;
                panelCar.Visible = panelClothes.Visible = panelMedications.Visible = panelOther.Visible = panelSupermarket.Visible = panelGKX.Visible = false;
                

            }
            else
            {
                checkBoxTransaction.Text = "Списание";
                LabelTittleCostMonth.Text = "Всего Списано";
                panelCostUp.Visible = false;
                panelCostDown.Visible = false;
                panelCar.Visible = panelClothes.Visible = panelMedications.Visible = panelOther.Visible = panelSupermarket.Visible = panelGKX.Visible = true;

            }
            ChartNameTransaction0();
            MaxMonthValueLabelTransaction0();
            NameCostonLabelTransaction0();
        }

        private void comboBoxNameTypeFamily_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxNameTypeFamily.Items.IndexOf(comboBoxNameTypeFamily.Text) == 0)
            {

            }
            else
            {
                ChartNameTransaction0();
                MaxMonthValueLabelTransaction0();
                NameCostonLabelTransaction0();
            }
            
        }
    }
}
