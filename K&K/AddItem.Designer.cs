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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.label1 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.ComboBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.Add_Item = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.additm = new System.Windows.Forms.Button();
            this.plcorder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Item";
            // 
            // Category
            // 
            this.Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.Black;
            this.Category.Location = new System.Drawing.Point(501, 145);
            this.Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(99, 22);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category :";
            // 
            // item_name
            // 
            this.item_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.item_name.AutoSize = true;
            this.item_name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.ForeColor = System.Drawing.Color.Black;
            this.item_name.Location = new System.Drawing.Point(500, 260);
            this.item_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(119, 22);
            this.item_name.TabIndex = 2;
            this.item_name.Text = "Item Name :";
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.Location = new System.Drawing.Point(501, 380);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(70, 22);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price :";
            // 
            // txtcategory
            // 
            this.txtcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtcategory.FormattingEnabled = true;
            this.txtcategory.Items.AddRange(new object[] {
            "Cake",
            "Soft Drink",
            "South Indian",
            "Thali",
            "Indian"});
            this.txtcategory.Location = new System.Drawing.Point(504, 178);
            this.txtcategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(464, 30);
            this.txtcategory.TabIndex = 4;
            this.txtcategory.Text = "--Select Category--";
            // 
            // txtItem
            // 
            this.txtItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtItem.Location = new System.Drawing.Point(503, 294);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(464, 29);
            this.txtItem.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtprice.Location = new System.Drawing.Point(504, 414);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(464, 29);
            this.txtprice.TabIndex = 6;
            // 
            // Add_Item
            // 
            this.Add_Item.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add_Item.BackColor = System.Drawing.Color.LimeGreen;
            this.Add_Item.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Item.Location = new System.Drawing.Point(653, 514);
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
            this.exit.Location = new System.Drawing.Point(11, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 33);
            this.exit.TabIndex = 8;
            this.exit.Text = "BACK";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.additm);
            this.panel1.Controls.Add(this.plcorder);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 683);
            this.panel1.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(40, 525);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 58);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove Items";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(40, 378);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Items";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // additm
            // 
            this.additm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.additm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.additm.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.additm.Location = new System.Drawing.Point(40, 240);
            this.additm.Margin = new System.Windows.Forms.Padding(4);
            this.additm.Name = "additm";
            this.additm.Size = new System.Drawing.Size(227, 58);
            this.additm.TabIndex = 3;
            this.additm.Text = "Add Items";
            this.additm.UseVisualStyleBackColor = false;
            this.additm.Click += new System.EventHandler(this.additm_Click);
            // 
            // plcorder
            // 
            this.plcorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.plcorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plcorder.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plcorder.Location = new System.Drawing.Point(40, 107);
            this.plcorder.Margin = new System.Windows.Forms.Padding(4);
            this.plcorder.Name = "plcorder";
            this.plcorder.Size = new System.Drawing.Size(227, 58);
            this.plcorder.TabIndex = 2;
            this.plcorder.Text = "Place Order";
            this.plcorder.UseVisualStyleBackColor = false;
            this.plcorder.Click += new System.EventHandler(this.plcorder_Click_1);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 686);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button additm;
        private System.Windows.Forms.Button plcorder;
    }
}