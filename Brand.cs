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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoardBrand();
        }

        public void LoardBrand()
        {
            int i = 0;
            DgvBrand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tbBrand ORDER BY brand",cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                DgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }


        private void Brand_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Brand_Module moduleForm = new Brand_Module(this);
            moduleForm.ShowDialog();
        }

        private void DgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DgvBrand.Columns[e.ColumnIndex].Name;
            if (colName =="Delete")
            {
                if (MessageBox.Show("Are you sure want to delete this record?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tbBrand WHERE id LIKE '" + DgvBrand[1,e.RowIndex].Value.ToString() + "'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted.","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            else if(colName == "Edit")
            { 
                Brand_Module brand_Module = new Brand_Module(this);
                brand_Module.lblid.Text = DgvBrand[1,e.RowIndex].Value.ToString();
                brand_Module.TxtBrandN.Text = DgvBrand[2,e.RowIndex].Value.ToString();
                brand_Module.btnsubmit.Enabled = false;
                brand_Module.btnUpdate.Enabled = true;
                brand_Module.ShowDialog();
            }
            LoardBrand();
        }
    }
}
