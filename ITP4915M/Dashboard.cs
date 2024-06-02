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
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITP4915M
{
    
    public partial class Dashboard : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;

        string searchDealerQuery = "SELECT * FROM dealer";
        List<Panel> listPanel = new List<Panel>();


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
            Orderlist.Rows.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                // Retrieve order details
                string searchOrderQuery = "SELECT * FROM dealer " +
                                        "JOIN `order` ON dealer.DealerCode = `order`.`DealerCode`" +
                                        "JOIN `orderdi` ON `order`.`OrderNumber` = `orderdi`.`OrderNumber`" +
                                        "JOIN `spare` ON `orderdi`.`SparePartNumber` = `spare`.`PartNumber`" +
                                        "WHERE `orderdi`.`OrderNumber` = @orderNumber";

                MySqlCommand command = new MySqlCommand(searchOrderQuery, conn);
                command.Parameters.AddWithValue("@orderNumber", textBox1.Text);

                MySqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    int count = 0;
                    int rowCount = Orderlist.Rows.Count;
                    while (reader.Read())
                    {

                            // Display order details
                            textBox2.Text = reader.GetInt32(0) + ""; // DealerCode
                            textBox3.Text = reader.GetString(1); // DealerName
                            textBox4.Text = reader.GetString(2); // DealerAddress
                            textBox5.Text = reader.GetInt32(3) + ""; // DealerContact
                            Orderlist.Rows.Add();
                            Orderlist.Rows[count].Cells[0].Value = reader.GetInt32(10);//PartID
                            Orderlist.Rows[count].Cells[1].Value = reader.GetString(15);//Part Name
                            Orderlist.Rows[count].Cells[2].Value = reader.GetInt32(11);//Quantity
                        
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("No order found with the given number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void VieOrdBtn_Click(object sender, EventArgs e)
        {
            clearItemBtn.Visible=true;
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

            Orderlist.Rows.Clear();

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

            DateTime time = DateTime.Today;
            String s2 = time.ToString("yyyy-MM-dd");
            int lastInsertedOrderNumber = 0;
            int lastInsertedDINumber = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert order
                    string insertOrder = "INSERT INTO `order` (`OrderNumber`, `DealerCode`, `OrderDate`, `Status`) VALUES (Null, @DearlerCode , @OrderDate , 'A');";
                    using (MySqlCommand command = new MySqlCommand(insertOrder, conn))
                    {
                        command.Parameters.AddWithValue("@DearlerCode", textBox2.Text);
                        command.Parameters.AddWithValue("@OrderDate", s2);
                        command.ExecuteNonQuery();
                    }
                    //Get lastOrderNumber
                    string getLastOrderNumber = "SELECT MAX(OrderNumber)FROM `order`";
                    using (MySqlCommand getLastIdCommand = new MySqlCommand(getLastOrderNumber, conn))
                    {
                        object result = getLastIdCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            lastInsertedOrderNumber = Convert.ToInt32(result);
                        }
                    }
                    // Find max LM_Serial
                    string findmax = "SELECT MAX(LM_Serial)FROM `di`";
                    int maxLM_Serialnum = 0;
                    using (MySqlCommand findmaxcom = new MySqlCommand(findmax, conn))
                    {
                        using (MySqlDataReader maxLM_Serial = findmaxcom.ExecuteReader())
                        {
                            if (maxLM_Serial.Read())
                            {
                                maxLM_Serialnum = maxLM_Serial.GetInt32(0) + 1;
                            }
                        }
                    }
                    // Insert DI
                    string inserDI = "INSERT INTO `di` (`DINumber`, `Date`, `LM_Serial`, `InvoiceInvoiceNumber`) VALUES (NULL, @Date , @LM_Serial , '');";
                    using (MySqlCommand commandinserDI = new MySqlCommand(inserDI, conn))
                    {
                        commandinserDI.Parameters.AddWithValue("@Date", s2);
                        commandinserDI.Parameters.AddWithValue("@LM_Serial", maxLM_Serialnum);
                        commandinserDI.ExecuteNonQuery();
                    }
                    //Get lastDINumber
                    string getlastDINumber = "SELECT MAX(DINumber)FROM `di`";
                    using (MySqlCommand getLastIdCommand = new MySqlCommand(getlastDINumber, conn))
                    {
                        object result = getLastIdCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            lastInsertedDINumber = Convert.ToInt32(result);
                        }
                    }
                    //
                    string inserordersql = "INSERT INTO `orderdi` (`OrderDIID`, `OrderNumber`, `SparePartNumber`, `Quantity`, `Status`, `DiNumber`) VALUES ";

                    // Iterate through the Orderlist and build the VALUES clause
                    for (int i = 0; i < Orderlist.Rows.Count - 1; i++)
                    {
                        inserordersql += $"(NULL, {lastInsertedOrderNumber}, '{Orderlist.Rows[i].Cells[0].Value}', '{Orderlist.Rows[i].Cells[2].Value}', 'Y', {lastInsertedDINumber}),";
                    }

                    // Remove the last comma and execute the query
                    inserordersql = inserordersql.TrimEnd(',');
                    using (MySqlCommand command = new MySqlCommand(inserordersql, conn))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            
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
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Qunantity can't equal to 0");
            }
            else
            {

                Orderlist.Rows.Add(PartID.Text, ParName.Text, numericUpDown1.Text);
            }
        }

        private void Orderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
