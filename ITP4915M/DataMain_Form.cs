using MySql.Data.MySqlClient;
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

namespace ITP4915M
{
    public partial class DataMain_Form : Form
    {
        string connectionString = DatabaseConfig.ConnectionString;

        public DataMain_Form()
        {
            InitializeComponent();
            panelStaff.Visible = false;
            panelDept.Visible = false;
            panelPosition.Visible = false;
            panelPart.Visible = false;
            panelSupplier.Visible = false;
            panelDealer.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboPostCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPostCode_DropDown(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                dataGridViewdept.Visible = false;
                dataGridViewPost.Visible = true;
                conn.Open();
                string sql = "SELECT DISTINCT PositionCode FROM position";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                cboPostCode.Items.Clear();

                while (reader.Read())
                {
                    cboPostCode.Items.Add(reader["PositionCode"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                dataGridViewPost.Visible = false;
                dataGridViewdept.Visible = true;
                conn.Open();
                string sql = "SELECT DISTINCT DeptCode FROM department";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                comboBox1.Items.Clear();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["DeptCode"].ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void DataMain_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_4915DataSet.dealer' table. You can move, or remove it, as needed.
            this.dealerTableAdapter.Fill(this._4915DataSet.dealer);
            // TODO: This line of code loads data into the '_4915DataSet.spare' table. You can move, or remove it, as needed.
            this.spareTableAdapter.Fill(this._4915DataSet.spare);
            // TODO: This line of code loads data into the '_4915DataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this._4915DataSet.supplier);
            // TODO: This line of code loads data into the '_4915DataSet.spare_supplier_detail' table. You can move, or remove it, as needed.
            this.spare_supplier_detailTableAdapter.Fill(this._4915DataSet.spare_supplier_detail);
            // TODO: This line of code loads data into the '_4915DataSet.position' table. You can move, or remove it, as needed.
            this.positionTableAdapter.Fill(this._4915DataSet.position);
            // TODO: This line of code loads data into the '_4915DataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this._4915DataSet.department);
            // TODO: This line of code loads data into the '_4915DataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this._4915DataSet.staff);

        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            panelDept.Visible = false;
            panelPosition.Visible = false;
            panelPart.Visible = false;
            panelSupplier.Visible = false;
            panelStaff.Visible = true;
            dataGridViewdept.Visible=false;
            dataGridViewPost.Visible=false;
            panelDealer.Visible=false;
            dataGridViewStaff.Visible = true;
        }

        private void btnStaffSubmit_Click(object sender, EventArgs e)
        {
            string staffID = txtStaffID.Text;
            string name = txtName.Text;
            string username = txtUserName.Text;
            string deptCode = comboBox1.Text;
            string positionCode = cboPostCode.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = "INSERT INTO `staff`(`Name`, `Username`, `Staff ID`, `DepartmentDeptCode`, `PositionPositionCode`) " +
                             "VALUES (@name, @username, @staffID, @deptCode, @positionCode)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@staffID", staffID);
                command.Parameters.AddWithValue("@deptCode", deptCode);
                command.Parameters.AddWithValue("@positionCode", positionCode);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Input Success!");
                btnStaffReset_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void btnStaffReset_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtStaffID.Text = "";
            txtName.Text = "";
            txtUserName.Text = "";
            comboBox1.SelectedIndex = -1;
            cboPostCode.SelectedIndex = -1;
        }

        private void btnManageDept_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelPosition.Visible = false;
            panelPart.Visible = false;
            panelSupplier.Visible = false;
            panelDealer.Visible = false;
            panelDept.Visible = true;
        }

        private void btnDeptSubmit_Click(object sender, EventArgs e)
        {
            string deptName = txtDeptName.Text;
            string deptCode = txtDeptCode.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = "INSERT INTO `department`(`DeptName`,`DeptCode`)" +
                             "VALUES (@deptName, @deptCode)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@deptName", deptName);
                command.Parameters.AddWithValue("@deptCode", deptCode);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Input Success!");
                btnDeptReset_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void btnDeptReset_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtDeptName.Text = "";
            txtDeptCode.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string postName = txtPostName.Text;
            string postCode = txtPostCode.Text;
            string desc = txtDescription.Text;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = "INSERT INTO `position`(`PositionName`,`PositionCode`, `Description`)" +
                             "VALUES (@postName, @postCode, @desc)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@postName", postName);
                command.Parameters.AddWithValue("@postCode", postCode);
                command.Parameters.AddWithValue("@desc", desc);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Input Success!");
                btnPostReset_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void btnPostReset_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtPostName.Text = "";
            txtPostCode.Text = "";
            txtDescription.Text = "";
        }

