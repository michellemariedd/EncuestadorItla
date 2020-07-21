﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace EncuestadorITLA
{
    public partial class CreateUser : Form
    {
        private UserService Service;
        
        public CreateUser()
        {
            Service = new UserService();
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }
        #region Botons
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            createAccounts();
        }
        #endregion

        #region Methods
        private void createAccounts()
        {

            NewAccount create = new NewAccount();

            create.Name = txtName.Text;
            create.Lastname = txtLastname.Text;
            create.Username = txtUsername.Text;
            create.Password = txtPassword.Text;
            create.Password = txtPassworf.Text;

            Service.CreateAccount(create);

            if (txtPassword.Text == txtPassworf.Text)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords do not mach", "Warning");
            }


        }
        #endregion
        #region Events
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DimGray;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }
        private void txtLastname_Enter(object sender, EventArgs e)
        {
            if (txtLastname.Text == "LastName")
            {
                txtLastname.Text = "";
                txtLastname.ForeColor = Color.Black;
            }
        }

        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text == "")
            {
                txtLastname.Text = "Lastname";
                txtLastname.ForeColor = Color.DimGray;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name";
                txtName.ForeColor = Color.DimGray;
            }
        }

        private void txtUsername_(object sender, KeyPressEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtPassworf_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Confirm Password")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }
        private void txtPassworf_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Confirm Password";
                txtName.ForeColor = Color.DimGray;
            }
        }
        #endregion
    }
}
