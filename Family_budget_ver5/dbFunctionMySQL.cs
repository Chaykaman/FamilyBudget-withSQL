using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataTable = System.Data.DataTable;

namespace Family_budget_ver5
{
    internal class dbFunctionMySQL
    {

        public static MySqlConnection GetConnection() //конект слишком долго подключается
        {
            string pwd = "212121";
            string sql = @"server=localhost;port=3306;user=root;password=" + pwd + ";database=22-ias_syskovdy";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Проблема с подключением. Попробуйте зайти позже\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddBudget(Budget_Family budget_Family) //добавить данные
        {

            string sql = "insert into `22-ias_syskovdy`.datafamilybudget_dbb(TypeCost, idNameTypeFamily, idNameCost, PriceCost, DateCost) VALUES (@TypeCost, @idNameTypeFamily, @idNameCost, @PriceCost, @DateCost)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TypeCost", MySqlDbType.Int32).Value = budget_Family.TypeCost;
            cmd.Parameters.Add("@idNameTypeFamily", MySqlDbType.Int32).Value = budget_Family.idNameTypeFamily;
            cmd.Parameters.Add("@idNameCost", MySqlDbType.Int32).Value = budget_Family.idNameCost;
            cmd.Parameters.Add("@PriceCost", MySqlDbType.Int32).Value = budget_Family.PriceCost;
            cmd.Parameters.Add("@DateCost", MySqlDbType.Date).Value = budget_Family.DateCost;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись Добавлена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateBudget(Budget_Family budget_Family, string id) // изменить данные
        {

            string sql = "UPDATE `22-ias_syskovdy`.`datafamilybudget_dbb` SET TypeCost = @TypeCost ,idNameTypeFamily = @idNameTypeFamily, idNameCost = @idNameCost, PriceCost = @PriceCost, DateCost = @DateCost  WHERE idDataFamilyBudget_db = @idDataFamilyBudget_db;";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idDataFamilyBudget_db", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@TypeCost", MySqlDbType.Int32).Value = budget_Family.TypeCost;
            cmd.Parameters.Add("@idNameTypeFamily", MySqlDbType.Int32).Value = budget_Family.idNameTypeFamily;
            cmd.Parameters.Add("@idNameCost", MySqlDbType.Int32).Value = budget_Family.idNameCost;
            cmd.Parameters.Add("@PriceCost", MySqlDbType.Int32).Value = budget_Family.PriceCost;
            cmd.Parameters.Add("@DateCost", MySqlDbType.Date).Value = budget_Family.DateCost;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись Изменена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не изменена\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteBudget(string id) // удалить данные
        {
            string sql = "DELETE FROM `22-ias_syskovdy`.`datafamilybudget_dbb` WHERE idDataFamilyBudget_db = @idDataFamilyBudget_db";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idDataFamilyBudget_db", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись Удалена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не удалена\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        public static void DisplayandSearch(string query, DataGridView dgv) // вывод данных в дата грид и поиск по строке
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void DisplChart(string query, System.Windows.Forms.DataVisualization.Charting.Chart chart) // вывод данных в чар и поиск по строке
        {

            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            chart.DataSource = tbl;
            con.Close();

        }

        public static void Displlabel(string query, Label label) // вывод данных в чар и поиск по строке
        {

            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    label.Text = dr["Sales"].ToString();
                }
            }
            con.Close();
            

        }

        public static void DisplayCombobox(string query, ComboBox comboBox)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string name = dr.GetString("FullName");
                comboBox.Items.Add(name);
            }
            cmd.Dispose();
            dr.Close();
            con.Close();

        }

        public static void AddNameTypeFamily(string NameTypeFamily) //добавить данные
        {

            string sql = "INSERT INTO `22-ias_syskovdy`.`nametypefamily` (`NameTypeFamily`) VALUES (@NameTypeFamily)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NameTypeFamily", MySqlDbType.VarChar).Value = NameTypeFamily;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись Добавлена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не добавлена\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateNameTypeFamily(string NameTypeFamily, string id) // изменить данные
        {

            string sql = "UPDATE `22-ias_syskovdy`.`nametypefamily` SET `NameTypeFamily`= @NameTypeFamily  WHERE idNameTypeFamily = @idNameTypeFamily;";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idNameTypeFamily", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@NameTypeFamily", MySqlDbType.VarChar).Value = NameTypeFamily;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись Изменена", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Запись не изменена\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }


        //public static void LoadCombo(string query, string DisplayMember, string ValueMember, System.Windows.Forms.ComboBox comboBox)
        //{
        //    MySqlConnection con = GetConnection();
        //    try
        //    {
        //        string sql = query;

        //        MySqlCommand cmd = new MySqlCommand(sql, con);
        //        MySqlDataAdapter da = new MySqlDataAdapter();
        //        da.SelectCommand = cmd;
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        comboBox.DataSource = dt;
        //        comboBox.DisplayMember = DisplayMember;
        //        comboBox.ValueMember = ValueMember;

        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {

        //        con.Close();
        //    }

        //}
    }
}
