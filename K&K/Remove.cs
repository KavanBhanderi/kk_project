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

namespace K_K
{
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("itemname LIKE '{0}%'", txtsearch.Text);
        }

        private void Remove_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            string sql = "select * from items";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,Class1.con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);   
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dashboard db = new dashboard();
            Remove rm = new Remove();
            this.Close();
            db.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?", "Important message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                string sql = "delete from items where id=" + id + "";
                SqlDataAdapter adapter = new SqlDataAdapter( sql,Class1.con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                loaddata();
            }
        }

        
    }
}
