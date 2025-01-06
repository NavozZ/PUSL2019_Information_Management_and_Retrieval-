using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSL2019_Information_Management_and_Retrieval_
{
    public partial class DailySale1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public DailySale1()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

         public void LoadCashier()
        
        {
            cboCashier.Items.Clear();
            cboCashier.Items.Add("Äll cashier");
            cn.Open();
            cm = new SqlCommand("SELECT * From tbUser Where role Like 'Cashier'", cn);
            dr = cm.ExecuteReader();

             while (dr.Read()) 
            
            {
                cboCashier.Items.Add(dr["username"].ToString());
            }
            dr.Close();
            cn.Close();
        }

             public void LoadSold()

        {
            int i = 0;
            double total = 0;
            dgvSold.Rows.Clear();
            cn.Open();
            if (cboCashier.Text =="All Cashier")

             {


                cm = new SqlCommand("select c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.disc,c.total from tbCart as c inner join tbProduct as pon c.pcode=p.pcode where status like 'sold and sdate between' " + dtFrom.Value + "'and' " + dtTo.Value + "'", cn);

            }
                else
              {
                cm = new SqlCommand("select c.id,c.transno,c.pcode,p.pdesc,c.price,c.qty,c.disc,c.total from tbCart as c inner join tbProduct as pon c.pcode=p.pcode where status like 'sold and sdate between' " + dtFrom.Value + "'and' " + dtTo.Value + "and cashier like" + cboCashier.Text + "'", cn);

              }

               dr =cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total+= double.Parse(dr["total"].ToString());
                dgvSold.Rows.Add(i,dr["username"].ToString(), dr["transno"].ToString(), dr["pcode"].ToString(),dr["pdesk"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(), dr["total"].ToString());

            }   
                dr.Close ();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");


        }

        private void dgvCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DailySale1_Load(object sender, EventArgs e)
        {

        }

        private void cboCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSold();
        }

        private void DailySale1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            
            {
                this.Dispose();
            }
        }
    }
}