        private void btnManagePost_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelPart.Visible = false;
            panelDept.Visible = false;
            panelSupplier.Visible = false;
            panelDealer.Visible = false;
            panelPosition.Visible = true;
        }

        private void btnPartSubmit_Click(object sender, EventArgs e)
        {
            int partNumber = int.Parse(txtPartNumber.Text);
            string partName = txtPartName.Text;
            string binLocation = txtBinLocation.Text;
            int weight = int.Parse(txtWeight.Text);
            int stockQty = int.Parse(txtStockQty.Text);
            string categoryID = txtCategoryID.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = "INSERT INTO `spare`(`PartNumber`, `PartName`, `BinLocation`, `Weight`, `StockQty`, `CategoryCategoryID`) " +
                             "VALUES (@partNumber, @partName, @binLocation, @weight, @stockQty, @categoryID)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@partNumber", partNumber);
                command.Parameters.AddWithValue("@partName", partName);
                command.Parameters.AddWithValue("@binLocation", binLocation);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@stockQty", stockQty);
                command.Parameters.AddWithValue("@categoryID", categoryID);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Input Success!");
                btnPartReset_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void btnPartReset_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtPartNumber.Text = "";
            txtPartName.Text = "";
            txtBinLocation.Text = "";
            txtWeight.Text = "";
            txtStockQty.Text = "";
            txtCategoryID.Text = "";
        }

        private void btnManagePart_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelPosition.Visible = false;
            panelDept.Visible = false;
            panelSupplier.Visible = false;
            panelDealer.Visible = false;
            panelPart.Visible = true;
        }

        private void btnSupplierSubmit_Click(object sender, EventArgs e)
        {
            string supplierID = txtSupplierID.Text;
            string supplierName = txtSupplierName.Text;
            int telephone = int.Parse(txtTelephone.Text);
            string email = txtEmail.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = "INSERT INTO `supplier`(`SupplierID`, `SupplierName`, `Telephone`, `Email`) " +
                             "VALUES (@supplierID, @supplierName, @telephone, @email)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@supplierID", supplierID);
                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.Parameters.AddWithValue("@telephone", telephone);
                command.Parameters.AddWithValue("@email", email);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Input Success!");
                btnSupplierReset_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void btnSupplierReset_Click(object sender, EventArgs e)
        {
            // Clear the input fields
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtTelephone.Text = "";
            txtEmail.Text = "";
        }

        private void btnManageSupplier_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelDept.Visible = false;
            panelPosition.Visible = false;
            panelPart.Visible = false;
            panelDealer.Visible = false;
            panelSupplier.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelStaff.Visible = false;
            panelDept.Visible = false;
            panelPosition.Visible = false;
            panelPart.Visible = false;
            panelSupplier.Visible = false;
            panelDealer.Visible = true;
        }

        private void btnDealerSubmit_Click(object sender, EventArgs e)
        {
            string dealerCode = txtDealerCode.Text;
            string dealerName = txtDealerName.Text;
            string dealerAddress = txtDealerAddress.Text;
            string dearlerTel = txtDearlerTel.Text;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                String sql = "INSERT INTO `dealer`(`DealerCode`, `DealerName`, `DealerAddress`, `DearlerTel`) " +
                             "VALUES (@dealerCode, @dealerName, @dealerAddress, @dearlerTel)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@dealerCode", dealerCode);
                command.Parameters.AddWithValue("@dealerName", dealerName);
                command.Parameters.AddWithValue("@dealerAddress", dealerAddress);
                command.Parameters.AddWithValue("@dearlerTel", dearlerTel);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Input Success!");
                btnDealerReset_Click(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Contact IT for help");
            }
        }

        private void btnDealerReset_Click(object sender, EventArgs e)
        {
            txtDealerCode.Text = "";
            txtDealerName.Text = "";
            txtDealerAddress.Text = "";
            txtDearlerTel.Text = "";
        }
    }
}
