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
    public partial class CategoryModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Category catogory;
        public CategoryModule(Category ct)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            catogory = ct;
        }
        public void Clear()
        {
            TxtCategory.Clear();
            TxtCategory.Focus();
            btnsubmit.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tbcategory(category)VALUES(@category)", cn);
                    cm.Parameters.AddWithValue("@category", TxtCategory.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successful saved.", "POS");
                    Clear();
                   
                }
                catogory.LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to update this category?", "Updtae Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE tbcategory SET category = @category WHERE id LIKE '" + lblid.Text + "'", cn);
                cm.Parameters.AddWithValue("@category", TxtCategory.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("category has been successfully updated.", "POS");
                Clear();
                this.Dispose();
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
