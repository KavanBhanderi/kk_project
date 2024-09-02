using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace K_K
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();  
            this.Close();   
            dashboard.Show();   
        }

        private void txtsearchitem_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("itemname LIKE '{0}%'", txtsearchitem.Text);
        }
        public void loaddata()
        {
            string sql = "select * from items";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Class1.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcmb.Text != "-- Select Category --" && txtitem.Text != string.Empty && txtprice.Text != string.Empty)
            {
                string sql = "update items set category='" + txtcmb.Text + "',price='" + txtprice.Text + "' where itemname='" + txtitem.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, Class1.con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MessageBox.Show("Record Update", "Important", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = dt;
                loaddata();
                txtitem.Text = string.Empty;
                txtcmb.Text = "--Select Category--";
                txtprice.Text = string.Empty;


            }
            else
            {
                MessageBox.Show("Not Record Updated", "Important", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string  name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtcmb.Text = category;
            txtitem.Text = name;
            txtprice.Text = price.ToString();

        }

        private void txtcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
