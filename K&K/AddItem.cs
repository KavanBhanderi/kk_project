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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
                string checkSql = "SELECT * FROM items WHERE itemname = '"+txtItem.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(checkSql,Class1.con);
                DataTable dt1 = new DataTable();
                adapter.Fill(dt1);
                if (txtcategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid category from the list.", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string selectedCategory = txtcategory.SelectedItem.ToString();
                if (dt1.Rows.Count == 0)
                {
                    string sql = "insert into items values('" + selectedCategory + "','" + txtItem.Text + "','" + txtprice.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(sql, Class1.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show("Record Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItem.Text = string.Empty;
                    txtcategory.Text = "--Select Category--";
                    txtprice.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Item Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Not Inserted","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        private void exit_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard(); 
            this.Close();
            db.Show();
        }

       
       

        private void plcorder_Click_1(object sender, EventArgs e)
        {
            PlaceOrder placeOrder = new PlaceOrder();
            this.Close();
            placeOrder.Show();
        }

        private void additm_Click(object sender, EventArgs e)
        {
            AddItem additm = new AddItem();
            additm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            this.Close();
            update.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            this.Close();
            remove.Show();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                txtItem.ForeColor = Color.Red;
                MessageBox.Show("Please Only Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtItem.ForeColor = Color.Black;
            }
        }

      

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                txtprice.ForeColor = Color.Red;
                MessageBox.Show("Please Only Numeric","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtprice.ForeColor = Color.Black;
            }
        }
    }
}
