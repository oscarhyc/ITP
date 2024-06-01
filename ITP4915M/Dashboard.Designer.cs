namespace ITP4915M
{
    partial class Dashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.issueOrderBtn = new System.Windows.Forms.Button();
            this.clearorderBtn = new System.Windows.Forms.Button();
            this.clearItemBtn = new System.Windows.Forms.Button();
            this.Orderlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ParName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchItemBtn = new System.Windows.Forms.Button();
            this.PartID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchDearlerBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SercOrdBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EntOrdNum = new System.Windows.Forms.Label();
            this.VieOrdBtn = new System.Windows.Forms.Button();
            this.CreOrdBtn = new System.Windows.Forms.Button();
            this.delOrdBtn = new System.Windows.Forms.Button();
            this.updOrdBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orderlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manage Sales Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dispatch Processing";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 120);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inventory Control";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 176);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "Data Maintenance";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 232);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "System Control";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1427, 122);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 122);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1016);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.updOrdBtn);
            this.panel4.Controls.Add(this.delOrdBtn);
            this.panel4.Controls.Add(this.issueOrderBtn);
            this.panel4.Controls.Add(this.clearorderBtn);
            this.panel4.Controls.Add(this.clearItemBtn);
            this.panel4.Controls.Add(this.Orderlist);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.addItemBtn);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.ParName);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.searchItemBtn);
            this.panel4.Controls.Add(this.PartID);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.SearchDearlerBtn);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.SercOrdBtn);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.EntOrdNum);
            this.panel4.Controls.Add(this.VieOrdBtn);
            this.panel4.Controls.Add(this.CreOrdBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(200, 122);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1227, 1016);
            this.panel4.TabIndex = 8;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // issueOrderBtn
            // 
            this.issueOrderBtn.Location = new System.Drawing.Point(650, 716);
            this.issueOrderBtn.Name = "issueOrderBtn";
            this.issueOrderBtn.Size = new System.Drawing.Size(215, 40);
            this.issueOrderBtn.TabIndex = 39;
            this.issueOrderBtn.Text = "Issue Order";
            this.issueOrderBtn.UseVisualStyleBackColor = true;
            this.issueOrderBtn.Click += new System.EventHandler(this.issueOrderBtn_Click);
            // 
            // clearorderBtn
            // 
            this.clearorderBtn.Location = new System.Drawing.Point(331, 716);
            this.clearorderBtn.Name = "clearorderBtn";
            this.clearorderBtn.Size = new System.Drawing.Size(215, 40);
            this.clearorderBtn.TabIndex = 38;
            this.clearorderBtn.Text = "Clear Order";
            this.clearorderBtn.UseVisualStyleBackColor = true;
            this.clearorderBtn.Click += new System.EventHandler(this.clearorderBtn_Click);
            // 
            // clearItemBtn
            // 
            this.clearItemBtn.Location = new System.Drawing.Point(16, 716);
            this.clearItemBtn.Name = "clearItemBtn";
            this.clearItemBtn.Size = new System.Drawing.Size(215, 40);
            this.clearItemBtn.TabIndex = 37;
            this.clearItemBtn.Text = "Clear Item";
            this.clearItemBtn.UseVisualStyleBackColor = true;
            this.clearItemBtn.Click += new System.EventHandler(this.clearItemBtn_Click);
            // 
            // Orderlist
            // 
            this.Orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orderlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.Qty});
            this.Orderlist.Location = new System.Drawing.Point(16, 378);
            this.Orderlist.Name = "Orderlist";
            this.Orderlist.RowHeadersWidth = 62;
            this.Orderlist.RowTemplate.Height = 31;
            this.Orderlist.Size = new System.Drawing.Size(849, 307);
            this.Orderlist.TabIndex = 36;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "Part ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 262;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.HeaderText = "Part name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 261;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(307, 330);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(280, 32);
            this.numericUpDown1.TabIndex = 35;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(588, 327);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(215, 35);
            this.addItemBtn.TabIndex = 34;
            this.addItemBtn.Text = "Add item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 303);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Quantity";
            // 
            // ParName
            // 
            this.ParName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParName.Location = new System.Drawing.Point(16, 328);
            this.ParName.Name = "ParName";
            this.ParName.ReadOnly = true;
            this.ParName.Size = new System.Drawing.Size(280, 32);
            this.ParName.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Part Name";
            // 
            // searchItemBtn
            // 
            this.searchItemBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemBtn.Location = new System.Drawing.Point(588, 264);
            this.searchItemBtn.Name = "searchItemBtn";
            this.searchItemBtn.Size = new System.Drawing.Size(215, 35);
            this.searchItemBtn.TabIndex = 30;
            this.searchItemBtn.Text = "Search Item";
            this.searchItemBtn.UseVisualStyleBackColor = true;
            this.searchItemBtn.Click += new System.EventHandler(this.searchItemBtn_Click);
            // 
            // PartID
            // 
            this.PartID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartID.Location = new System.Drawing.Point(16, 267);
            this.PartID.Name = "PartID";
            this.PartID.Size = new System.Drawing.Size(280, 32);
            this.PartID.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Part ID";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(302, 207);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(280, 32);
            this.textBox5.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contact number";
            // 
            // SearchDearlerBtn
            // 
            this.SearchDearlerBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDearlerBtn.Location = new System.Drawing.Point(588, 145);
            this.SearchDearlerBtn.Name = "SearchDearlerBtn";
            this.SearchDearlerBtn.Size = new System.Drawing.Size(215, 35);
            this.SearchDearlerBtn.TabIndex = 22;
            this.SearchDearlerBtn.Text = "Search Dealer";
            this.SearchDearlerBtn.UseVisualStyleBackColor = true;
            this.SearchDearlerBtn.Click += new System.EventHandler(this.SearchDearlerBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Dealer detail";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(16, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(280, 32);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(302, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(280, 32);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 32);
            this.textBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dealer name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dealer ID";
            // 
            // SercOrdBtn
            // 
            this.SercOrdBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SercOrdBtn.Location = new System.Drawing.Point(483, 53);
            this.SercOrdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SercOrdBtn.Name = "SercOrdBtn";
            this.SercOrdBtn.Size = new System.Drawing.Size(200, 35);
            this.SercOrdBtn.TabIndex = 7;
            this.SercOrdBtn.Text = "Search Order";
            this.SercOrdBtn.UseVisualStyleBackColor = true;
            this.SercOrdBtn.Click += new System.EventHandler(this.SercOrdBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 32);
            this.textBox1.TabIndex = 6;
            // 
            // EntOrdNum
            // 
            this.EntOrdNum.AutoSize = true;
            this.EntOrdNum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntOrdNum.Location = new System.Drawing.Point(12, 59);
            this.EntOrdNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EntOrdNum.Name = "EntOrdNum";
            this.EntOrdNum.Size = new System.Drawing.Size(177, 24);
            this.EntOrdNum.TabIndex = 5;
            this.EntOrdNum.Text = "Enter order number";
            // 
            // VieOrdBtn
            // 
            this.VieOrdBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VieOrdBtn.Location = new System.Drawing.Point(170, 8);
            this.VieOrdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VieOrdBtn.Name = "VieOrdBtn";
            this.VieOrdBtn.Size = new System.Drawing.Size(164, 35);
            this.VieOrdBtn.TabIndex = 4;
            this.VieOrdBtn.Text = "View / Edit Order";
            this.VieOrdBtn.UseVisualStyleBackColor = true;
            this.VieOrdBtn.Click += new System.EventHandler(this.VieOrdBtn_Click);
            // 
            // CreOrdBtn
            // 
            this.CreOrdBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreOrdBtn.Location = new System.Drawing.Point(16, 8);
            this.CreOrdBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreOrdBtn.Name = "CreOrdBtn";
            this.CreOrdBtn.Size = new System.Drawing.Size(146, 35);
            this.CreOrdBtn.TabIndex = 3;
            this.CreOrdBtn.Text = "Create Order";
            this.CreOrdBtn.UseVisualStyleBackColor = true;
            this.CreOrdBtn.Click += new System.EventHandler(this.CreOrdBtn_Click);
            // 
            // delOrdBtn
            // 
            this.delOrdBtn.Location = new System.Drawing.Point(170, 716);
            this.delOrdBtn.Name = "delOrdBtn";
            this.delOrdBtn.Size = new System.Drawing.Size(215, 40);
            this.delOrdBtn.TabIndex = 40;
            this.delOrdBtn.Text = "Delete Order";
            this.delOrdBtn.UseVisualStyleBackColor = true;
            // 
            // updOrdBtn
            // 
            this.updOrdBtn.Location = new System.Drawing.Point(496, 716);
            this.updOrdBtn.Name = "updOrdBtn";
            this.updOrdBtn.Size = new System.Drawing.Size(215, 40);
            this.updOrdBtn.TabIndex = 41;
            this.updOrdBtn.Text = "Update Order";
            this.updOrdBtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 1138);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orderlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button VieOrdBtn;
        private System.Windows.Forms.Button CreOrdBtn;
        private System.Windows.Forms.Button SercOrdBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EntOrdNum;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SearchDearlerBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ParName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button searchItemBtn;
        private System.Windows.Forms.TextBox PartID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button issueOrderBtn;
        private System.Windows.Forms.Button clearorderBtn;
        private System.Windows.Forms.Button clearItemBtn;
        private System.Windows.Forms.DataGridView Orderlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Button updOrdBtn;
        private System.Windows.Forms.Button delOrdBtn;
    }
}