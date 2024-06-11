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
using MySql.Data.MySqlClient;

namespace ITP4915M
{
    public partial class Products_Reorder : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public Products_Reorder()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                   mysqlCon.Open();

              
                string sql = @"
        SELECT s.PartNumber, s.PartName, s.BinLocation, s.Weight, s.StockQty, s.CategoryCategoryID, s.dangerlevel,
               r.ReorderNumber, r.ReorderDate
        FROM spare s
        LEFT JOIN reorderrecord r ON s.PartNumber = CAST(r.PartNumber AS UNSIGNED);
        ";
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter(sql, mysqlCon);
                DataTable dataTable = new DataTable();
                mySqlDa.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();


                string sql = @"
        SELECT s.PartNumber, s.PartName, s.BinLocation, s.Weight, s.StockQty, s.CategoryCategoryID, s.dangerlevel,
               r.ReorderNumber, r.ReorderDate
        FROM spare s
        LEFT JOIN reorderrecord r ON s.PartNumber = CAST(r.PartNumber AS UNSIGNED);
        ";
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter(sql, mysqlCon);
                DataTable dataTable = new DataTable();
                mySqlDa.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                mysqlCon.Open();
                string query = @"
        SELECT s.PartNumber, s.PartName, s.BinLocation, s.StockQty, s.dangerlevel, 
               COALESCE(SUM(r.Quantity), 0) AS `ReorderingQty`,
               (s.StockQty + COALESCE(SUM(r.Quantity), 0)) AS `TotalAvailable`,
               s.dangerlevel > (s.StockQty + COALESCE(SUM(r.Quantity), 0)) AS `IsUnderDangerLevel`
        FROM spare s
        LEFT JOIN reorderrecord r ON s.PartNumber = CAST(r.PartNumber AS UNSIGNED)
        GROUP BY s.PartNumber, s.PartName, s.BinLocation, s.StockQty, s.dangerlevel
        HAVING `IsUnderDangerLevel`
        LIMIT 1;
        ";
                MySqlDataAdapter mySqlDa = new MySqlDataAdapter(query, mysqlCon);
                DataTable dataTable = new DataTable();
                mySqlDa.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                INSERT INTO `reorderrecord` (`PartNumber`, `ReorderDate`, `Quantity`, `StaffStaff ID`, `SupplierSupplierID`)
                VALUES (@PartNumber, @ReorderDate, @Quantity, @StaffID, @SupplierID);";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@PartNumber", textBox1.Text); 
                    command.Parameters.AddWithValue("@ReorderDate", DateTime.Now); 
                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(textBox4.Text)); 
                                                                                                  
                    command.Parameters.AddWithValue("@StaffID", Convert.ToInt32(textBox3.Text)); 
                    command.Parameters.AddWithValue("@SupplierID", textBox5.Text); 

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Success。");
                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fail：" + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }


    }
}
