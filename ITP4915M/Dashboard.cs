using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ITP4915M
{

    public partial class Dashboard : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;

        string searchDealerQuery = "SELECT * FROM dealer";
        public static Dashboard instance;



        //private SearchDearler frm2;
        public Dashboard()
        {
            InitializeComponent();
            ResizePanel();
            button1_Click(button1, EventArgs.Empty);
            instance = this;



        }

        private void ResizePanel()
        {
            // Get the current screen resolution
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // Determine the panel size based on the screen resolution
            int panelWidth, panelHeight;
            if (screenWidth >= 3840 && screenHeight >= 2160) // 4K resolution
            {
                panelWidth = (int)(panel1.Width * 1.0);
                panelHeight = (int)(panel1.Height * 1.0);
            }
            else if (screenWidth >= 2560 && screenHeight >= 1440) // 2K resolution
            {
                panelWidth = (int)(panel1.Width * 0.75);
                panelHeight = (int)(panel1.Height * 0.75);
            }
            else // 1080p or lower resolution
            {
                panelWidth = (int)(panel1.Width * 0.50);
                panelHeight = (int)(panel1.Height * 0.50);
            }

            // Resize the panel
            panel1.Size = new Size(panelWidth, panelHeight);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Create Order";
            panel4.BringToFront();
            EntOrdNum.Visible = false;
            textBox1.Visible = false;
            SercOrdBtn.Visible = false;
            delOrdBtn.Visible = false;
            updOrdBtn.Visible = false;
            textBox1.Text = string.Empty;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreOrdBtn_Click(object sender, EventArgs e)
        {
            label1.Text = "Create Order";
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
                string searchOrderQuery = @"
            SELECT
              OrderNumber,
              SparePartNumber,
              PartName,
              Quantity,
              OrderDIID,
              OrderDIStatus,
              DealerCode,
              OrderDate,
              DealerName,
              DealerAddress,
              DearlerTel   
            FROM
                `orderdetailsview`
            WHERE
              OrderNumber = @orderNumber AND
              OrderDIStatus = 'Y'


    ";

                MySqlCommand command = new MySqlCommand(searchOrderQuery, conn);
                command.Parameters.AddWithValue("@orderNumber", textBox1.Text);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {

                    int count = 0;
                    int rowCount = Orderlist.Rows.Count;
                    while (reader.Read())
                    {
                        int dearlerTel = (int)reader["DearlerTel"];
                        int DealerCode = (int)reader["DealerCode"];
                        dateTimePicker1.Value = (DateTime)reader["OrderDate"];
                        textBox2.Text = DealerCode.ToString();
                        textBox3.Text = (string)reader["DealerName"];
                        textBox4.Text = (string)reader["DealerAddress"];
                        textBox5.Text = dearlerTel.ToString();


                        // Display order details
                        Orderlist.Rows.Add();
                        Orderlist.Rows[count].Cells[0].Value = reader.GetInt32("SparePartNumber");
                        Orderlist.Rows[count].Cells[1].Value = reader.GetString("PartName");
                        Orderlist.Rows[count].Cells[2].Value = reader.GetInt32("Quantity");
                        Orderlist.Rows[count].Cells[3].Value = reader.GetInt32("OrderDIID");
                        Orderlist.Rows[count].Cells[4].Value = reader.GetInt32("OrderNumber");
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
            label1.Text = "View Order";
            clearItemBtn.Visible = true;
            clearorderBtn.Visible = false;
            issueOrderBtn.Visible = false;
            SercOrdBtn.Visible = true;
            delOrdBtn.Visible = true;
            updOrdBtn.Visible = true;
            EntOrdNum.Visible = true;
            textBox1.Visible = true;
        }

        private void SearchDearlerBtn_Click(object sender, EventArgs e)
        {
            Form frm2 = new SearchDearler();
            frm2.ShowDialog();

            //try
            //{
            //    frm2 = new SearchDearler(this);
            //    frm2.MdiParent = this;
            //    frm2.Show();
            //    frm2.Visible = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error displaying SearchDearler form: {ex.Message}");
            //    // Log the exception or perform other error handling
            //}

        }


        private void searchItemBtn_Click(object sender, EventArgs e)
        {
            // MySqlConnection conn = new MySqlConnection(connectionString);
            Form frm = new Searchitem();
            frm.ShowDialog();



        }

        private void issueOrderBtn_Click(object sender, EventArgs e)
        {


            String s2 = dateTimePicker1.Text;

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
                    using (MySqlCommand getLastIdCommand = new MySqlCommand(getLastOrderNumber, conn))
                    {
                        object result = getLastIdCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            lastInsertedOrderNumber = Convert.ToInt32(result);
                            MessageBox.Show($"Order Created. The OrderNumber is: {lastInsertedOrderNumber}", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve the last inserted OrderNumber.", "Error");
                        }
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
            int selectedRowIndex = Orderlist.CurrentCell.RowIndex;
            string cellValue = Orderlist.Rows[selectedRowIndex].Cells["OrderDIID"].Value.ToString();
            Orderlist.Rows.RemoveAt(Orderlist.CurrentCell.RowIndex);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string searchOrderQuery = @"
        UPDATE `orderdi` SET `Status` = 'N' WHERE `orderdi`.`OrderDIID` = @OrderDIID;
    ";

                MySqlCommand command = new MySqlCommand(searchOrderQuery, conn);
                command.Parameters.AddWithValue("@OrderDIID", cellValue);

                try
                {
                    // Execute the SQL query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update was successful
                        MessageBox.Show("Order status updated successfully.");
                    }
                    else
                    {
                        // No rows were affected, which means the update was not successful
                        MessageBox.Show("Failed to update order status.");
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle any database-related exceptions
                    MessageBox.Show($"Error updating order status: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void clearorderBtn_Click(object sender, EventArgs e)
        {
            Orderlist.Rows.Clear();
        }


        private void Orderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private void delOrdBtn_Click(object sender, EventArgs e)
        {

            string cellValue = Orderlist.Rows[0].Cells[4].Value.ToString();
            Orderlist.Rows.RemoveAt(Orderlist.CurrentCell.RowIndex);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string searchOrderQuery = @"
        UPDATE `orderdi` SET `Status` = 'N' WHERE `orderdi`.`OrderNumber` = @OrderNumber;
    ";

                MySqlCommand command = new MySqlCommand(searchOrderQuery, conn);
                command.Parameters.AddWithValue("@OrderNumber", cellValue);

                try
                {
                    // Execute the SQL query
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Update was successful
                        Orderlist.Rows.Clear();
                        MessageBox.Show("Order deleted.");
                    }
                    else
                    {
                        // No rows were affected, which means the update was not successful
                        MessageBox.Show("Failed to update order status.");
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle any database-related exceptions
                    MessageBox.Show($"Error updating order status: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void updOrdBtn_Click(object sender, EventArgs e)
        {

            int count = 0;
            int rowCount = Orderlist.Rows.Count;



            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {conn.Open();



                string update_query = "UPDATE `orderdi` SET `Quantity` = @Quantity WHERE `OrderDIID` = @OrderDIID";

                MySqlCommand updateCommand = new MySqlCommand(update_query, conn);

                for (int i = 0; i < rowCount-1; i++)
                {
                    object quantityObj = Orderlist.Rows[i].Cells[2].Value;
                    object orderDIIDObj = Orderlist.Rows[i].Cells[3].Value;

                    if (quantityObj != null && quantityObj != DBNull.Value && orderDIIDObj != null && orderDIIDObj != DBNull.Value)
                    {
                        try
                        {
                            int newQuantity = Convert.ToInt32(quantityObj);
                            int orderDIID = Convert.ToInt32(orderDIIDObj);

                            updateCommand.Parameters.Clear();
                            updateCommand.Parameters.AddWithValue("@Quantity", newQuantity);
                            updateCommand.Parameters.AddWithValue("@OrderDIID", orderDIID);

                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Update was successful
                                MessageBox.Show($"Quantity updated for OrderDIID: {orderDIID}");
                            }
                            else
                            {
                                // Update failed
                                MessageBox.Show($"Failed to update quantity for OrderDIID: {orderDIID}");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle the exception
                            MessageBox.Show($"Error updating quantity for row {i + 1}: {ex.Message}");
                        }
                    }
                    else
                    {
                        // Handle the case where the value is null or DBNull.Value
                        MessageBox.Show($"Missing value in row {i + 1}");
                    }

                    count++;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new DataMain_Form();
            frm.ShowDialog();
        }
    }
            }


        
    

