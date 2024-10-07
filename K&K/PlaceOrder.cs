using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace K_K
{
    public partial class PlaceOrder : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        public PlaceOrder()
        {
            InitializeComponent();

            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        public void cleardata()
        {
            selectcmb.Text = "--Select Categroy--";
            listBox1.Items.Clear();
            txtitem.Text = string.Empty;    
            txtprice.Text = string.Empty;
            txtquantity.Text = string.Empty;
            txttotal.Text = string.Empty;
              
        }
        public void loaddata()
        {
            string sql = "select DISTINCT category from items";
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
            if (search.Text == "Search Item Name")
            {
                search.Text = "";
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                search.Text = "Search Item Name";
            }
        }
        private void selectcmb_Leave(object sender, EventArgs e)
        {
            if (selectcmb.Text == "")
            {
                selectcmb.Text = "--Select Category--";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantity.Text = "0";
            txttotal.Clear();

            string text = listBox1.GetItemText(listBox1.SelectedItem);
            txtitem.Text = text;

            string query = "select * from items where itemname='" + text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Class1.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtprice.Text = dt.Rows[0][3].ToString();
            }
            else
            {
                txtprice.Clear();
                MessageBox.Show("Item not found or no data available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txtquantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Convert.ToInt64(txtquantity.Value);
            Int64 price = Convert.ToInt64(txtprice.Text);
            txttotal.Text = (quan * price).ToString();
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
                cleardata();
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be  1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void btnremove_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.RowIndex >= 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                if (!dataGridView1.Rows[rowIndex].IsNewRow)
                {
                   
                    if (dataGridView1.IsCurrentRowDirty)
                    {
                        dataGridView1.EndEdit();
                    }
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Deleted Order", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    total -= amount;
                    totalrs.Text = "Rs." + total;
                }
                else
                {
                    
                    MessageBox.Show("No Data Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Not available Record", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if (customertxt.Text != string.Empty)
                {

                    if (dataGridView1.Rows.Count > 0)
                    {
                        if (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow)
                        {
                            MessageBox.Show("No data available to print. Please enter data first.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        printPreviewDialog1.Document = printDocument1;
                        printPreviewDialog1.ShowDialog();
                        dataGridView1.Rows.Clear();
                        totalrs.Text = "Rs. 00";
                        customertxt.Text = "";
                        cleardata();
                    }
                    else
                    {
                        MessageBox.Show("No data available to print.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Customer name: Not provided","Print Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred: " + ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void plcorder_Click(object sender, EventArgs e)
        {
            PlaceOrder placeOrder = new PlaceOrder();
            this.Close();
            placeOrder.Show();
        }

        private void additm_Click(object sender, EventArgs e)
        {
            AddItem additm = new AddItem(); 
            this.Close();
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

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                search.ForeColor = Color.Red;
                MessageBox.Show("Please Only Character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                search.ForeColor = Color.Black;
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Image backgroundImage = Image.FromFile(@"C:\Kavan\Project\kk_project\Cafe_Logo.jpg");

            float transparency = 0.1f;  
            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMatrix colorMatrix = new ColorMatrix
            {
                Matrix33 = transparency 
            };
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            
            Rectangle destRect = e.MarginBounds; 
            g.DrawImage(
                backgroundImage,
                destRect,
                0, 0,
                backgroundImage.Width,
                backgroundImage.Height,
                GraphicsUnit.Pixel,
                imageAttributes
            );

            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            string titleText = "K & K Cafe";
            SizeF titleSize = g.MeasureString(titleText,font);

            
            float z = (e.MarginBounds.Width - titleSize.Width) / 2 + e.MarginBounds.Left;
            float h = e.MarginBounds.Top;

            g.DrawString(titleText,new Font("Roman",12,FontStyle.Bold), brush, z,h);
      
            y += 40;

          
            g.DrawString("Customer name : " + customertxt.Text, new Font("Arial", 14, FontStyle.Bold), brush, x, y);
            y += 40;

            
            g.DrawString("Date: " + DateTime.Now.ToString("dd/MM/yyyy"), font, brush, x, y);
            y += 40;

            
            g.DrawString("Item Name", new Font("Roman", 12,FontStyle.Bold) , brush, x, y);
            g.DrawString("Unit Price", new Font("Roman", 12, FontStyle.Bold), brush, x+200, y);
            g.DrawString("Quantity", new Font("Roman", 12, FontStyle.Bold), brush, x + 300, y);
            g.DrawString("Price",  new Font("Roman", 12, FontStyle.Bold), brush, x + 400, y);
            y += 20;
            g.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
            y += 10;

    
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                g.DrawString(row.Cells[0].Value.ToString() ?? string.Empty, font, brush, x, y);
                g.DrawString(row.Cells[1].Value.ToString() ?? string.Empty, font, brush, x+200, y);
                g.DrawString(row.Cells[2].Value.ToString() ?? string.Empty, font, brush, x + 300, y);
                g.DrawString(row.Cells[3].Value.ToString() ?? string.Empty, font, brush, x + 400, y);
                y += 20;
            }

            y += 20;
            g.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
            y += 10;

            g.DrawString("Total Amount:", font, brush, x, y);
            g.DrawString(totalrs.Text, font, brush, x + 400, y);

            y += 30;
            g.DrawString("Thank you for visiting!", new Font(FontFamily.GenericSerif, 15, FontStyle.Bold), brush, x+200, y+200);

        }

    }
}


