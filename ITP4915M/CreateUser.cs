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
    public partial class CreateUser : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                // check users
                string checkQuery = "SELECT COUNT(*) FROM `staff` WHERE `Username` = @Username;";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@Username", textBox1.Text);

                // 
                int userExists = Convert.ToInt32(checkCommand.ExecuteScalar());
                if (userExists > 0)
                {
                    // 
                    MessageBox.Show("The username already existed");
                    return; // 
                }

                // 
                string query = "INSERT INTO `staff` (`Username`, `Password`) VALUES (@Username, @Password);";
                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@Username", textBox1.Text);
                command.Parameters.AddWithValue("@Password", utils.HashString(textBox2.Text)); //

                command.ExecuteNonQuery(); // 

                MessageBox.Show("Sucess!");
            }
            catch (Exception ex)
            {
                // 
                MessageBox.Show("Fail：" + ex.Message);
            }
            finally
            {
                // 
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE staff SET Password = @NewPassword WHERE Username = @Username";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Username", textBox1.Text);
                    command.Parameters.AddWithValue("@NewPassword", utils.HashString(textBox2.Text)); //

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Password updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Username not found or new password is the same as the old password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fail");
                }
            }
        }
    }
}




