using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_K
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from login where username='" + txtuser.Text +"' AND password='" + txtpass.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.con);
            DataTable dt = new DataTable();
            da.Fill(dt);    
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Succesfully","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username & Password Incoorect","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
