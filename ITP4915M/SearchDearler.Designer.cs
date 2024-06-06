namespace ITP4915M
{
    partial class SearchDearler
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
            this.searchlabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dealerlist = new System.Windows.Forms.DataGridView();
            this.DealerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DearlerTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DealerCodelbl = new System.Windows.Forms.Label();
            this.DealerNamelbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DealerAddresslbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.DearlerTellbl = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dealerlist)).BeginInit();
            this.SuspendLayout();
            // 
            // searchlabel1
            // 
            this.searchlabel1.AutoSize = true;
            this.searchlabel1.Location = new System.Drawing.Point(12, 23);
            this.searchlabel1.Name = "searchlabel1";
            this.searchlabel1.Size = new System.Drawing.Size(124, 24);
            this.searchlabel1.TabIndex = 0;
            this.searchlabel1.Text = "Search Dealer";
            this.searchlabel1.Click += new System.EventHandler(this.searchlabel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(361, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(137, 32);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dealerlist
            // 
            this.dealerlist.AllowUserToDeleteRows = false;
            this.dealerlist.AllowUserToResizeColumns = false;
            this.dealerlist.AllowUserToResizeRows = false;
            this.dealerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealerlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DealerCode,
            this.DealerName,
            this.DealerAddress,
            this.DearlerTel});
            this.dealerlist.Location = new System.Drawing.Point(17, 75);
            this.dealerlist.Name = "dealerlist";
            this.dealerlist.RowHeadersWidth = 62;
            this.dealerlist.RowTemplate.Height = 31;
            this.dealerlist.Size = new System.Drawing.Size(665, 256);
            this.dealerlist.TabIndex = 3;
            this.dealerlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            
            // 
            // DealerCode
            // 
            this.DealerCode.HeaderText = "Dealer Code";
            this.DealerCode.MinimumWidth = 8;
            this.DealerCode.Name = "DealerCode";
            this.DealerCode.ReadOnly = true;
            this.DealerCode.Width = 150;
            // 
            // DealerName
            // 
            this.DealerName.HeaderText = "Dealer Name";
            this.DealerName.MinimumWidth = 8;
            this.DealerName.Name = "DealerName";
            this.DealerName.Width = 150;
            // 
            // DealerAddress
            // 
            this.DealerAddress.HeaderText = "Dealer Address";
            this.DealerAddress.MinimumWidth = 8;
            this.DealerAddress.Name = "DealerAddress";
            this.DealerAddress.Width = 150;
            // 
            // DearlerTel
            // 
            this.DearlerTel.HeaderText = "Dearler Tel";
            this.DearlerTel.MinimumWidth = 8;
            this.DearlerTel.Name = "DearlerTel";
            this.DearlerTel.Width = 150;
            // 
            // DealerCodelbl
            // 
            this.DealerCodelbl.AutoSize = true;
            this.DealerCodelbl.Location = new System.Drawing.Point(22, 363);
            this.DealerCodelbl.Name = "DealerCodelbl";
            this.DealerCodelbl.Size = new System.Drawing.Size(112, 24);
            this.DealerCodelbl.TabIndex = 4;
            this.DealerCodelbl.Text = "Dealer Code";
            this.DealerCodelbl.Click += new System.EventHandler(this.DealerCodelbl_Click);
            // 
            // DealerNamelbl
            // 
            this.DealerNamelbl.AutoSize = true;
            this.DealerNamelbl.Location = new System.Drawing.Point(22, 401);
            this.DealerNamelbl.Name = "DealerNamelbl";
            this.DealerNamelbl.Size = new System.Drawing.Size(118, 24);
            this.DealerNamelbl.TabIndex = 5;
            this.DealerNamelbl.Text = "Dealer Name";
            this.DealerNamelbl.Click += new System.EventHandler(this.DealerNamelbl_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 32);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 398);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 32);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 436);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 32);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // DealerAddresslbl
            // 
            this.DealerAddresslbl.AutoSize = true;
            this.DealerAddresslbl.Location = new System.Drawing.Point(22, 439);
            this.DealerAddresslbl.Name = "DealerAddresslbl";
            this.DealerAddresslbl.Size = new System.Drawing.Size(136, 24);
            this.DealerAddresslbl.TabIndex = 8;
            this.DealerAddresslbl.Text = "Dealer Address";
            this.DealerAddresslbl.Click += new System.EventHandler(this.DealerAddresslbl_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(165, 474);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 32);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DearlerTellbl
            // 
            this.DearlerTellbl.AutoSize = true;
            this.DearlerTellbl.Location = new System.Drawing.Point(22, 477);
            this.DearlerTellbl.Name = "DearlerTellbl";
            this.DearlerTellbl.Size = new System.Drawing.Size(99, 24);
            this.DearlerTellbl.TabIndex = 10;
            this.DearlerTellbl.Text = "Dearler Tel";
            this.DearlerTellbl.Click += new System.EventHandler(this.DearlerTellbl_Click);
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(399, 473);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(137, 32);
            this.applyBtn.TabIndex = 12;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // SearchDearler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 548);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.DearlerTellbl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.DealerAddresslbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DealerNamelbl);
            this.Controls.Add(this.DealerCodelbl);
            this.Controls.Add(this.dealerlist);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchlabel1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchDearler";
            this.Text = "SearchDearler";
            ((System.ComponentModel.ISupportInitialize)(this.dealerlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchlabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dealerlist;
        private System.Windows.Forms.Label DealerCodelbl;
        private System.Windows.Forms.Label DealerNamelbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label DealerAddresslbl;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label DearlerTellbl;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DealerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DearlerTel;
    }
}