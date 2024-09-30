using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace K_K
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
               /*Form1 f1 = new Form1();  
               this.Close();
               f1.Show();*/
               Application.Exit();  
        }
        private void btnlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fn = new Form1();
            this.Hide();
            fn.Show();
        }
        private void additm_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();
            this.Hide();
           
         
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Update upage = new Update();    
            this.Hide();    
            upage.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Remove rpage = new Remove();
            this.Hide();
            rpage.Show();
        }

        private void plcorder_Click(object sender, EventArgs e)
        {
            PlaceOrder p = new PlaceOrder();
            this.Hide();
            p.Show();
        }
    }
}
