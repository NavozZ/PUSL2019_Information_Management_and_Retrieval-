namespace PUSL2019_Information_Management_and_Retrieval_
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.PanelSubSettings = new System.Windows.Forms.Panel();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.btnstore = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.PanelSubRecord = new System.Windows.Forms.Panel();
            this.btnPOSrecord = new System.Windows.Forms.Button();
            this.btnSHistory = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.PanelSubStock = new System.Windows.Forms.Panel();
            this.btnStockAdj = new System.Windows.Forms.Button();
            this.btnStockEntry = new System.Windows.Forms.Button();
            this.btnstock = new System.Windows.Forms.Button();
            this.PanelSubProduct = new System.Windows.Forms.Panel();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTitle.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.PanelSubSettings.SuspendLayout();
            this.PanelSubRecord.SuspendLayout();
            this.PanelSubStock.SuspendLayout();
            this.PanelSubProduct.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.AutoScroll = true;
            this.PanelMain.BackColor = System.Drawing.Color.LightYellow;
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(172, 32);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(857, 608);
            this.PanelMain.TabIndex = 5;
            this.PanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PanelTitle
            // 
            this.PanelTitle.Controls.Add(this.lbltitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(172, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(857, 32);
            this.PanelTitle.TabIndex = 4;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltitle.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbltitle.Location = new System.Drawing.Point(354, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(103, 22);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "TitleName";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidePanel
            // 
            this.SidePanel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.SidePanel.AutoScroll = true;
            this.SidePanel.Controls.Add(this.btnlogout);
            this.SidePanel.Controls.Add(this.PanelSubSettings);
            this.SidePanel.Controls.Add(this.btnSettings);
            this.SidePanel.Controls.Add(this.PanelSubRecord);
            this.SidePanel.Controls.Add(this.btnRecord);
            this.SidePanel.Controls.Add(this.btnSupplier);
            this.SidePanel.Controls.Add(this.PanelSubStock);
            this.SidePanel.Controls.Add(this.btnstock);
            this.SidePanel.Controls.Add(this.PanelSubProduct);
            this.SidePanel.Controls.Add(this.btnProduct);
            this.SidePanel.Controls.Add(this.btndashboard);
            this.SidePanel.Controls.Add(this.panellogo);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(172, 640);
            this.SidePanel.TabIndex = 3;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Location = new System.Drawing.Point(0, 918);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(155, 39);
            this.btnlogout.TabIndex = 12;
            this.btnlogout.Text = "Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // PanelSubSettings
            // 
            this.PanelSubSettings.Controls.Add(this.btnBarcode);
            this.PanelSubSettings.Controls.Add(this.btnstore);
            this.PanelSubSettings.Controls.Add(this.btnUser);
            this.PanelSubSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubSettings.Location = new System.Drawing.Point(0, 782);
            this.PanelSubSettings.Name = "PanelSubSettings";
            this.PanelSubSettings.Size = new System.Drawing.Size(155, 136);
            this.PanelSubSettings.TabIndex = 11;
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarcode.FlatAppearance.BorderSize = 0;
            this.btnBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcode.Location = new System.Drawing.Point(0, 90);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBarcode.Size = new System.Drawing.Size(155, 45);
            this.btnBarcode.TabIndex = 7;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarcode.UseVisualStyleBackColor = false;
            // 
            // btnstore
            // 
            this.btnstore.BackColor = System.Drawing.Color.LimeGreen;
            this.btnstore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstore.FlatAppearance.BorderSize = 0;
            this.btnstore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstore.Location = new System.Drawing.Point(0, 45);
            this.btnstore.Name = "btnstore";
            this.btnstore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnstore.Size = new System.Drawing.Size(155, 45);
            this.btnstore.TabIndex = 6;
            this.btnstore.Text = "Store";
            this.btnstore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstore.UseVisualStyleBackColor = false;
            this.btnstore.Click += new System.EventHandler(this.btnstore_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(155, 45);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "User";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.LightGreen;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(0, 737);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(155, 45);
            this.btnSettings.TabIndex = 10;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // PanelSubRecord
            // 
            this.PanelSubRecord.Controls.Add(this.btnPOSrecord);
            this.PanelSubRecord.Controls.Add(this.btnSHistory);
            this.PanelSubRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubRecord.Location = new System.Drawing.Point(0, 647);
            this.PanelSubRecord.Name = "PanelSubRecord";
            this.PanelSubRecord.Size = new System.Drawing.Size(155, 90);
            this.PanelSubRecord.TabIndex = 9;
            // 
            // btnPOSrecord
            // 
            this.btnPOSrecord.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPOSrecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOSrecord.FlatAppearance.BorderSize = 0;
            this.btnPOSrecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOSrecord.Location = new System.Drawing.Point(0, 45);
            this.btnPOSrecord.Name = "btnPOSrecord";
            this.btnPOSrecord.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPOSrecord.Size = new System.Drawing.Size(155, 45);
            this.btnPOSrecord.TabIndex = 6;
            this.btnPOSrecord.Text = "POS Record";
            this.btnPOSrecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOSrecord.UseVisualStyleBackColor = false;
            this.btnPOSrecord.Click += new System.EventHandler(this.btnPOSrecord_Click);
            // 
            // btnSHistory
            // 
            this.btnSHistory.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSHistory.FlatAppearance.BorderSize = 0;
            this.btnSHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHistory.Location = new System.Drawing.Point(0, 0);
            this.btnSHistory.Name = "btnSHistory";
            this.btnSHistory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSHistory.Size = new System.Drawing.Size(155, 45);
            this.btnSHistory.TabIndex = 5;
            this.btnSHistory.Text = "Sale History";
            this.btnSHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHistory.UseVisualStyleBackColor = false;
            this.btnSHistory.Click += new System.EventHandler(this.btnSHistory_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.LightGreen;
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(0, 602);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(155, 45);
            this.btnRecord.TabIndex = 8;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.LightGreen;
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Location = new System.Drawing.Point(0, 557);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(155, 45);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // PanelSubStock
            // 
            this.PanelSubStock.Controls.Add(this.btnStockAdj);
            this.PanelSubStock.Controls.Add(this.btnStockEntry);
            this.PanelSubStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubStock.Location = new System.Drawing.Point(0, 467);
            this.PanelSubStock.Name = "PanelSubStock";
            this.PanelSubStock.Size = new System.Drawing.Size(155, 90);
            this.PanelSubStock.TabIndex = 6;
            // 
            // btnStockAdj
            // 
            this.btnStockAdj.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStockAdj.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockAdj.FlatAppearance.BorderSize = 0;
            this.btnStockAdj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdj.Location = new System.Drawing.Point(0, 45);
            this.btnStockAdj.Name = "btnStockAdj";
            this.btnStockAdj.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStockAdj.Size = new System.Drawing.Size(155, 45);
            this.btnStockAdj.TabIndex = 6;
            this.btnStockAdj.Text = "Stock Adjustment";
            this.btnStockAdj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockAdj.UseVisualStyleBackColor = false;
            this.btnStockAdj.Click += new System.EventHandler(this.btnStockAdj_Click);
            // 
            // btnStockEntry
            // 
            this.btnStockEntry.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStockEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockEntry.FlatAppearance.BorderSize = 0;
            this.btnStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockEntry.Location = new System.Drawing.Point(0, 0);
            this.btnStockEntry.Name = "btnStockEntry";
            this.btnStockEntry.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStockEntry.Size = new System.Drawing.Size(155, 45);
            this.btnStockEntry.TabIndex = 5;
            this.btnStockEntry.Text = "Stock Entry";
            this.btnStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockEntry.UseVisualStyleBackColor = false;
            this.btnStockEntry.Click += new System.EventHandler(this.btnStockEntry_Click);
            // 
            // btnstock
            // 
            this.btnstock.BackColor = System.Drawing.Color.LightGreen;
            this.btnstock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnstock.FlatAppearance.BorderSize = 0;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstock.Location = new System.Drawing.Point(0, 422);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(155, 45);
            this.btnstock.TabIndex = 5;
            this.btnstock.Text = "in Stock";
            this.btnstock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // PanelSubProduct
            // 
            this.PanelSubProduct.Controls.Add(this.btnBrand);
            this.PanelSubProduct.Controls.Add(this.btnCategory);
            this.PanelSubProduct.Controls.Add(this.btnProductList);
            this.PanelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubProduct.Location = new System.Drawing.Point(0, 290);
            this.PanelSubProduct.Name = "PanelSubProduct";
            this.PanelSubProduct.Size = new System.Drawing.Size(155, 132);
            this.PanelSubProduct.TabIndex = 4;
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.LimeGreen;
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrand.FlatAppearance.BorderSize = 0;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.Location = new System.Drawing.Point(0, 90);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBrand.Size = new System.Drawing.Size(155, 45);
            this.btnBrand.TabIndex = 6;
            this.btnBrand.Text = "Brand";
            this.btnBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrand.UseVisualStyleBackColor = false;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Location = new System.Drawing.Point(0, 45);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(155, 45);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductList.FlatAppearance.BorderSize = 0;
            this.btnProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductList.Location = new System.Drawing.Point(0, 0);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductList.Size = new System.Drawing.Size(155, 45);
            this.btnProductList.TabIndex = 4;
            this.btnProductList.Text = "Product List";
            this.btnProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductList.UseVisualStyleBackColor = false;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.LightGreen;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Location = new System.Drawing.Point(0, 245);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(155, 45);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.LightGreen;
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Location = new System.Drawing.Point(0, 200);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(155, 45);
            this.btndashboard.TabIndex = 2;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.lblUsername);
            this.panellogo.Controls.Add(this.lblAdmin);
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(155, 200);
            this.panellogo.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUsername.Location = new System.Drawing.Point(61, 124);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "UserName";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAdmin.Location = new System.Drawing.Point(63, 153);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(68, 25);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PUSL2019_Information_Management_and_Retrieval_.Properties.Resources.icons8_user_80;
            this.pictureBox1.ErrorImage = global::PUSL2019_Information_Management_and_Retrieval_.Properties.Resources.icons8_user_80;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(64, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1029, 640);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTitle);
            this.Controls.Add(this.SidePanel);
            this.Name = "Main";
            this.Text = "SuperMarket POS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.SidePanel.ResumeLayout(false);
            this.PanelSubSettings.ResumeLayout(false);
            this.PanelSubRecord.ResumeLayout(false);
            this.PanelSubStock.ResumeLayout(false);
            this.PanelSubProduct.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Panel PanelSubSettings;
        private System.Windows.Forms.Button btnstore;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel PanelSubRecord;
        private System.Windows.Forms.Button btnPOSrecord;
        private System.Windows.Forms.Button btnSHistory;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Panel PanelSubStock;
        private System.Windows.Forms.Button btnStockAdj;
        private System.Windows.Forms.Button btnStockEntry;
        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Panel PanelSubProduct;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panellogo;
        public System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnBarcode;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblAdmin;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

