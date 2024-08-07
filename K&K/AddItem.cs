using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace K_K
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        private void Add_Item_Click(object sender, EventArgs e)
        {
            if (txtcategory.Text != "--Select Category--" && txtItem.Text != string.Empty && txtprice.Text != string.Empty)
            {
                string sql = "insert into items values('" + txtcategory.Text + "','" + txtItem.Text + "','" + txtprice.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(sql, Class1.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("Record Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItem.Text = string.Empty;
                txtcategory.Text = string.Empty;
                txtprice.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Not Inserted","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            AddItem addItem = new AddItem(); 
            this.Close();
            db.Show();
        }

        private void Category_Click(object sender, EventArgs e)
        {

        }

        private void item_name_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }
    }
}
