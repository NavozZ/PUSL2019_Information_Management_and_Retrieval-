using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSL2019_Information_Management_and_Retrieval_
{
    public partial class Supplier_Module : Form
    {
        public Supplier_Module()
        {
            SqlConnection cn = new SqlConnection();
            SqlConnection Command cm = new SqlCommand();
            DBConnect dbcon = new DBConnect();
            string stitle = "Point Of Sales";
            Public SupplierModule()

            {
                InitializeComponent();
                cn = new SqlConnection(dbcon.myConnection());
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {

            }

            private void label7_Click(object sender, EventArgs e)
            {

            }

            private void label9_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click_1(object sender, EventArgs e)
            {
                this.Dispose()
            }

            private void button1_Click(object sender, EventArgs e)
            {

            }
        }

        private void Supplier_Module_Load(object sender, EventArgs e)
        {

        }
    }
}
