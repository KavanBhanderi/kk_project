namespace K_K
{
    partial class AddItem
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
            this.Category = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.Add_Item = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.Black;
            this.Category.Location = new System.Drawing.Point(30, 91);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(99, 22);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category :";
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // item_name
            // 
            this.item_name.AutoSize = true;
            this.item_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.ForeColor = System.Drawing.Color.Black;
            this.item_name.Location = new System.Drawing.Point(30, 175);
            this.item_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(119, 22);
            this.item_name.TabIndex = 2;
            this.item_name.Text = "Item Name :";
            this.item_name.Click += new System.EventHandler(this.item_name_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(30, 258);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(70, 22);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price :";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // txtcategory
            // 
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "South Indian",
            "Thali",
            "Indian"});
            this.txtcategory.Location = new System.Drawing.Point(33, 124);
            this.txtcategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(464, 30);
            this.txtcategory.TabIndex = 4;
            this.txtcategory.Text = "--Select Category--";
            this.txtcategory.SelectedIndexChanged += new System.EventHandler(this.txtcategory_SelectedIndexChanged);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(33, 209);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(464, 29);
            this.txtItem.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(33, 292);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(464, 29);
            this.txtprice.TabIndex = 6;
            // 
            // Add_Item
            // 
            this.Add_Item.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_Item.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Item.Location = new System.Drawing.Point(180, 343);
            this.Add_Item.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Item.Name = "Add_Item";
            this.Add_Item.Size = new System.Drawing.Size(124, 32);
            this.Add_Item.TabIndex = 7;
            this.Add_Item.Text = "Add Item";
            this.Add_Item.UseVisualStyleBackColor = false;
            this.Add_Item.Click += new System.EventHandler(this.Add_Item_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(467, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 26);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 410);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Add_Item);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label item_name;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.ComboBox txtcategory;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button Add_Item;
        private System.Windows.Forms.Button exit;
    }
}