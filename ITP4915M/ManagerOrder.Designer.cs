namespace ITP4915M
{
    partial class ManagerOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchDearlerBtn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlCommand3 = new MySql.Data.MySqlClient.MySqlCommand();
            this.Orderlist = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.searchItemBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.clearItemBtn = new System.Windows.Forms.Button();
            this.clearorderBtn = new System.Windows.Forms.Button();
            this.issueOrder = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Orderlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter order number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "View / Edit Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 37);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(538, 103);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search Order";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dealer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dealer name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 37);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 275);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 37);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, 330);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(280, 37);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 176);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dealer detail";
            // 
            // SearchDearlerBtn
            // 
            this.SearchDearlerBtn.Location = new System.Drawing.Point(538, 219);
            this.SearchDearlerBtn.Name = "SearchDearlerBtn";
            this.SearchDearlerBtn.Size = new System.Drawing.Size(215, 40);
            this.SearchDearlerBtn.TabIndex = 12;
            this.SearchDearlerBtn.Text = "Search Dealer";
            this.SearchDearlerBtn.UseVisualStyleBackColor = true;
            this.SearchDearlerBtn.Click += new System.EventHandler(this.SearchDearlerBtn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(251, 384);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(280, 37);
            this.textBox5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 387);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Contact number";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // mySqlCommand3
            // 
            this.mySqlCommand3.CacheAge = 0;
            this.mySqlCommand3.Connection = null;
            this.mySqlCommand3.EnableCaching = false;
            this.mySqlCommand3.Transaction = null;
            // 
            // Orderlist
            // 
            this.Orderlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orderlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.Qty});
            this.Orderlist.Location = new System.Drawing.Point(21, 627);
            this.Orderlist.Name = "Orderlist";
            this.Orderlist.RowHeadersWidth = 62;
            this.Orderlist.RowTemplate.Height = 31;
            this.Orderlist.Size = new System.Drawing.Size(849, 307);
            this.Orderlist.TabIndex = 15;
            this.Orderlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 454);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Part ID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(251, 451);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(280, 37);
            this.textBox6.TabIndex = 17;
            // 
            // searchItemBtn
            // 
            this.searchItemBtn.Location = new System.Drawing.Point(538, 451);
            this.searchItemBtn.Name = "searchItemBtn";
            this.searchItemBtn.Size = new System.Drawing.Size(215, 40);
            this.searchItemBtn.TabIndex = 18;
            this.searchItemBtn.Text = "Search Item";
            this.searchItemBtn.UseVisualStyleBackColor = true;
            this.searchItemBtn.Click += new System.EventHandler(this.searchItemBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 509);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Part Name";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(251, 506);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(280, 37);
            this.textBox7.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 563);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "Quantity";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(538, 560);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(215, 40);
            this.addItemBtn.TabIndex = 23;
            this.addItemBtn.Text = "Add item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // clearItemBtn
            // 
            this.clearItemBtn.Location = new System.Drawing.Point(21, 965);
            this.clearItemBtn.Name = "clearItemBtn";
            this.clearItemBtn.Size = new System.Drawing.Size(215, 40);
            this.clearItemBtn.TabIndex = 24;
            this.clearItemBtn.Text = "Clear Item";
            this.clearItemBtn.UseVisualStyleBackColor = true;
            this.clearItemBtn.Click += new System.EventHandler(this.clearItemBtn_Click);
            // 
            // clearorderBtn
            // 
            this.clearorderBtn.Location = new System.Drawing.Point(336, 965);
            this.clearorderBtn.Name = "clearorderBtn";
            this.clearorderBtn.Size = new System.Drawing.Size(215, 40);
            this.clearorderBtn.TabIndex = 25;
            this.clearorderBtn.Text = "Clear Order";
            this.clearorderBtn.UseVisualStyleBackColor = true;
            this.clearorderBtn.Click += new System.EventHandler(this.clearorderBtn_Click);
            // 
            // issueOrder
            // 
            this.issueOrder.Location = new System.Drawing.Point(655, 965);
            this.issueOrder.Name = "issueOrder";
            this.issueOrder.Size = new System.Drawing.Size(215, 40);
            this.issueOrder.TabIndex = 26;
            this.issueOrder.Text = "Issue Order";
            this.issueOrder.UseVisualStyleBackColor = true;
            this.issueOrder.Click += new System.EventHandler(this.issueOrder_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(252, 564);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(280, 37);
            this.numericUpDown1.TabIndex = 27;
            // 
            // ManagerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 1330);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.issueOrder);
            this.Controls.Add(this.clearorderBtn);
            this.Controls.Add(this.clearItemBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchItemBtn);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Orderlist);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchDearlerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerOrder";
            this.Text = "Manager Order";
            ((System.ComponentModel.ISupportInitialize)(this.Orderlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchDearlerBtn;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand3;
        private System.Windows.Forms.DataGridView Orderlist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button searchItemBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Button clearItemBtn;
        private System.Windows.Forms.Button clearorderBtn;
        private System.Windows.Forms.Button issueOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}