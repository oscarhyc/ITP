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
    public partial class Login : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;
        private Staff _staff;

        public Login()
        {
            InitializeComponent();
        }
 

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
        



            try
                {
  
                string username = textBox1.Text;
                string password = textBox2.Text;

                // Create a new Staff instance and authenticate
                _staff = new Staff();
                if (_staff.Authenticate(username, password))
                {
                    // Authentication successful
                    //MessageBox.Show($"Welcome, {_staff.Name}!\nStaff ID: {_staff.StaffID}\nDepartment: {_staff.Department}\n");

                    // Open the second form and pass the Staff object
                    if (_staff.Department == "sale")
                    {
                        Dashboard_order form = new Dashboard_order(_staff);
                        form.Show();

                    }else if (_staff.Department == "sys_admin")
                    {
                        Dashboard_dataMaint form = new Dashboard_dataMaint(_staff);
                        form.Show();
                    }
                    else if (_staff.Department == "dispatch")
                    {
                        Dashboard_dispatch form = new Dashboard_dispatch(_staff);
                        form.Show();
                    }
                    else if (_staff.Department == "inventory")
                    {
                        Dashboard_inventory form = new Dashboard_inventory(_staff);
                        form.Show();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

