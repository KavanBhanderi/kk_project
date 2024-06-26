using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
            //this.Close();
        }

        private void btnlogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fn = new Form1();
            this.Hide();
            fn.Show();
        }

        private void additm_Click(object sender, EventArgs e)
        {
            AddItem additm = new AddItem();
            additm.Show();
            panel2.Hide();
        }
    }
}
