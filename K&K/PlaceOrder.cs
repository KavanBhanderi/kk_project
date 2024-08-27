using System;
using System.Data;
using System.Data.SqlClient;
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
    }
}

