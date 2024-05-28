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

                string searchDealerQuery = "SELECT * FROM `dealer` WHERE @dealerID";
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
        }
    }
    

