namespace ITP4915M
{
    partial class Searchitem
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
            this.applyBtn = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ItemNamelbl = new System.Windows.Forms.Label();
            this.ItemCodelbl = new System.Windows.Forms.Label();
            this.itemlist = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQunatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchlabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemlist)).BeginInit();
            this.SuspendLayout();
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(469, 506);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(152, 32);
            this.applyBtn.TabIndex = 25;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(201, 557);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 32);
            this.textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 507);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 32);
            this.textBox2.TabIndex = 19;
            // 
            // ItemNamelbl
            // 
            this.ItemNamelbl.AutoSize = true;
            this.ItemNamelbl.Location = new System.Drawing.Point(42, 561);
            this.ItemNamelbl.Name = "ItemNamelbl";
            this.ItemNamelbl.Size = new System.Drawing.Size(102, 24);
            this.ItemNamelbl.TabIndex = 18;
            this.ItemNamelbl.Text = "Item Name";
            // 
            // ItemCodelbl
            // 
            this.ItemCodelbl.AutoSize = true;
            this.ItemCodelbl.Location = new System.Drawing.Point(42, 511);
            this.ItemCodelbl.Name = "ItemCodelbl";
            this.ItemCodelbl.Size = new System.Drawing.Size(96, 24);
            this.ItemCodelbl.TabIndex = 17;
            this.ItemCodelbl.Text = "Item Code";
            // 
            // itemlist
            // 
            this.itemlist.AllowUserToDeleteRows = false;
            this.itemlist.AllowUserToResizeColumns = false;
            this.itemlist.AllowUserToResizeRows = false;
            this.itemlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.ItemName,
            this.ItemWeight,
            this.StockQunatity});
            this.itemlist.Location = new System.Drawing.Point(37, 127);
            this.itemlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemlist.Name = "itemlist";
            this.itemlist.RowHeadersWidth = 62;
            this.itemlist.RowTemplate.Height = 31;
            this.itemlist.Size = new System.Drawing.Size(700, 341);
            this.itemlist.TabIndex = 16;
            this.itemlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemlist_CellContentClick);
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.MinimumWidth = 8;
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 8;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 150;
            // 
            // ItemWeight
            // 
            this.ItemWeight.HeaderText = "Item Weight";
            this.ItemWeight.MinimumWidth = 8;
            this.ItemWeight.Name = "ItemWeight";
            this.ItemWeight.Width = 150;
            // 
            // StockQunatity
            // 
            this.StockQunatity.HeaderText = "StockQunatity";
            this.StockQunatity.MinimumWidth = 8;
            this.StockQunatity.Name = "StockQunatity";
            this.StockQunatity.Width = 150;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(419, 53);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(152, 35);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 32);
            this.textBox1.TabIndex = 14;
            // 
            // searchlabel1
            // 
            this.searchlabel1.AutoSize = true;
            this.searchlabel1.Location = new System.Drawing.Point(31, 57);
            this.searchlabel1.Name = "searchlabel1";
            this.searchlabel1.Size = new System.Drawing.Size(108, 24);
            this.searchlabel1.TabIndex = 13;
            this.searchlabel1.Text = "Search Item";
            // 
            // Searchitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 630);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ItemNamelbl);
            this.Controls.Add(this.ItemCodelbl);
            this.Controls.Add(this.itemlist);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchlabel1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Searchitem";
            this.Text = "Search Item";
            ((System.ComponentModel.ISupportInitialize)(this.itemlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label ItemNamelbl;
        private System.Windows.Forms.Label ItemCodelbl;
        private System.Windows.Forms.DataGridView itemlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQunatity;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label searchlabel1;
    }
}