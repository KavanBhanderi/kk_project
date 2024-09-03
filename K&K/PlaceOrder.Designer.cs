namespace K_K
{
    partial class PlaceOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.selectcmb = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.NumericUpDown();
            this.addtocart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totalrs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // selectcmb
            // 
            this.selectcmb.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcmb.FormattingEnabled = true;
            this.selectcmb.Location = new System.Drawing.Point(13, 98);
            this.selectcmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectcmb.Name = "selectcmb";
            this.selectcmb.Size = new System.Drawing.Size(114, 19);
            this.selectcmb.TabIndex = 2;
            this.selectcmb.Text = "--Select Category--";
            this.selectcmb.SelectedIndexChanged += new System.EventHandler(this.selectcmb_SelectedIndexChanged);
            this.selectcmb.Leave += new System.EventHandler(this.selectcmb_Leave);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(9, 133);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(114, 20);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search.TextChanged += new System.EventHandler(this.category_TextChanged);
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 171);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 316);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(535, 7);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 24);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price :";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(170, 98);
            this.txtitem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtitem.Name = "txtitem";
            this.txtitem.ReadOnly = true;
            this.txtitem.Size = new System.Drawing.Size(162, 20);
            this.txtitem.TabIndex = 8;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(391, 96);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(177, 20);
            this.txtprice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(388, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total :";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(391, 171);
            this.txttotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(177, 20);
            this.txttotal.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity :";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(170, 171);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(160, 20);
            this.txtquantity.TabIndex = 13;
            this.txtquantity.ValueChanged += new System.EventHandler(this.txtquantity_ValueChanged);
            // 
            // addtocart
            // 
            this.addtocart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addtocart.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocart.Location = new System.Drawing.Point(302, 220);
            this.addtocart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(133, 24);
            this.addtocart.TabIndex = 14;
            this.addtocart.Text = "Add To Cart";
            this.addtocart.UseVisualStyleBackColor = false;
            this.addtocart.Click += new System.EventHandler(this.addtocart_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(170, 259);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 188);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnremove.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(170, 462);
            this.btnremove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(103, 24);
            this.btnremove.TabIndex = 16;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnprint.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(464, 462);
            this.btnprint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(103, 24);
            this.btnprint.TabIndex = 17;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 449);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grand Total :";
            // 
            // totalrs
            // 
            this.totalrs.AutoSize = true;
            this.totalrs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.totalrs.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalrs.Location = new System.Drawing.Point(338, 469);
            this.totalrs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalrs.Name = "totalrs";
            this.totalrs.Size = new System.Drawing.Size(47, 14);
            this.totalrs.TabIndex = 19;
            this.totalrs.Text = "Rs. 00";
            // 
            // PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 496);
            this.Controls.Add(this.totalrs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.selectcmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceOrder";
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtquantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectcmb;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtquantity;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalrs;
    }
}