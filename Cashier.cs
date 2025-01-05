﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using DarrenLee.Media;
using System.Text.RegularExpressions;

namespace PUSL2019_Information_Management_and_Retrieval_
{
    public partial class Cashier : Form   
    {
        Camera captureDevice = new Camera();
        public Cashier()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void slide(Button button)
        {
            panelSlide.BackColor = Color.White;
            panelSlide.Height = button.Height;
            panelSlide.Top = button.Top;    
        }

        private void btnNTran_Click(object sender, EventArgs e)
        {
            slide(btnNTran);
            GetTrainNo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            slide(btnSearch);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            slide(btnDiscount);
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            slide(btnSettle);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            slide(btnClear);
        }

        private void btnDSales_Click(object sender, EventArgs e)
        {
            slide(btnDSales);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            slide(btnPass);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void GetTrainNo()
        {
            string sdate = DateTime.Now.ToString("yyyyMMdd");
            string transno = sdate + "1001";
            lblTranNo.Text = transno;
        }

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                captureDevice.OnFrameArrived += captureDevice_OnFrameArrived;
                captureDevice.Start();
            }
        }
        
        private void captureDevice_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Bitmap bitmap = (Bitmap)e.GetFrame();
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(bitmap);
            if(result != null)
            {
                txtBarcod.Invoke(new MethodInvoker(delegate ()
                { txtBarcod.Text = result.ToString(); }));
            }
             
            
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            captureDevice.Stop();
        }
    }
}
