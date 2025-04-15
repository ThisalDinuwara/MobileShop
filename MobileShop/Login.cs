using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShop
{
    public partial class Login : Form
    {
        private const string ValidUsername = "admin";
        private const string ValidPassword = "password123";

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;

            Application.Exit();
        }

        private void rtxtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            return username == ValidUsername && password == ValidPassword;
        }

        private void btnGoogleLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Google login not implemented in this example");
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facebook login not implemented in this example");
        }

        private void btnLinkedInLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LinkedIn login not implemented in this example");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
    }
}

