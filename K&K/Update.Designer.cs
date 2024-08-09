namespace K_K
{
    partial class Update
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
            this.Update_Item = new System.Windows.Forms.Label();
            this.txtitemname = new System.Windows.Forms.Label();
            this.txtsearchitem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_Item
            // 
            this.Update_Item.AutoSize = true;
            this.Update_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Item.Location = new System.Drawing.Point(12, 9);
            this.Update_Item.Name = "Update_Item";
            this.Update_Item.Size = new System.Drawing.Size(109, 20);
            this.Update_Item.TabIndex = 0;
            this.Update_Item.Text = "Update Item";
            // 
            // txtitemname
            // 
            this.txtitemname.AutoSize = true;
            this.txtitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemname.Location = new System.Drawing.Point(232, 27);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(109, 20);
            this.txtitemname.TabIndex = 1;
            this.txtitemname.Text = "Item_name :";
            // 
            // txtsearchitem
            // 
            this.txtsearchitem.Location = new System.Drawing.Point(236, 64);
            this.txtsearchitem.Name = "txtsearchitem";
            this.txtsearchitem.Size = new System.Drawing.Size(218, 20);
            this.txtsearchitem.TabIndex = 2;
            this.txtsearchitem.TextChanged += new System.EventHandler(this.txtsearchitem_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 191);
            this.dataGridView1.TabIndex = 3;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(12, 309);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(91, 20);
            this.category.TabIndex = 4;
            this.category.Text = "Category :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = " Item_name :";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(16, 418);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(169, 20);
            this.txtitem.TabIndex = 7;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(281, 309);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(59, 20);
            this.Price.TabIndex = 8;
            this.Price.Text = "Price :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(285, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(292, 415);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(169, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(430, 6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(24, 23);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtsearchitem);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.Update_Item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Update_Item;
        private System.Windows.Forms.Label txtitemname;
        private System.Windows.Forms.TextBox txtsearchitem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
    }
}