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
    SqlConnection cn = new SqlConnection();
    SqlCommand cm = new SqlCommand();
    DBConnect dbcon = new DBConnect();
    SqlDataReader dr;
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public void Clear()
        {
            txtName.Clear();
            txtPass.Clear();
            txtRePass.Clear();
            txtUsername.Clear();
            cbRole.Text = "";
            txtUsername.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtPass.Text != txtRePass.Text)
                {
                    MessageBox.Show("Password did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);return;
                }
                cn.Open();
                cm = new SqlCommand("Insert into tbUser(username, password, role, name) Values (@username, @password, @role, @name)", cn);
                cm.Parameters.AddwidthValue("@username", txtUsername.Text);
                cm.Parameters.AddwidthValue("@password", txtPass.Text);
                cm.Parameters.AddwidthValue("@role", cbRole.Text);
                cm.Parameters.AddwidthValue("@name", txtName.Text);
                cn.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has been succesfully saved!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch {Exception ex}
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {

        }

        private void UserAccount_Load_1(object sender, EventArgs e)
        {

        }
    }
}
