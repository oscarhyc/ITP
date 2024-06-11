using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ITP4915M
{
    public partial class Searchitem : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        //private Form _mdiParent;
        public static Searchitem instance;
        public Searchitem()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Dashboard_order.instance.Orderlist.ClearSelection();

            Dashboard_order.instance.Orderlist.Rows.Add(
                        textBox2.Text,
                        textBox3.Text
                                     );
          
        }

        private void dealerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < itemlist.Rows.Count)
            {
                // 获取选中行的所有单元格值
                DataGridViewRow selectedRow = itemlist.Rows[e.RowIndex];
                string cellValue1 = selectedRow.Cells[0].Value?.ToString();
                string cellValue2 = selectedRow.Cells[1].Value?.ToString();


                // 将单元格值复制到对应的文本框
                textBox2.Text = cellValue1;
                textBox3.Text = cellValue2;



            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string SearchTerm = textBox1.Text.Trim();
            itemlist.Rows.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                string query = @"
                    SELECT *
                    FROM spare
                    WHERE PartNumber LIKE @SearchTerm
                       OR PartName LIKE @SearchTerm
                    ORDER BY PartNumber ASC
                    LIMIT 10;

                ";

                // Create a SqlCommand object with the query and connection
                MySqlCommand command = new MySqlCommand(query, conn);

                // Add parameters to the SqlCommand object

                command.Parameters.AddWithValue("@SearchTerm", "%" + SearchTerm + "%");
                // Execute the query
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        itemlist.Rows.Add(
                            reader["PartNumber"],
                            reader["PartName"],
                            reader["Weight"],
                            reader["StockQty"]
                        );


                    }

                }
                else
                {
                    conn.Close();
                    conn.Open();

                    string query1 = @"
                    SELECT * FROM spare

                ";
                    MySqlCommand command1 = new MySqlCommand(query1, conn);

                    // Add parameters to the SqlCommand object


                    // Execute the query
                    MySqlDataReader reader1 = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            itemlist.Rows.Add(
                                reader["PartNumber"],
                                reader["PartName"],
                                reader["Weight"],
                                reader["StockQty"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void itemlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < itemlist.Rows.Count)
            {
                // 获取选中行的所有单元格值
                DataGridViewRow selectedRow = itemlist.Rows[e.RowIndex];
                string cellValue1 = selectedRow.Cells[0].Value?.ToString();
                string cellValue2 = selectedRow.Cells[1].Value?.ToString();


                // 将单元格值复制到对应的文本框
                textBox2.Text = cellValue1;
                textBox3.Text = cellValue2;



            }
        }
    }
}
