namespace ITP4915M
{
    partial class DataMaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btnManageDept = new System.Windows.Forms.Button();
            this.btnManagePost = new System.Windows.Forms.Button();
            this.btnManagePart = new System.Windows.Forms.Button();
            this.btnManageSupplier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageDealer = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._4915DataSet = new ITP4915M._4915DataSet();
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDept = new System.Windows.Forms.Panel();
            this.departmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeptCode = new System.Windows.Forms.TextBox();
            this.btnDeptReset = new System.Windows.Forms.Button();
            this.btnDeptSubmit = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptCode2 = new System.Windows.Forms.Label();
            this.lblDeptName2 = new System.Windows.Forms.Label();
            this.positionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.dataGridViewSupplier = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSupplierReset = new System.Windows.Forms.Button();
            this.btnSupplierSubmit = new System.Windows.Forms.Button();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.staffTableAdapter = new ITP4915M._4915DataSetTableAdapters.staffTableAdapter();
            this.departmentTableAdapter = new ITP4915M._4915DataSetTableAdapters.departmentTableAdapter();
            this.positionTableAdapter = new ITP4915M._4915DataSetTableAdapters.positionTableAdapter();
            this.tableAdapterManager = new ITP4915M._4915DataSetTableAdapters.TableAdapterManager();
            this.dealerTableAdapter = new ITP4915M._4915DataSetTableAdapters.dealerTableAdapter();
            this.spare_supplier_detailTableAdapter = new ITP4915M._4915DataSetTableAdapters.spare_supplier_detailTableAdapter();
            this.spareTableAdapter = new ITP4915M._4915DataSetTableAdapters.spareTableAdapter();
            this.supplierTableAdapter = new ITP4915M._4915DataSetTableAdapters.supplierTableAdapter();
            this.sparesupplierdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelDealer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dealerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dearlerTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDearlerTel = new System.Windows.Forms.TextBox();
            this.btnDealerReset = new System.Windows.Forms.Button();
            this.btnDealerSubmit = new System.Windows.Forms.Button();
            this.txtDealerCode = new System.Windows.Forms.TextBox();
            this.lblDealerCode = new System.Windows.Forms.Label();
            this.txtDealerAddress = new System.Windows.Forms.TextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.lblDearlerTel = new System.Windows.Forms.Label();
            this.lblDealerAddress = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblBinLocation = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblStockQty = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtBinLocation = new System.Windows.Forms.TextBox();
            this.lblPartNumber = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnPartSubmit = new System.Windows.Forms.Button();
            this.btnPartReset = new System.Windows.Forms.Button();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtStockQty = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.dataGridViewPart = new System.Windows.Forms.DataGridView();
            this.categoryCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPart = new System.Windows.Forms.Panel();
            this.lblPostName = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.txtPostName = new System.Windows.Forms.TextBox();
            this.btnPostSubmit = new System.Windows.Forms.Button();
            this.btnPostReset = new System.Windows.Forms.Button();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewPosition = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPosition = new System.Windows.Forms.Panel();
            this.dataGridViewdept = new System.Windows.Forms.DataGridView();
            this.deptNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPost = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDeptCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cboPostCode = new System.Windows.Forms.ComboBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnStaffSubmit = new System.Windows.Forms.Button();
            this.btnStaffReset = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDeptCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionPositionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._4915DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            this.panelDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).BeginInit();
            this.panelSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparesupplierdetailBindingSource)).BeginInit();
            this.panelDealer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPart)).BeginInit();
            this.panelPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).BeginInit();
            this.panelPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.panelStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Location = new System.Drawing.Point(52, 74);
            this.btnManageStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(249, 115);
            this.btnManageStaff.TabIndex = 7;
            this.btnManageStaff.Text = "Manage Staff";
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // btnManageDept
            // 
            this.btnManageDept.Location = new System.Drawing.Point(52, 214);
            this.btnManageDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageDept.Name = "btnManageDept";
            this.btnManageDept.Size = new System.Drawing.Size(249, 115);
            this.btnManageDept.TabIndex = 8;
            this.btnManageDept.Text = "Manage Department";
            this.btnManageDept.UseVisualStyleBackColor = true;
            this.btnManageDept.Click += new System.EventHandler(this.btnManageDept_Click);
            // 
            // btnManagePost
            // 
            this.btnManagePost.Location = new System.Drawing.Point(52, 348);
            this.btnManagePost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManagePost.Name = "btnManagePost";
            this.btnManagePost.Size = new System.Drawing.Size(249, 115);
            this.btnManagePost.TabIndex = 9;
            this.btnManagePost.Text = "Manage Position";
            this.btnManagePost.UseVisualStyleBackColor = true;
            this.btnManagePost.Click += new System.EventHandler(this.btnManagePost_Click);
            // 
            // btnManagePart
            // 
            this.btnManagePart.Location = new System.Drawing.Point(52, 490);
            this.btnManagePart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManagePart.Name = "btnManagePart";
            this.btnManagePart.Size = new System.Drawing.Size(249, 115);
            this.btnManagePart.TabIndex = 10;
            this.btnManagePart.Text = "Manage Parts";
            this.btnManagePart.UseVisualStyleBackColor = true;
            this.btnManagePart.Click += new System.EventHandler(this.btnManagePart_Click);
            // 
            // btnManageSupplier
            // 
            this.btnManageSupplier.Location = new System.Drawing.Point(52, 625);
            this.btnManageSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageSupplier.Name = "btnManageSupplier";
            this.btnManageSupplier.Size = new System.Drawing.Size(249, 115);
            this.btnManageSupplier.TabIndex = 11;
            this.btnManageSupplier.Text = "Manage Supplier";
            this.btnManageSupplier.UseVisualStyleBackColor = true;
            this.btnManageSupplier.Click += new System.EventHandler(this.btnManageSupplier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnManageDealer);
            this.panel1.Controls.Add(this.btnManageSupplier);
            this.panel1.Controls.Add(this.btnManagePart);
            this.panel1.Controls.Add(this.btnManagePost);
            this.panel1.Controls.Add(this.btnManageDept);
            this.panel1.Controls.Add(this.btnManageStaff);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 1655);
            this.panel1.TabIndex = 12;
            // 
            // btnManageDealer
            // 
            this.btnManageDealer.Location = new System.Drawing.Point(51, 769);
            this.btnManageDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageDealer.Name = "btnManageDealer";
            this.btnManageDealer.Size = new System.Drawing.Size(249, 115);
            this.btnManageDealer.TabIndex = 12;
            this.btnManageDealer.Text = "Manage Dealer";
            this.btnManageDealer.UseVisualStyleBackColor = true;
            this.btnManageDealer.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this._4915DataSet;
            // 
            // _4915DataSet
            // 
            this._4915DataSet.DataSetName = "_4915DataSet";
            this._4915DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataMember = "position";
            this.positionBindingSource.DataSource = this._4915DataSet;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this._4915DataSet;
            // 
            // panelDept
            // 
            this.panelDept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDept.Controls.Add(this.departmentDataGridView);
            this.panelDept.Controls.Add(this.txtDeptCode);
            this.panelDept.Controls.Add(this.btnDeptReset);
            this.panelDept.Controls.Add(this.btnDeptSubmit);
            this.panelDept.Controls.Add(this.txtDeptName);
            this.panelDept.Controls.Add(this.lblDeptCode2);
            this.panelDept.Controls.Add(this.lblDeptName2);
            this.panelDept.Location = new System.Drawing.Point(402, 50);
            this.panelDept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDept.Name = "panelDept";
            this.panelDept.Size = new System.Drawing.Size(1401, 1245);
            this.panelDept.TabIndex = 18;
            // 
            // departmentDataGridView
            // 
            this.departmentDataGridView.AutoGenerateColumns = false;
            this.departmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.departmentDataGridView.DataSource = this.departmentBindingSource;
            this.departmentDataGridView.Location = new System.Drawing.Point(63, 817);
            this.departmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.departmentDataGridView.Name = "departmentDataGridView";
            this.departmentDataGridView.RowHeadersWidth = 62;
            this.departmentDataGridView.RowTemplate.Height = 31;
            this.departmentDataGridView.Size = new System.Drawing.Size(1273, 377);
            this.departmentDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeptName";
            this.dataGridViewTextBoxColumn1.HeaderText = "DeptName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeptCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "DeptCode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.Location = new System.Drawing.Point(286, 373);
            this.txtDeptCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.Size = new System.Drawing.Size(257, 32);
            this.txtDeptCode.TabIndex = 18;
            // 
            // btnDeptReset
            // 
            this.btnDeptReset.Location = new System.Drawing.Point(332, 638);
            this.btnDeptReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeptReset.Name = "btnDeptReset";
            this.btnDeptReset.Size = new System.Drawing.Size(211, 83);
            this.btnDeptReset.TabIndex = 17;
            this.btnDeptReset.Text = "Reset";
            this.btnDeptReset.UseVisualStyleBackColor = true;
            this.btnDeptReset.Click += new System.EventHandler(this.btnDeptReset_Click);
            // 
            // btnDeptSubmit
            // 
            this.btnDeptSubmit.Location = new System.Drawing.Point(64, 638);
            this.btnDeptSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeptSubmit.Name = "btnDeptSubmit";
            this.btnDeptSubmit.Size = new System.Drawing.Size(211, 83);
            this.btnDeptSubmit.TabIndex = 16;
            this.btnDeptSubmit.Text = "Submit";
            this.btnDeptSubmit.UseVisualStyleBackColor = true;
            this.btnDeptSubmit.Click += new System.EventHandler(this.btnDeptSubmit_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(286, 163);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(257, 32);
            this.txtDeptName.TabIndex = 5;
            // 
            // lblDeptCode2
            // 
            this.lblDeptCode2.Font = new System.Drawing.Font("PMingLiU", 11F);
            this.lblDeptCode2.Location = new System.Drawing.Point(70, 358);
            this.lblDeptCode2.Name = "lblDeptCode2";
            this.lblDeptCode2.Size = new System.Drawing.Size(126, 91);
            this.lblDeptCode2.TabIndex = 2;
            this.lblDeptCode2.Text = "Department\r\nCode";
            // 
            // lblDeptName2
            // 
            this.lblDeptName2.Font = new System.Drawing.Font("PMingLiU", 11F);
            this.lblDeptName2.Location = new System.Drawing.Point(70, 161);
            this.lblDeptName2.Name = "lblDeptName2";
            this.lblDeptName2.Size = new System.Drawing.Size(126, 98);
            this.lblDeptName2.TabIndex = 0;
            this.lblDeptName2.Text = "Department Name";
            // 
            // positionBindingSource1
            // 
            this.positionBindingSource1.DataMember = "position";
            this.positionBindingSource1.DataSource = this._4915DataSet;
            // 
            // spareBindingSource
            // 
            this.spareBindingSource.DataMember = "spare";
            this.spareBindingSource.DataSource = this._4915DataSet;
            // 
            // panelSupplier
            // 
            this.panelSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSupplier.Controls.Add(this.dataGridViewSupplier);
            this.panelSupplier.Controls.Add(this.txtEmail);
            this.panelSupplier.Controls.Add(this.btnSupplierReset);
            this.panelSupplier.Controls.Add(this.btnSupplierSubmit);
            this.panelSupplier.Controls.Add(this.txtSupplierID);
            this.panelSupplier.Controls.Add(this.lblSupplierID);
            this.panelSupplier.Controls.Add(this.txtTelephone);
            this.panelSupplier.Controls.Add(this.txtSupplierName);
            this.panelSupplier.Controls.Add(this.lblEmail);
            this.panelSupplier.Controls.Add(this.lblTelephone);
            this.panelSupplier.Controls.Add(this.lblSupplierName);
            this.panelSupplier.Location = new System.Drawing.Point(401, 50);
            this.panelSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(1402, 1239);
            this.panelSupplier.TabIndex = 21;
            // 
            // dataGridViewSupplier
            // 
            this.dataGridViewSupplier.AllowUserToAddRows = false;
            this.dataGridViewSupplier.AllowUserToDeleteRows = false;
            this.dataGridViewSupplier.AutoGenerateColumns = false;
            this.dataGridViewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewSupplier.DataSource = this.supplierBindingSource;
            this.dataGridViewSupplier.Location = new System.Drawing.Point(28, 620);
            this.dataGridViewSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSupplier.Name = "dataGridViewSupplier";
            this.dataGridViewSupplier.RowHeadersWidth = 62;
            this.dataGridViewSupplier.RowTemplate.Height = 31;
            this.dataGridViewSupplier.Size = new System.Drawing.Size(1328, 324);
            this.dataGridViewSupplier.TabIndex = 23;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this._4915DataSet;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(290, 409);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 32);
            this.txtEmail.TabIndex = 19;
            // 
            // btnSupplierReset
            // 
            this.btnSupplierReset.Location = new System.Drawing.Point(333, 486);
            this.btnSupplierReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierReset.Name = "btnSupplierReset";
            this.btnSupplierReset.Size = new System.Drawing.Size(211, 83);
            this.btnSupplierReset.TabIndex = 17;
            this.btnSupplierReset.Text = "Reset";
            this.btnSupplierReset.UseVisualStyleBackColor = true;
            this.btnSupplierReset.Click += new System.EventHandler(this.btnSupplierReset_Click);
            // 
            // btnSupplierSubmit
            // 
            this.btnSupplierSubmit.Location = new System.Drawing.Point(65, 486);
            this.btnSupplierSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSupplierSubmit.Name = "btnSupplierSubmit";
            this.btnSupplierSubmit.Size = new System.Drawing.Size(211, 83);
            this.btnSupplierSubmit.TabIndex = 16;
            this.btnSupplierSubmit.Text = "Submit";
            this.btnSupplierSubmit.UseVisualStyleBackColor = true;
            this.btnSupplierSubmit.Click += new System.EventHandler(this.btnSupplierSubmit_Click);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(290, 92);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(256, 32);
            this.txtSupplierID.TabIndex = 15;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.Font = new System.Drawing.Font("PMingLiU", 11F);
            this.lblSupplierID.Location = new System.Drawing.Point(74, 91);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(149, 53);
            this.lblSupplierID.TabIndex = 14;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(289, 300);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(256, 32);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(289, 192);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(257, 32);
            this.txtSupplierName.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("PMingLiU", 11F);
            this.lblEmail.Location = new System.Drawing.Point(74, 408);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(149, 53);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.Font = new System.Drawing.Font("PMingLiU", 11F);
            this.lblTelephone.Location = new System.Drawing.Point(73, 299);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(149, 53);
            this.lblTelephone.TabIndex = 1;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.Font = new System.Drawing.Font("PMingLiU", 11F);
            this.lblSupplierName.Location = new System.Drawing.Point(73, 191);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(149, 53);
            this.lblSupplierName.TabIndex = 0;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // positionTableAdapter
            // 
            this.positionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carrierTableAdapter = null;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.dealerTableAdapter = this.dealerTableAdapter;
            this.tableAdapterManager.deliveryrecordTableAdapter = null;
            this.tableAdapterManager.departmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.didTableAdapter = null;
            this.tableAdapterManager.diTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.orderdiTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.positionTableAdapter = this.positionTableAdapter;
            this.tableAdapterManager.reorderrecord_spareTableAdapter = null;
            this.tableAdapterManager.reorderrecordTableAdapter = null;
            this.tableAdapterManager.spare_stockrecordTableAdapter = null;
            this.tableAdapterManager.spare_supplier_detailTableAdapter = this.spare_supplier_detailTableAdapter;
            this.tableAdapterManager.spareTableAdapter = this.spareTableAdapter;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.stockrecordTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = this.supplierTableAdapter;
            this.tableAdapterManager.UpdateOrder = ITP4915M._4915DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dealerTableAdapter
            // 
            this.dealerTableAdapter.ClearBeforeFill = true;
            // 
            // spare_supplier_detailTableAdapter
            // 
            this.spare_supplier_detailTableAdapter.ClearBeforeFill = true;
            // 
            // spareTableAdapter
            // 
            this.spareTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // sparesupplierdetailBindingSource
            // 
            this.sparesupplierdetailBindingSource.DataMember = "spare_supplier_detail";
            this.sparesupplierdetailBindingSource.DataSource = this._4915DataSet;
            // 
            // panelDealer
            // 
            this.panelDealer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDealer.Controls.Add(this.dataGridView1);
            this.panelDealer.Controls.Add(this.txtDearlerTel);
            this.panelDealer.Controls.Add(this.btnDealerReset);
            this.panelDealer.Controls.Add(this.btnDealerSubmit);
            this.panelDealer.Controls.Add(this.txtDealerCode);
            this.panelDealer.Controls.Add(this.lblDealerCode);
            this.panelDealer.Controls.Add(this.txtDealerAddress);
            this.panelDealer.Controls.Add(this.txtDealerName);
            this.panelDealer.Controls.Add(this.lblDearlerTel);
            this.panelDealer.Controls.Add(this.lblDealerAddress);
            this.panelDealer.Controls.Add(this.lblDealerName);
            this.panelDealer.Location = new System.Drawing.Point(402, 50);
            this.panelDealer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDealer.Name = "panelDealer";
            this.panelDealer.Size = new System.Drawing.Size(1402, 1245);
            this.panelDealer.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dealerCodeDataGridViewTextBoxColumn,
            this.dealerNameDataGridViewTextBoxColumn,
            this.dealerAddressDataGridViewTextBoxColumn,
            this.dearlerTelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dealerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 620);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1328, 324);
            this.dataGridView1.TabIndex = 23;
            // 
            // dealerCodeDataGridViewTextBoxColumn
            // 
            this.dealerCodeDataGridViewTextBoxColumn.DataPropertyName = "DealerCode";
            this.dealerCodeDataGridViewTextBoxColumn.HeaderText = "DealerCode";
            this.dealerCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dealerCodeDataGridViewTextBoxColumn.Name = "dealerCodeDataGridViewTextBoxColumn";
            this.dealerCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dealerNameDataGridViewTextBoxColumn
            // 
            this.dealerNameDataGridViewTextBoxColumn.DataPropertyName = "DealerName";
            this.dealerNameDataGridViewTextBoxColumn.HeaderText = "DealerName";
            this.dealerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dealerNameDataGridViewTextBoxColumn.Name = "dealerNameDataGridViewTextBoxColumn";
            this.dealerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dealerAddressDataGridViewTextBoxColumn
            // 
            this.dealerAddressDataGridViewTextBoxColumn.DataPropertyName = "DealerAddress";
            this.dealerAddressDataGridViewTextBoxColumn.HeaderText = "DealerAddress";
            this.dealerAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dealerAddressDataGridViewTextBoxColumn.Name = "dealerAddressDataGridViewTextBoxColumn";
            this.dealerAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // dearlerTelDataGridViewTextBoxColumn
            // 
            this.dearlerTelDataGridViewTextBoxColumn.DataPropertyName = "DearlerTel";
            this.dearlerTelDataGridViewTextBoxColumn.HeaderText = "DearlerTel";
            this.dearlerTelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dearlerTelDataGridViewTextBoxColumn.Name = "dearlerTelDataGridViewTextBoxColumn";
            this.dearlerTelDataGridViewTextBoxColumn.Width = 150;
            // 
            // dealerBindingSource
            // 
            this.dealerBindingSource.DataMember = "dealer";
            this.dealerBindingSource.DataSource = this._4915DataSet;
            // 
            // txtDearlerTel
            // 
            this.txtDearlerTel.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDearlerTel.Location = new System.Drawing.Point(290, 409);
            this.txtDearlerTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDearlerTel.Name = "txtDearlerTel";
            this.txtDearlerTel.Size = new System.Drawing.Size(256, 32);
            this.txtDearlerTel.TabIndex = 19;
            // 
            // btnDealerReset
            // 
            this.btnDealerReset.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDealerReset.Location = new System.Drawing.Point(336, 495);
            this.btnDealerReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDealerReset.Name = "btnDealerReset";
            this.btnDealerReset.Size = new System.Drawing.Size(211, 83);
            this.btnDealerReset.TabIndex = 17;
            this.btnDealerReset.Text = "Reset";
            this.btnDealerReset.UseVisualStyleBackColor = true;
            this.btnDealerReset.Click += new System.EventHandler(this.btnDealerReset_Click);
            // 
            // btnDealerSubmit
            // 
            this.btnDealerSubmit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDealerSubmit.Location = new System.Drawing.Point(68, 495);
            this.btnDealerSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDealerSubmit.Name = "btnDealerSubmit";
            this.btnDealerSubmit.Size = new System.Drawing.Size(211, 83);
            this.btnDealerSubmit.TabIndex = 16;
            this.btnDealerSubmit.Text = "Submit";
            this.btnDealerSubmit.UseVisualStyleBackColor = true;
            this.btnDealerSubmit.Click += new System.EventHandler(this.btnDealerSubmit_Click);
            // 
            // txtDealerCode
            // 
            this.txtDealerCode.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDealerCode.Location = new System.Drawing.Point(290, 92);
            this.txtDealerCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerCode.Name = "txtDealerCode";
            this.txtDealerCode.Size = new System.Drawing.Size(256, 32);
            this.txtDealerCode.TabIndex = 15;
            // 
            // lblDealerCode
            // 
            this.lblDealerCode.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDealerCode.Location = new System.Drawing.Point(74, 91);
            this.lblDealerCode.Name = "lblDealerCode";
            this.lblDealerCode.Size = new System.Drawing.Size(149, 53);
            this.lblDealerCode.TabIndex = 14;
            this.lblDealerCode.Text = "Dealer Code ";
            // 
            // txtDealerAddress
            // 
            this.txtDealerAddress.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDealerAddress.Location = new System.Drawing.Point(289, 300);
            this.txtDealerAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerAddress.Name = "txtDealerAddress";
            this.txtDealerAddress.Size = new System.Drawing.Size(256, 32);
            this.txtDealerAddress.TabIndex = 6;
            // 
            // txtDealerName
            // 
            this.txtDealerName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDealerName.Location = new System.Drawing.Point(289, 192);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(257, 32);
            this.txtDealerName.TabIndex = 5;
            // 
            // lblDearlerTel
            // 
            this.lblDearlerTel.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDearlerTel.Location = new System.Drawing.Point(74, 408);
            this.lblDearlerTel.Name = "lblDearlerTel";
            this.lblDearlerTel.Size = new System.Drawing.Size(182, 53);
            this.lblDearlerTel.TabIndex = 2;
            this.lblDearlerTel.Text = "Dearler Telephone";
            // 
            // lblDealerAddress
            // 
            this.lblDealerAddress.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDealerAddress.Location = new System.Drawing.Point(73, 299);
            this.lblDealerAddress.Name = "lblDealerAddress";
            this.lblDealerAddress.Size = new System.Drawing.Size(163, 53);
            this.lblDealerAddress.TabIndex = 1;
            this.lblDealerAddress.Text = "Dealer Address";
            // 
            // lblDealerName
            // 
            this.lblDealerName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDealerName.Location = new System.Drawing.Point(73, 191);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(149, 53);
            this.lblDealerName.TabIndex = 0;
            this.lblDealerName.Text = "Dealer Name";
            // 
            // lblPartName
            // 
            this.lblPartName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPartName.Location = new System.Drawing.Point(70, 140);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(149, 53);
            this.lblPartName.TabIndex = 0;
            this.lblPartName.Text = "Part Name";
            // 
            // lblBinLocation
            // 
            this.lblBinLocation.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblBinLocation.Location = new System.Drawing.Point(70, 224);
            this.lblBinLocation.Name = "lblBinLocation";
            this.lblBinLocation.Size = new System.Drawing.Size(149, 53);
            this.lblBinLocation.TabIndex = 1;
            this.lblBinLocation.Text = "Bin Location";
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblWeight.Location = new System.Drawing.Point(70, 308);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(149, 53);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // lblStockQty
            // 
            this.lblStockQty.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblStockQty.Location = new System.Drawing.Point(70, 392);
            this.lblStockQty.Name = "lblStockQty";
            this.lblStockQty.Size = new System.Drawing.Size(149, 53);
            this.lblStockQty.TabIndex = 3;
            this.lblStockQty.Text = "Stock Qty";
            // 
            // txtPartName
            // 
            this.txtPartName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPartName.Location = new System.Drawing.Point(286, 142);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(257, 32);
            this.txtPartName.TabIndex = 5;
            // 
            // txtBinLocation
            // 
            this.txtBinLocation.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtBinLocation.Location = new System.Drawing.Point(286, 226);
            this.txtBinLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBinLocation.Name = "txtBinLocation";
            this.txtBinLocation.Size = new System.Drawing.Size(256, 32);
            this.txtBinLocation.TabIndex = 6;
            // 
            // lblPartNumber
            // 
            this.lblPartNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblPartNumber.Location = new System.Drawing.Point(70, 56);
            this.lblPartNumber.Name = "lblPartNumber";
            this.lblPartNumber.Size = new System.Drawing.Size(149, 53);
            this.lblPartNumber.TabIndex = 14;
            this.lblPartNumber.Text = "Part Number";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPartNumber.Location = new System.Drawing.Point(286, 58);
            this.txtPartNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(256, 32);
            this.txtPartNumber.TabIndex = 15;
            // 
            // btnPartSubmit
            // 
            this.btnPartSubmit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnPartSubmit.Location = new System.Drawing.Point(64, 547);
            this.btnPartSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartSubmit.Name = "btnPartSubmit";
            this.btnPartSubmit.Size = new System.Drawing.Size(211, 83);
            this.btnPartSubmit.TabIndex = 16;
            this.btnPartSubmit.Text = "Submit";
            this.btnPartSubmit.UseVisualStyleBackColor = true;
            this.btnPartSubmit.Click += new System.EventHandler(this.btnPartSubmit_Click);
            // 
            // btnPartReset
            // 
            this.btnPartReset.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnPartReset.Location = new System.Drawing.Point(332, 547);
            this.btnPartReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPartReset.Name = "btnPartReset";
            this.btnPartReset.Size = new System.Drawing.Size(211, 83);
            this.btnPartReset.TabIndex = 17;
            this.btnPartReset.Text = "Reset";
            this.btnPartReset.UseVisualStyleBackColor = true;
            this.btnPartReset.Click += new System.EventHandler(this.btnPartReset_Click);
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCategoryID.Location = new System.Drawing.Point(70, 476);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(149, 53);
            this.lblCategoryID.TabIndex = 18;
            this.lblCategoryID.Text = "Category ID";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtWeight.Location = new System.Drawing.Point(286, 310);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(256, 32);
            this.txtWeight.TabIndex = 19;
            // 
            // txtStockQty
            // 
            this.txtStockQty.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtStockQty.Location = new System.Drawing.Point(286, 394);
            this.txtStockQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStockQty.Name = "txtStockQty";
            this.txtStockQty.Size = new System.Drawing.Size(256, 32);
            this.txtStockQty.TabIndex = 20;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtCategoryID.Location = new System.Drawing.Point(287, 478);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(256, 32);
            this.txtCategoryID.TabIndex = 21;
            // 
            // dataGridViewPart
            // 
            this.dataGridViewPart.AllowUserToAddRows = false;
            this.dataGridViewPart.AutoGenerateColumns = false;
            this.dataGridViewPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNumberDataGridViewTextBoxColumn,
            this.partNameDataGridViewTextBoxColumn,
            this.binLocationDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.stockQtyDataGridViewTextBoxColumn,
            this.categoryCategoryIDDataGridViewTextBoxColumn});
            this.dataGridViewPart.DataSource = this.spareBindingSource;
            this.dataGridViewPart.Location = new System.Drawing.Point(43, 685);
            this.dataGridViewPart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPart.Name = "dataGridViewPart";
            this.dataGridViewPart.RowHeadersWidth = 62;
            this.dataGridViewPart.RowTemplate.Height = 31;
            this.dataGridViewPart.Size = new System.Drawing.Size(1328, 323);
            this.dataGridViewPart.TabIndex = 23;
            // 
            // categoryCategoryIDDataGridViewTextBoxColumn
            // 
            this.categoryCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryCategoryID";
            this.categoryCategoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryCategoryID";
            this.categoryCategoryIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryCategoryIDDataGridViewTextBoxColumn.Name = "categoryCategoryIDDataGridViewTextBoxColumn";
            this.categoryCategoryIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockQtyDataGridViewTextBoxColumn
            // 
            this.stockQtyDataGridViewTextBoxColumn.DataPropertyName = "StockQty";
            this.stockQtyDataGridViewTextBoxColumn.HeaderText = "StockQty";
            this.stockQtyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockQtyDataGridViewTextBoxColumn.Name = "stockQtyDataGridViewTextBoxColumn";
            this.stockQtyDataGridViewTextBoxColumn.Width = 150;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 150;
            // 
            // binLocationDataGridViewTextBoxColumn
            // 
            this.binLocationDataGridViewTextBoxColumn.DataPropertyName = "BinLocation";
            this.binLocationDataGridViewTextBoxColumn.HeaderText = "BinLocation";
            this.binLocationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.binLocationDataGridViewTextBoxColumn.Name = "binLocationDataGridViewTextBoxColumn";
            this.binLocationDataGridViewTextBoxColumn.Width = 150;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "PartName";
            this.partNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            this.partNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // panelPart
            // 
            this.panelPart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPart.Controls.Add(this.dataGridViewPart);
            this.panelPart.Controls.Add(this.txtCategoryID);
            this.panelPart.Controls.Add(this.txtStockQty);
            this.panelPart.Controls.Add(this.txtWeight);
            this.panelPart.Controls.Add(this.lblCategoryID);
            this.panelPart.Controls.Add(this.btnPartReset);
            this.panelPart.Controls.Add(this.btnPartSubmit);
            this.panelPart.Controls.Add(this.txtPartNumber);
            this.panelPart.Controls.Add(this.lblPartNumber);
            this.panelPart.Controls.Add(this.txtBinLocation);
            this.panelPart.Controls.Add(this.txtPartName);
            this.panelPart.Controls.Add(this.lblStockQty);
            this.panelPart.Controls.Add(this.lblWeight);
            this.panelPart.Controls.Add(this.lblBinLocation);
            this.panelPart.Controls.Add(this.lblPartName);
            this.panelPart.Location = new System.Drawing.Point(401, 52);
            this.panelPart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPart.Name = "panelPart";
            this.panelPart.Size = new System.Drawing.Size(1402, 1242);
            this.panelPart.TabIndex = 20;
            // 
            // lblPostName
            // 
            this.lblPostName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostName.Location = new System.Drawing.Point(70, 161);
            this.lblPostName.Name = "lblPostName";
            this.lblPostName.Size = new System.Drawing.Size(126, 77);
            this.lblPostName.TabIndex = 0;
            this.lblPostName.Text = "Position Name";
            // 
            // lblPostCode
            // 
            this.lblPostCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostCode.Location = new System.Drawing.Point(71, 300);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(126, 71);
            this.lblPostCode.TabIndex = 2;
            this.lblPostCode.Text = "Position\r\nCode";
            // 
            // txtPostName
            // 
            this.txtPostName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostName.Location = new System.Drawing.Point(288, 163);
            this.txtPostName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostName.Name = "txtPostName";
            this.txtPostName.Size = new System.Drawing.Size(260, 32);
            this.txtPostName.TabIndex = 5;
            // 
            // btnPostSubmit
            // 
            this.btnPostSubmit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostSubmit.Location = new System.Drawing.Point(64, 638);
            this.btnPostSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostSubmit.Name = "btnPostSubmit";
            this.btnPostSubmit.Size = new System.Drawing.Size(211, 83);
            this.btnPostSubmit.TabIndex = 16;
            this.btnPostSubmit.Text = "Submit";
            this.btnPostSubmit.UseVisualStyleBackColor = true;
            this.btnPostSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPostReset
            // 
            this.btnPostReset.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostReset.Location = new System.Drawing.Point(332, 638);
            this.btnPostReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostReset.Name = "btnPostReset";
            this.btnPostReset.Size = new System.Drawing.Size(211, 83);
            this.btnPostReset.TabIndex = 17;
            this.btnPostReset.Text = "Reset";
            this.btnPostReset.UseVisualStyleBackColor = true;
            this.btnPostReset.Click += new System.EventHandler(this.btnPostReset_Click);
            // 
            // txtPostCode
            // 
            this.txtPostCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostCode.Location = new System.Drawing.Point(286, 301);
            this.txtPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(257, 32);
            this.txtPostCode.TabIndex = 18;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(70, 425);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(137, 55);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(288, 427);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 32);
            this.txtDescription.TabIndex = 20;
            // 
            // dataGridViewPosition
            // 
            this.dataGridViewPosition.AllowUserToAddRows = false;
            this.dataGridViewPosition.AutoGenerateColumns = false;
            this.dataGridViewPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionNameDataGridViewTextBoxColumn1,
            this.positionCodeDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dataGridViewPosition.DataSource = this.positionBindingSource1;
            this.dataGridViewPosition.Location = new System.Drawing.Point(33, 869);
            this.dataGridViewPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPosition.Name = "dataGridViewPosition";
            this.dataGridViewPosition.RowHeadersWidth = 62;
            this.dataGridViewPosition.RowTemplate.Height = 31;
            this.dataGridViewPosition.Size = new System.Drawing.Size(1323, 323);
            this.dataGridViewPosition.TabIndex = 23;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // positionCodeDataGridViewTextBoxColumn1
            // 
            this.positionCodeDataGridViewTextBoxColumn1.DataPropertyName = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn1.HeaderText = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.positionCodeDataGridViewTextBoxColumn1.Name = "positionCodeDataGridViewTextBoxColumn1";
            this.positionCodeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // positionNameDataGridViewTextBoxColumn1
            // 
            this.positionNameDataGridViewTextBoxColumn1.DataPropertyName = "PositionName";
            this.positionNameDataGridViewTextBoxColumn1.HeaderText = "PositionName";
            this.positionNameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.positionNameDataGridViewTextBoxColumn1.Name = "positionNameDataGridViewTextBoxColumn1";
            this.positionNameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // panelPosition
            // 
            this.panelPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPosition.Controls.Add(this.dataGridViewPosition);
            this.panelPosition.Controls.Add(this.txtDescription);
            this.panelPosition.Controls.Add(this.lblDescription);
            this.panelPosition.Controls.Add(this.txtPostCode);
            this.panelPosition.Controls.Add(this.btnPostReset);
            this.panelPosition.Controls.Add(this.btnPostSubmit);
            this.panelPosition.Controls.Add(this.txtPostName);
            this.panelPosition.Controls.Add(this.lblPostCode);
            this.panelPosition.Controls.Add(this.lblPostName);
            this.panelPosition.Location = new System.Drawing.Point(401, 52);
            this.panelPosition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPosition.Name = "panelPosition";
            this.panelPosition.Size = new System.Drawing.Size(1402, 1242);
            this.panelPosition.TabIndex = 19;
            // 
            // dataGridViewdept
            // 
            this.dataGridViewdept.AllowUserToAddRows = false;
            this.dataGridViewdept.AllowUserToDeleteRows = false;
            this.dataGridViewdept.AutoGenerateColumns = false;
            this.dataGridViewdept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewdept.ColumnHeadersHeight = 34;
            this.dataGridViewdept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deptCodeDataGridViewTextBoxColumn,
            this.deptNameDataGridViewTextBoxColumn});
            this.dataGridViewdept.DataSource = this.departmentBindingSource;
            this.dataGridViewdept.Location = new System.Drawing.Point(592, 140);
            this.dataGridViewdept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewdept.Name = "dataGridViewdept";
            this.dataGridViewdept.ReadOnly = true;
            this.dataGridViewdept.RowHeadersWidth = 62;
            this.dataGridViewdept.RowTemplate.Height = 31;
            this.dataGridViewdept.Size = new System.Drawing.Size(763, 391);
            this.dataGridViewdept.TabIndex = 23;
            // 
            // deptNameDataGridViewTextBoxColumn
            // 
            this.deptNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName";
            this.deptNameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.deptNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptNameDataGridViewTextBoxColumn.Name = "deptNameDataGridViewTextBoxColumn";
            this.deptNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptNameDataGridViewTextBoxColumn.Width = 201;
            // 
            // deptCodeDataGridViewTextBoxColumn
            // 
            this.deptCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deptCodeDataGridViewTextBoxColumn.DataPropertyName = "DeptCode";
            this.deptCodeDataGridViewTextBoxColumn.HeaderText = "Department Code";
            this.deptCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deptCodeDataGridViewTextBoxColumn.Name = "deptCodeDataGridViewTextBoxColumn";
            this.deptCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.deptCodeDataGridViewTextBoxColumn.Width = 195;
            // 
            // dataGridViewPost
            // 
            this.dataGridViewPost.AllowUserToAddRows = false;
            this.dataGridViewPost.AllowUserToDeleteRows = false;
            this.dataGridViewPost.AutoGenerateColumns = false;
            this.dataGridViewPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionCodeDataGridViewTextBoxColumn,
            this.positionNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewPost.DataSource = this.positionBindingSource;
            this.dataGridViewPost.Location = new System.Drawing.Point(592, 142);
            this.dataGridViewPost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPost.Name = "dataGridViewPost";
            this.dataGridViewPost.ReadOnly = true;
            this.dataGridViewPost.RowHeadersWidth = 62;
            this.dataGridViewPost.RowTemplate.Height = 31;
            this.dataGridViewPost.Size = new System.Drawing.Size(763, 392);
            this.dataGridViewPost.TabIndex = 24;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionNameDataGridViewTextBoxColumn
            // 
            this.positionNameDataGridViewTextBoxColumn.DataPropertyName = "PositionName";
            this.positionNameDataGridViewTextBoxColumn.HeaderText = "Position Name";
            this.positionNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionNameDataGridViewTextBoxColumn.Name = "positionNameDataGridViewTextBoxColumn";
            this.positionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionCodeDataGridViewTextBoxColumn
            // 
            this.positionCodeDataGridViewTextBoxColumn.DataPropertyName = "PositionCode";
            this.positionCodeDataGridViewTextBoxColumn.HeaderText = "Position Code";
            this.positionCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionCodeDataGridViewTextBoxColumn.Name = "positionCodeDataGridViewTextBoxColumn";
            this.positionCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(70, 161);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 55);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(70, 260);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(126, 55);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptCode.Location = new System.Drawing.Point(71, 372);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(126, 71);
            this.lblDeptCode.TabIndex = 2;
            this.lblDeptCode.Text = "Department \r\nCode";
            this.lblDeptCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 76);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position\r\nCode";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 373);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 32);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown_1);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(286, 163);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 32);
            this.txtName.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(286, 260);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(256, 32);
            this.txtUserName.TabIndex = 6;
            // 
            // cboPostCode
            // 
            this.cboPostCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPostCode.FormattingEnabled = true;
            this.cboPostCode.Items.AddRange(new object[] {
            "Sales",
            "IT"});
            this.cboPostCode.Location = new System.Drawing.Point(287, 503);
            this.cboPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPostCode.Name = "cboPostCode";
            this.cboPostCode.Size = new System.Drawing.Size(256, 32);
            this.cboPostCode.TabIndex = 13;
            this.cboPostCode.DropDown += new System.EventHandler(this.cboPostCode_DropDown);
            this.cboPostCode.SelectedIndexChanged += new System.EventHandler(this.cboPostCode_SelectedIndexChanged);
            // 
            // lblStaffID
            // 
            this.lblStaffID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(70, 56);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(126, 55);
            this.lblStaffID.TabIndex = 14;
            this.lblStaffID.Text = "Staff ID";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(288, 58);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(257, 32);
            this.txtStaffID.TabIndex = 15;
            // 
            // btnStaffSubmit
            // 
            this.btnStaffSubmit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSubmit.Location = new System.Drawing.Point(64, 638);
            this.btnStaffSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStaffSubmit.Name = "btnStaffSubmit";
            this.btnStaffSubmit.Size = new System.Drawing.Size(211, 83);
            this.btnStaffSubmit.TabIndex = 16;
            this.btnStaffSubmit.Text = "Submit";
            this.btnStaffSubmit.UseVisualStyleBackColor = true;
            this.btnStaffSubmit.Click += new System.EventHandler(this.btnStaffSubmit_Click);
            // 
            // btnStaffReset
            // 
            this.btnStaffReset.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffReset.Location = new System.Drawing.Point(332, 638);
            this.btnStaffReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStaffReset.Name = "btnStaffReset";
            this.btnStaffReset.Size = new System.Drawing.Size(211, 83);
            this.btnStaffReset.TabIndex = 17;
            this.btnStaffReset.Text = "Reset";
            this.btnStaffReset.UseVisualStyleBackColor = true;
            this.btnStaffReset.Click += new System.EventHandler(this.btnStaffReset_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AllowUserToAddRows = false;
            this.dataGridViewStaff.AutoGenerateColumns = false;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.departmentDeptCodeDataGridViewTextBoxColumn,
            this.positionPositionCodeDataGridViewTextBoxColumn});
            this.dataGridViewStaff.DataSource = this.staffBindingSource;
            this.dataGridViewStaff.Location = new System.Drawing.Point(28, 871);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 62;
            this.dataGridViewStaff.RowTemplate.Height = 31;
            this.dataGridViewStaff.Size = new System.Drawing.Size(1328, 324);
            this.dataGridViewStaff.TabIndex = 22;
            // 
            // panelStaff
            // 
            this.panelStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStaff.Controls.Add(this.dataGridViewStaff);
            this.panelStaff.Controls.Add(this.btnStaffReset);
            this.panelStaff.Controls.Add(this.btnStaffSubmit);
            this.panelStaff.Controls.Add(this.txtStaffID);
            this.panelStaff.Controls.Add(this.lblStaffID);
            this.panelStaff.Controls.Add(this.cboPostCode);
            this.panelStaff.Controls.Add(this.txtUserName);
            this.panelStaff.Controls.Add(this.txtName);
            this.panelStaff.Controls.Add(this.comboBox1);
            this.panelStaff.Controls.Add(this.label3);
            this.panelStaff.Controls.Add(this.lblDeptCode);
            this.panelStaff.Controls.Add(this.lblUserName);
            this.panelStaff.Controls.Add(this.lblName);
            this.panelStaff.Controls.Add(this.dataGridViewPost);
            this.panelStaff.Controls.Add(this.dataGridViewdept);
            this.panelStaff.Location = new System.Drawing.Point(402, 50);
            this.panelStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(1401, 1245);
            this.panelStaff.TabIndex = 17;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmentDeptCodeDataGridViewTextBoxColumn
            // 
            this.departmentDeptCodeDataGridViewTextBoxColumn.DataPropertyName = "Department Code";
            this.departmentDeptCodeDataGridViewTextBoxColumn.HeaderText = "Department Code";
            this.departmentDeptCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmentDeptCodeDataGridViewTextBoxColumn.Name = "departmentDeptCodeDataGridViewTextBoxColumn";
            this.departmentDeptCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionPositionCodeDataGridViewTextBoxColumn
            // 
            this.positionPositionCodeDataGridViewTextBoxColumn.DataPropertyName = "Position Code";
            this.positionPositionCodeDataGridViewTextBoxColumn.HeaderText = "Position Code";
            this.positionPositionCodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.positionPositionCodeDataGridViewTextBoxColumn.Name = "positionPositionCodeDataGridViewTextBoxColumn";
            this.positionPositionCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // DataMain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1841, 1381);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.panelDept);
            this.Controls.Add(this.panelDealer);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.panelPart);
            this.Controls.Add(this.panelPosition);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DataMain_Form";
            this.Text = "Data maintenance";
            this.Load += new System.EventHandler(this.DataMain_Form_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._4915DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            this.panelDept.ResumeLayout(false);
            this.panelDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spareBindingSource)).EndInit();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sparesupplierdetailBindingSource)).EndInit();
            this.panelDealer.ResumeLayout(false);
            this.panelDealer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPart)).EndInit();
            this.panelPart.ResumeLayout(false);
            this.panelPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosition)).EndInit();
            this.panelPosition.ResumeLayout(false);
            this.panelPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btnManageDept;
        private System.Windows.Forms.Button btnManagePost;
        private System.Windows.Forms.Button btnManagePart;
        private System.Windows.Forms.Button btnManageSupplier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelDept;
        private System.Windows.Forms.Button btnDeptReset;
        private System.Windows.Forms.Button btnDeptSubmit;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptCode2;
        private System.Windows.Forms.Label lblDeptName2;
        private System.Windows.Forms.TextBox txtDeptCode;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSupplierReset;
        private System.Windows.Forms.Button btnSupplierSubmit;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblSupplierName;
        private _4915DataSet _4915DataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private _4915DataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private _4915DataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource positionBindingSource;
        private _4915DataSetTableAdapters.positionTableAdapter positionTableAdapter;
        private System.Windows.Forms.DataGridView departmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private _4915DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewSupplier;
        private _4915DataSetTableAdapters.spare_supplier_detailTableAdapter spare_supplier_detailTableAdapter;
        private System.Windows.Forms.BindingSource sparesupplierdetailBindingSource;
        private _4915DataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private _4915DataSetTableAdapters.spareTableAdapter spareTableAdapter;
        private System.Windows.Forms.BindingSource spareBindingSource;
        private System.Windows.Forms.BindingSource positionBindingSource1;
        private System.Windows.Forms.Button btnManageDealer;
        private System.Windows.Forms.Panel panelDealer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDearlerTel;
        private System.Windows.Forms.Button btnDealerReset;
        private System.Windows.Forms.Button btnDealerSubmit;
        private System.Windows.Forms.TextBox txtDealerCode;
        private System.Windows.Forms.Label lblDealerCode;
        private System.Windows.Forms.TextBox txtDealerAddress;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label lblDearlerTel;
        private System.Windows.Forms.Label lblDealerAddress;
        private System.Windows.Forms.Label lblDealerName;
        private _4915DataSetTableAdapters.dealerTableAdapter dealerTableAdapter;
        private System.Windows.Forms.BindingSource dealerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dearlerTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblBinLocation;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtBinLocation;
        private System.Windows.Forms.Label lblPartNumber;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Button btnPartSubmit;
        private System.Windows.Forms.Button btnPartReset;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtStockQty;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.DataGridView dataGridViewPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn binLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelPart;
        private System.Windows.Forms.Label lblPostName;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox txtPostName;
        private System.Windows.Forms.Button btnPostSubmit;
        private System.Windows.Forms.Button btnPostReset;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dataGridViewPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panelPosition;
        private System.Windows.Forms.DataGridView dataGridViewdept;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDeptCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cboPostCode;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnStaffSubmit;
        private System.Windows.Forms.Button btnStaffReset;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDeptCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionPositionCodeDataGridViewTextBoxColumn;
    }
}