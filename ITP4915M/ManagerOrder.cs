using System;
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
    public partial class ManagerOrder : Form
    {
        const string database = "4915";
        const string databaseServer = "localhost";
        const string databaseUser = "root";
        const string databasePassword = ";";
        const string port = "3306";
        string connectionString =
            $"server={databaseServer};" + $"user={databaseUser};" +
            $"password={databasePassword};" + $"database={database};" +
            "charset=utf8;";


        string searchDealerQuery = "SELECT * FROM dealer";


        public ManagerOrder()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchDearlerBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);



            try
            {
                conn.Open();

                string searchDealerQuery = "SELECT * FROM `dealer` WHERE DealerCode = @dealerID";
                MySqlCommand command = new MySqlCommand(searchDealerQuery, conn);
                command.Parameters.AddWithValue("@dealerID", textBox2.Text);


                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        textBox3.Text = reader.GetString(1);
                        textBox4.Text = reader.GetString(2);
                        textBox5.Text = reader.GetValue(3)+"";
                    }
                }
                else
                {
                    MessageBox.Show("No such ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            Orderlist.Rows.Add(textBox6.Text, textBox7.Text, numericUpDown1.Text);
        }

        private void searchItemBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);



            try
            {
                conn.Open();

                string searchPartQuery = "SELECT * FROM `spare` WHERE PartNumber = @PartNumber";
                MySqlCommand command = new MySqlCommand(searchPartQuery, conn);
                command.Parameters.AddWithValue("@PartNumber", textBox6.Text);


                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox6.Text = reader.GetValue(0) + "";
                        textBox7.Text = reader.GetString(1);

                    }
                }
                else
                {
                    MessageBox.Show("No such ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Orderlist.Rows.RemoveAt(Orderlist.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void clearorderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Orderlist.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void issueOrder_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string searchDealerQuery = "SELECT * FROM `dealer` WHERE DealerCode = @dealerID";
                MySqlCommand command = new MySqlCommand(searchDealerQuery, conn);
                command.Parameters.AddWithValue("@dealerID", textBox2.Text);


                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        textBox3.Text = reader.GetString(1);
                        textBox4.Text = reader.GetString(2);
                        textBox5.Text = reader.GetValue(3) + "";
                    }
                }
                else
                {
                    MessageBox.Show("No such ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }
    }
    }
    

