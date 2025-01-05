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
    public partial class StockIn : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "SuperMarket POS";

        public object txtConPerson { get; private set; }
        public int Id { get; private set; }

        public StockIn()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadSupplier();
            GetRefeNo();
        }

        public void GetRefeNo()
        {

            Random rnd = new Random();
            txtRefNo.Clear();
            txtRefNo.Text += rnd.Next();

        }

        public void LoadSupplier ()
        {
            cbSupplier.Items.Clear();
            cbSupplier.DataSource = dbcon.getTable("*SELECT* FROM tbSupplier");
            cbSupplier.DisplayMember = "Supplier";
        }

        public void LoadStockIn() 
        {
          int i = 0;
            dgvStockIn.Rows.Clear();
            cn.Open();
            cm= new SqlCommand("SELECT* FROM vwStockIn WHERE refno LIKE'"+txtRefNo.Text+"'AND status LIKE'pending'",cn);
            dr = cm.ExecuteReader();  
            while (dr.Read())
            
            {
                i++;
                dgvStockIn.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }

            dr.Close();
            cn.Close();
        }


        private void CbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("*SELECT*FROM tbSupplier WHERE supplier LIKE '"+cbSupplier.Text+"'",cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                lblId.Text = dr[Id].ToString();
               txtConPerson = dr["contact person"].ToString();
                txtAddress.Text = dr["address"].ToString();


            }
            dr.Close(); 
            cn.Close();


        }

        private void cbSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void LinGenerete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetRefeNo();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       

        private void LinProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStock productStock = new ProductStock(this);
            productStock.ShowDialog();
        }

        private void btnEntry_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvStockIn.Rows.Count > 0)

                {

                    if (MessageBox.Show("Are you sure want to save this record ", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;

                    {
                        for (int i = 0; i < dgvStockIn.Rows.Count; i++)

                        //update product quantity
                        {
                            cn.Open();
                            cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int.Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + "WHERE pcode LIKE" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "''", cn);
                            cm.ExecuteNonQuery();
                            cn.Close();
                        }
                        //update StockIn quantity
                        cn.Open();
                        cm = new SqlCommand("UPDATE tbProduct SET qty = qty + " + int. Parse(dgvStockIn.Rows[i].Cells[5].Value.ToString()) + "status ='Done'WHERE id  LIKE" + dgvStockIn.Rows[i].Cells[3].Value.ToString() + "''", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                    }
                    Clear();
                    LoadStockIn();
                }
            }
            catch (Exception)

            {
                MessageBox.Show(ex.Message, stitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Clear()

        {
            txtRefNo.Clear();
            txtStockInBy.Clear();
            dtStockIn.Value = DateTime.Now; 
        }
        private void DgvStockIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStockIn.Columns[e.ColumnIndex].Name;
            if(colName =="Delete")
            {
                if(MessageBox.Show("Remove this item?", stitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbStockIn WHERE id='" + dgvStockIn.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has been succefully removed",stitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }

        }

        private void DgvInStockHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LinProduct_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductStock productStock = new ProductStock(this);
            productStock.ShowDialog();
        }

       
    }

    internal class DtStockIn
    {
    }
}
