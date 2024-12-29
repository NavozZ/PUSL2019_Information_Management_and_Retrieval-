using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PUSL2019_Information_Management_and_Retrieval_
{
    public partial class Main : Form
    {
         SqlConnection cn = new SqlConnection();
         SqlCommand cm = new SqlCommand();
         DBConnect dbcon = new DBConnect();

        public Main()
        {
            InitializeComponent();
            customizedesing();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            
            
        }

        private void customizedesing()
        {
            PanelSubProduct.Visible = false;
            PanelSubRecord.Visible = false;
            PanelSubStock.Visible = false;
            PanelSubSettings.Visible = false;
        }

        private void hideSubmenu()
        { 
            if(PanelSubProduct.Visible == true)
                PanelSubProduct.Visible = false;
            if (PanelSubRecord.Visible == true)
                PanelSubRecord.Visible = false;
            if (PanelSubStock.Visible == true)
                PanelSubStock.Visible = false;
            if (PanelSubSettings.Visible == true)
                PanelSubSettings.Visible = false;
        }
        private void showSubmenu(Panel submenu) 
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelSubProduct);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelSubStock);   
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnStockAdj_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelSubRecord);
        }

        private void btnSHistory_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnPOSrecord_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelSubSettings);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnstore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
