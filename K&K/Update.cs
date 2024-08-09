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
    }
}
