

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessTracker.Services;

namespace FitnessTracker.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            TxtUsername.Text = "Enter your username";
            TxtUsername.ForeColor = Color.Gray;
            TxtPassword.Text = "Enter your password";
            TxtPassword.ForeColor = Color.Gray;
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string password = TxtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (UserService.Authenticate(username, password))
            {
                MessageBox.Show("Login successful!");
                
                var dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }



        private void LblRegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsername.Text))
            {
                TxtUsername.Text = "Enter your username";
                TxtUsername.ForeColor = Color.Gray;
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Enter your username")
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = Color.Black;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtUsername.Text = "Enter your password";
                TxtUsername.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Enter your password")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
            }
        }
    }
}
