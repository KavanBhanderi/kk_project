using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace K_K
{
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
          
        }
        public void loaddata()
        {
            string sql = "select category from items";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Class1.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                selectcmb.Items.Add(dr["category"].ToString());
            }
        }
        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            loaddata();
            search.Text = "Search Item Name";

        }
        private void selectcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = selectcmb.Text;
            string sql = "select itemname from items where category ='" + category + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Class1.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i]["itemname"].ToString());
            }
        }
        private void category_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string category = selectcmb.Text;
            string sql = "select itemname from items where category ='" + category + "'and itemname like '" + search.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Class1.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add(dt.Rows[i]["itemname"].ToString());
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            this.Close();
            dashboard.Show();

        }
        private void search_Enter(object sender, EventArgs e)
        {
            if(search.Text == "Search Item Name")
            {
                search.Text = "";
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if(search.Text == "")
            {
                search.Text = "Search Item Name";
            }
        }
        private void selectcmb_Leave(object sender, EventArgs e)
        {
            if(selectcmb.Text == "")
            {
                selectcmb.Text = "--Select Category--";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Text = "0 ";
            txttotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtitem.Text = text;    

            string query = "select * from items where itemname='"+text+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, Class1.con);
            DataTable dt = new DataTable(); 
            da.Fill(dt);

            txtprice.Text = dt.Rows[0][3].ToString();


        }

        private void txtquantity_ValueChanged(object sender, EventArgs e)
        {
            Int64  quan  = Convert.ToInt64(txtquantity.Value);
            Int64  price = Convert.ToInt64(txtprice.Text);
            txttotal.Text = (quan*price).ToString();
        }

        int amount;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        protected int n, total = 0;
        private void addtocart_Click(object sender, EventArgs e)
        {
            if (txttotal.Text != "0" && txttotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtitem.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtprice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtquantity.Text;
                dataGridView1.Rows[n].Cells[3].Value = txttotal.Text;

                total += int.Parse(txttotal.Text);
                totalrs.Text = "Rs." + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be  1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.RowIndex <= 0)
            {
                dataGridView1.Rows.RemoveAt(rowIndex);
                MessageBox.Show("Deleted Order","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not available Record","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            total -=  amount;
            totalrs.Text = "Rs." + total;
        }

    }
}


