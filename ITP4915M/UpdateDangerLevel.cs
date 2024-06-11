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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4915M
{
    public partial class UpdateDangerLevel : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public UpdateDangerLevel()
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

        private void RefreshDataGridView()
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

        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE spare SET dangerlevel = @Newdangerlevel WHERE PartNumber = @PartNumber";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@PartNumber", textBox1.Text);
                    command.Parameters.AddWithValue("@Newdangerlevel", Convert.ToInt32(textBox4.Text)); //

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Updated unsuccessfully");
                    }

                    RefreshDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fail");
                }
            }
        }
    }
}
