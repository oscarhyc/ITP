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
    public partial class SearchDearler : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        //private Form _mdiParent;
        public static SearchDearler instance;

        public SearchDearler()
        {
            InitializeComponent();
            instance = this;
        }


        private void searchlabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dealerlist.Rows.Count)
            {
                // 获取选中行的所有单元格值
                DataGridViewRow selectedRow = dealerlist.Rows[e.RowIndex];
                string cellValue1 = selectedRow.Cells[0].Value?.ToString();
                string cellValue2 = selectedRow.Cells[1].Value?.ToString();
                string cellValue3 = selectedRow.Cells[2].Value?.ToString();
                string cellValue4 = selectedRow.Cells[3].Value?.ToString();

                // 将单元格值复制到对应的文本框
                textBox2.Text = cellValue1;
                textBox3.Text = cellValue2;
                textBox4.Text = cellValue3;
                textBox5.Text = cellValue4;

        
            }

  

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);



            string searchTerm = textBox1.Text.Trim();

            dealerlist.Rows.Clear();


            try
            {
                conn.Open();
                string query = @"
            SELECT *, 
                        CASE 
                            WHEN DealerCode LIKE @SearchTerm THEN 3
                            WHEN DealerName LIKE @SearchTerm THEN 2
                            WHEN DealerAddress LIKE @SearchTerm THEN 1
                            WHEN DearlerTel LIKE @SearchTerm THEN 1
                            ELSE 0
                        END AS Relevance
                    FROM dealer
                    WHERE CONCAT(DealerCode, DealerName, DealerAddress, DearlerTel) LIKE @SearchTerm
                    ORDER BY Relevance DESC

                ";

                // Create a SqlCommand object with the query and connection
                MySqlCommand command = new MySqlCommand(query, conn);

                // Add parameters to the SqlCommand object
      
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                // Execute the query
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dealerlist.Rows.Add(
                            reader["DealerCode"],
                            reader["DealerName"],
                            reader["DealerAddress"],
                            reader["DearlerTel"]

                    );


                    }
                }
                else
                {
                    // Invalid username or password
                    MessageBox.Show("Invalid username or password!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Dashboard_order.instance.textBox2.Text = textBox2.Text;
            Dashboard_order.instance.textBox3.Text = textBox3.Text;
            Dashboard_order.instance.textBox4.Text = textBox4.Text;
            Dashboard_order.instance.textBox5.Text = textBox5.Text;

        }

        private void DearlerTellbl_Click(object sender, EventArgs e)
        {

        }

        private void DealerAddresslbl_Click(object sender, EventArgs e)
        {

        }

        private void DealerNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void DealerCodelbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

