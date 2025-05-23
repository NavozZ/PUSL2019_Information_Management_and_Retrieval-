﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUSL2019_Information_Management_and_Retrieval_
{   

        
    public partial class Login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public string _pass = "";
        public bool _isactive;

        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            txtName.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Exit Application?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "", _role = "";
            try
            {
                bool found;
                cn.Open();
                cm= new SqlCommand("Select * From tbUser Where username = @username and password=@password",cn);
                cm.Parameters.AddWithValue("@username",txtName.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();    
                dr.Read();
                if(dr.HasRows)
                
                {
                  found = true;
                    _username = dr["username"].ToString();
                    _name = dr["name"].ToString();
                    _role = dr["role"].ToString();
                    _pass = dr["password"].ToString();  
                    _isactive = bool.Parse(dr["isactive"].ToString());
                }
                else
                {
                    found = false; 
                }
                dr.Close();
                cn.Close();

                if(found) 
                
                {
                    if(!_isactive)
                    
                    {
                        MessageBox.Show("Account Is Inactive.Unable to login","Inactive Account",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    if(_role=="Cashier")
                    {
                        MessageBox.Show("Welcome " + _name + "|", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.lblUsername.Text= _username;  
                        cashier.lblname.Text= _name + "|" + _role;
                        cashier.ShowDialog();   
                    }
                    else 
                    
                    {
                        MessageBox.Show("Welcome " + _name + "|", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Clear();
                        txtPass.Clear();
                        this.Hide();
                        Main main = new Main();
                        main.lblUsername.Text= _username;
                      //  main.lblName.Text = _name;
                        main.ShowDialog();
                    }

                }

                else
                {
                    MessageBox.Show("Invalid username and password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            
            catch(Exception ex)

            {
                   cn.Close();
                MessageBox.Show(ex.Message,"Ërror",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) 
            
            {
                btnLogin.PerformClick();  
            }
        }
    }
}
