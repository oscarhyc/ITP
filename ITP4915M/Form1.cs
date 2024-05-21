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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ITP4915M
{
    public partial class Form1 : Form
    {
        const string database = "itp4915";
        const string databaseServer = "mysql.sqlpub.com";
        const string databaseUser = "itp4915";
        const string databasePassword = "m3VAiFiSpU70hTqj;";
        const string port = "3306";
        string connectionString =
            $"server={databaseServer};" + $"user={databaseUser};" +
            $"password={databasePassword};" + $"database={database};" +
            "charset=utf8;";

        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection conn = new MySqlConnection();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);



            try
                {
                    conn.Open();
                string query = "SELECT * FROM users WHERE Username = @Username AND Password = @Password";

                // Create a SqlCommand object with the query and connection
                MySqlCommand command = new MySqlCommand(query,  conn);

                // Add parameters to the SqlCommand object
                command.Parameters.AddWithValue("@Username", textBox1.Text);
                command.Parameters.AddWithValue("@Password", textBox2.Text);

                // Execute the query
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    // Valid username and password
                    MessageBox.Show("Login successful!");
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

        }
    }

