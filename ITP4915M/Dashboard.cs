using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ITP4915M
{
    
    public partial class Dashboard : Form
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
        List<Panel> listPanel = new List<Panel>();

        public string s2 { get; private set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            EntOrdNum.Visible = false;
            textBox1.Visible = false;
            SercOrdBtn.Visible = false;
            delOrdBtn.Visible = false;
            updOrdBtn.Visible = false;  


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreOrdBtn_Click(object sender, EventArgs e)
        {
            EntOrdNum.Visible = false;
            textBox1.Visible = false;
            SercOrdBtn.Visible = false;
            delOrdBtn.Visible = false;
            updOrdBtn.Visible = false;
            clearItemBtn.Visible = true;   
            clearorderBtn.Visible = true;
            issueOrderBtn.Visible = true;

        }

        private void SercOrdBtn_Click(object sender, EventArgs e)
        {

        }

        private void VieOrdBtn_Click(object sender, EventArgs e)
        {
            clearItemBtn.Visible=false;
            clearorderBtn.Visible=false;
            issueOrderBtn.Visible=false;
            SercOrdBtn.Visible=true;
            delOrdBtn.Visible=true;
            updOrdBtn.Visible=true;
            EntOrdNum.Visible=true;
            textBox1.Visible=true;
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

        private void searchItemBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);



            try
            {
                conn.Open();

                string searchPartQuery = "SELECT * FROM `spare` WHERE PartNumber = @PartNumber";
                MySqlCommand command = new MySqlCommand(searchPartQuery, conn);
                command.Parameters.AddWithValue("@PartNumber", PartID.Text);


                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        PartID.Text = reader.GetValue(0) + "";
                        ParName.Text = reader.GetString(1);

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

        private void issueOrderBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                DateTime dt = DateTime.Now;
                s2 = dt.ToString("yyyy-MM-dd");
                string insertOrder = "INSERT INTO `order` (`OrderNumber`, `DealerCode`, `OrderDate`, `Status`) VALUES (Null, @DearlerCode , @OrderDate , 'A');";
                MySqlCommand command = new MySqlCommand(insertOrder, conn);
                command.Parameters.AddWithValue("@DearlerCode", textBox2.Text);
                command.Parameters.AddWithValue("@OrderDate", s2);

                MySqlDataReader reader = command.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "失敗");
            }
        }

        private void clearItemBtn_Click(object sender, EventArgs e)
        {

            Orderlist.Rows.RemoveAt(Orderlist.CurrentCell.RowIndex);

        }

        private void clearorderBtn_Click(object sender, EventArgs e)
        {
            Orderlist.Rows.Clear();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            Orderlist.Rows.Add(PartID.Text, ParName.Text, numericUpDown1.Text);
        }
    }
}
