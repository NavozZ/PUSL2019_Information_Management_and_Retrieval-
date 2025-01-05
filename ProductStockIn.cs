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

namespace PUSL2019_Information_Management_and_Retrieval_
{
    public partial class ProductStock : Form
    {
        SqlConnection cn = new SqlConnection();

        public StockIn StockIn { get; private set; }

        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "SuperMarket POS";
        SqlDataReader dr;
        StockIn stockin;
        public ProductStock(StockIn stk)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            StockIn = stk;
            LoadProduct();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        public void LoadProduct()
        {
            int i = 0;
            dgvProduct.Rows.Clear();
            cm = new SqlCommand("SELECT pcode,pdesc,qty FROM tbProduct WHERE pdesc  LIKE '%" + txtSearch.Text + "%'", cn);
            cn.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvProduct.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                if (StockIn.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter  stock in by name", stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    StockIn.txtStockInBy.Focus();
                    this.Dispose();

                    if (MessageBox.Show("Add this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            cn.Open();
                            cm = new SqlCommand("INSERT INTO tbstockIn (refno,pcode,sdate,stockinby,supplierid)VALUES (@refno , @pcode ,@sdate , @stockinby ,@supplierid) ", cn);
                            cm.Parameters.AddWithValue("@refno", stockin.txtRefNo.Text);
                            cm.Parameters.AddWithValue("@pcode", dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString());
                            cm.Parameters.AddWithValue("@sdate", stockin.dtStockIn.Value);
                            cm.Parameters.AddWithValue("@stockinby", stockin.txtStockInBy.Text);
                            cm.Parameters.AddWithValue("@supplierid", stockin.lblId.Text);
                            cm.ExecuteNonQuery();
                            cn.Close();
                            StockIn.LoadStockIn();
                            MessageBox.Show("SuccessFully Added", stitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, stitle);
                        }
                    }
                }
            }

            
        }
    }
}