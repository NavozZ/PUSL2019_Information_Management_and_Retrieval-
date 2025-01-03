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
    public partial class SupplierModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "SuperMarket POS";
        supplier Supplier;
        public SupplierModule(supplier sp)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            Supplier = sp;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtAddress.Clear();
            txtConPerson.Clear();
            txtEmail.Clear();
            txtFaxNo.Clear();
            txtPhone.Clear();
            txtSupplier.Clear();

            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            txtSupplier.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("save this record? click yes to cinfirm.", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Insert into tbSupplier (supplier,address,contactperson,phone,email,fax) values (@supplier,@adress,@contactperson,@phone,@email,@fax)",cn);
                    cm.Parameters.AddWithValue("@supplier",txtSupplier.Text);
                    cm.Parameters.AddWithValue("@adress", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPerson.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved!","Save Record",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    Supplier.Loadsupplier();

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, stitle);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Update this Record? click yes to confirm.","CONFIRM",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Update tbSupplier set supplier=@supplier,address=@address, conatctperson=@contactperson,telephone=@telephone,email=@email,fax=@fax where id=@id", cn);
                    cm.Parameters.AddWithValue("@id", lblid.Text);
                    cm.Parameters.AddWithValue("@supplier", txtSupplier.Text);
                    cm.Parameters.AddWithValue("@adress", txtAddress.Text);
                    cm.Parameters.AddWithValue("@contactperson", txtConPerson.Text);
                    cm.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cm.Parameters.AddWithValue("@email", txtEmail.Text);
                    cm.Parameters.AddWithValue("@fax", txtFaxNo.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "warning");
            }
        }

        
    }

        
}
