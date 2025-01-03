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
    public partial class DASHBOARD : Form
    {
        SqlConnection cn = new SqlConnection();
        DBConnect dbcon = new DBConnect();

        public DASHBOARD()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

       /* private void DASHBOARD_Load(object sender, EventArgs e)
        {
            string sdate = DateTime.Now.ToShortDateString();
            lblDailySale.Text = dbcon.ExtractData("SELECT ISNULL(SUM(total),0) AS tatal FROM tbCart WHERE status LIKE 'Sold' AND sdate BETWEEN '" +sdate+ "' AND '" + sdate + "'").ToString("#,##0.00");
            lblTotalProduct.Text = dbcon.ExtractData("SELECT COUNT(*)FROM tbProduct").ToString("#,##0");
            lblStockOnHand.Text = dbcon.ExtractData("SELECT ISNULL(SUM(qty), 0) AS qty FROM tbProduct").ToString("#,##0");
            lblCriticalItems.Text = dbcon.ExtractData("SELECT COUNT(*)FROM vwCriticalItems").ToString("#,##0");
        }*/
    }
}
