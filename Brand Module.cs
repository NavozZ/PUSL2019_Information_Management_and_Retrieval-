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
    public partial class Brand_Module : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Brand brand;

        public Brand_Module(Brand br)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            this.brand = br;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbBrand(brand)VALUES(@brand)",cn);
                    cm.Parameters.AddWithValue("@brand", TxtBrandN.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful saved.", "POS");
                    Clear();
                    brand.LoardBrand();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           Clear();
        }

        public void Clear()
        { 
            TxtBrandN.Clear();
            btnUpdate.Enabled = false;
            btnsubmit.Enabled = true;
            TxtBrandN.Focus();

        }

        private void Brand_Module_Load(object sender, EventArgs e)
        {

        }

        private void TxtBrandN_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to update this brand?", "Updtae Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbBrand SET brand = @brand WHERE id LIKE '" + lblid.Text + "'",cn);
                cm.ExecuteNonQuery();
                cn.Close() ;
                MessageBox.Show("Brand has been successfully updated.", "POS");
                Clear() ;
                this.Dispose() ;
            }
        }
    }
}
