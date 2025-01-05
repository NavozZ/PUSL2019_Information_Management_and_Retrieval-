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

    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void Slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;    
        }
        #region button
        private void btnNTran_Click(object sender, EventArgs e)
        {
            Slide(btnNTran);
            GetTrainNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LookUpProduct lookUp = new LookUpProduct(this);
                lookUp.LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Slide(btnDiscount);
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            Slide(btnSettle);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Slide(btnClear);
        }

        private void btnDSales_Click(object sender, EventArgs e)
        {
            Slide(btnDSales);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            Slide(btnPass);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Slide(btnLogout);
        }
        #endregion button

        public void LoadCart()
        {
            int i = 0;
            double total = 0;
            double discount = 0;
            dgvCash.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT c.id,c.pcode,c.pdesc,c.price,c.qty, c.disc, c.total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode=p.code WHERE c.transno LIKE @transno and c.status LIKE 'pending'",cn);
            cm.Parameters.AddWithValue("@transno",lblTranNo.Text);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                total += Convert.ToDouble(dr["total"].ToString());
                dgvCash.Rows.Add(i, dr["id"].ToString(),dr["pcode"].ToString(),dr["pdesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["disc"].ToString(),double.Parse(dr["total"].ToString()).ToString("#,##0.00"));//
            }
            dr.Close();
            cn.Close();
            lblSaleTotable.Text = total.ToString("#,##0.00"); 
            lblDiscount.Text = discount.ToString("#,##0.00");
            GetCartTotal();
        }
        public void GetCartTotal()
        {
            double discount = double.Parse(lblDiscount.Text);
            double sales = double.Parse(lblSaleTotable.Text) - discount;
            double vat = sales * 0.12;
            double vatable = sales - vat;

            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotale.Text = sales.ToString("#,##0.00");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTrainNo()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string transno = sdate + "1001";
            lblTranNo.Text = transno;
        }

        private void picClose_Click(object sender, EventArgs e)
        {

        }

      
    }
}
