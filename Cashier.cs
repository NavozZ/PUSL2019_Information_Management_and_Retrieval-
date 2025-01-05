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
using ZXing;
using DarrenLee.Media;
using System.Text.RegularExpressions;

namespace PUSL2019_Information_Management_and_Retrieval_
{

    public partial class Cashier : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string stitle = "Point of sales";
        public Cashier()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            GetTrainNo();
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
            Slide(btnSearch);
            LookUpProduct lookup = new LookUpProduct(this);
            lookup.LoadProduct();
            lookup.ShowDialog();
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
            cm = new SqlCommand("SELECT c.id, c.pcode, p.pdesc, c.price, c.qty, c.disc, c.total FROM tbCart AS c INNER JOIN tbProduct AS p ON c.pcode = p.pcode WHERE c.transno LIKE @transno and c.status LIKE 'pending'",cn);
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

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                captureDevice.OnFrameArrived += captureDevice_OnFrameArrived;
                captureDevice.Start();
            }
        }
        
        private void captureDevice_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Bitmap bitmap = (Bitmap)e.GetFrame();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            if(result != null)
            {
                txtBarcod.Invoke(new MethodInvoker(delegate ()
                { txtBarcod.Text = result.ToString(); }));
            }
             
            
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            captureDevice.Stop();
        }
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int Count;
                string transno = sdate + "1001";
                lblTranNo.Text = transno;
                cn.Open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCart WHERE transno LIKE '" + sdate + "%' ORDER BY id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    Count = int.Parse(transno.Substring(8, 4));
                    lblTranNo.Text = sdate + (Count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTranNo.Text = transno;
                }
                dr.Close();
                cn.Close();
            }
            catch(Exception ex)
            {
               cn.Close();
               MessageBox.Show(ex.Message,stitle);
            } 
            
            
        }

        private void picClose_Click(object sender, EventArgs e)
        {

        }

      
    }
}
