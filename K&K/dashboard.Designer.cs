namespace K_K
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.additm = new System.Windows.Forms.Button();
            this.plcorder = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.additm);
            this.panel1.Controls.Add(this.plcorder);
            this.panel1.Location = new System.Drawing.Point(21, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 497);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.AutoSize = true;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(102, 464);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(78, 24);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.TabStop = true;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlogout_LinkClicked);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(46, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove Items";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(46, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Items";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // additm
            // 
            this.additm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.additm.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.additm.Location = new System.Drawing.Point(46, 117);
            this.additm.Name = "additm";
            this.additm.Size = new System.Drawing.Size(170, 47);
            this.additm.TabIndex = 3;
            this.additm.Text = "Add Items";
            this.additm.UseVisualStyleBackColor = false;
            this.additm.Click += new System.EventHandler(this.additm_Click);
            // 
            // plcorder
            // 
            this.plcorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plcorder.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plcorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plcorder.Location = new System.Drawing.Point(46, 43);
            this.plcorder.Name = "plcorder";
            this.plcorder.Size = new System.Drawing.Size(170, 47);
            this.plcorder.TabIndex = 2;
            this.plcorder.Text = "Place Order";
            this.plcorder.UseVisualStyleBackColor = false;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Red;
            this.exitbtn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(821, 9);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(34, 27);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.Text = "X";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(218, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 497);
            this.panel2.TabIndex = 1;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(875, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button plcorder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button additm;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.LinkLabel btnlogout;
    }
}