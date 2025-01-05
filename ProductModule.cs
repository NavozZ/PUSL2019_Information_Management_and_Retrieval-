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
    public partial class ProductModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "SuperMarket POS";
        Product product;


        public ProductModule(Product pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadBrand();
            LoadCategory();

        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("SELECT * FROM tbcategory");
            cboCategory.DisplayMember = "category";
            cboCategory.ValueMember = "id";
        }


        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = dbcon.getTable("SELECT * FROM tbBrand");
            cboBrand.DisplayMember = "Brand";
            cboBrand.ValueMember = "id";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtPcode.Clear();
            txtBarcode.Clear();
            txtPdesc.Clear();
            txtPrice.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            UDReOrder.Value = 1;

            txtPcode.Enabled = true;
            txtPcode.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirm save action
                if (MessageBox.Show("Are you sure you want to save this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(txtPcode.Text) || string.IsNullOrWhiteSpace(txtBarcode.Text) || string.IsNullOrWhiteSpace(txtPdesc.Text))
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (cboBrand.SelectedValue == null || cboCategory.SelectedValue == null)
                    {
                        MessageBox.Show("Please select valid Brand and Category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
                    {
                        MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Save to database using 'using' for resource management
                    using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
                    {
                        using (SqlCommand cm = new SqlCommand("INSERT INTO tbProduct (pcode, barcode, pdesc, bid, cid, price, reorder) VALUES (@pcode, @barcode, @pdesc, @bid, @cid, @price, @reorder)", cn))
                        {
                            cm.Parameters.AddWithValue("@pcode", txtPcode.Text.Trim());
                            cm.Parameters.AddWithValue("@barcode", txtBarcode.Text.Trim());
                            cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text.Trim());
                            cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                            cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                            cm.Parameters.AddWithValue("@price", price); // Price is already validated
                            cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);

                            cn.Open();
                            cm.ExecuteNonQuery();
                        }
                    }

                    // Success message and post-save actions
                    MessageBox.Show("Product has been successfully saved.", "Save Product");
                    Clear(); // Clear input fields
                    product.LoadProduct(); // Refresh product list (ensure this method is implemented)
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure want to update this product? ", "Update product",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbProduct SET barcode=@barcode,pdesc=@pdesc,bid=@bid,cid=@cid,price=@price , reorder=@reorder WHERE pcode LIKE @pcode",cn);
                    cm = new SqlCommand("INSERT INTO tbProduct (pcode, barcode, pdesc, bid, cid, price, reorder)VALUES (@pcode,@barcode,@pdesc,@bid,@cid,@price,@reorder)", cn);
                    cm.Parameters.AddWithValue("@pcode", txtPcode.Text);
                    cm.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@pdesc", txtPdesc.Text);
                    cm.Parameters.AddWithValue("@bid", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@cid", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                    cm.Parameters.AddWithValue("@reorder", UDReOrder.Value);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully update.", stitle);
                    Clear();
                    this.Dispose();
                }

            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    
}
