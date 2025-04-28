

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

            ApplyDarkTheme();
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = ColorTranslator.FromHtml("#1E1E1E"); // Form Background

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = ColorTranslator.FromHtml("#CCCCCC"); // Light Gray for labels
                }
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = ColorTranslator.FromHtml("#2D2D30"); // Dark background
                    txt.ForeColor = Color.White;                        // White text
                    txt.TextAlign = HorizontalAlignment.Center;         // Center text (especially placeholders)
                    txt.BorderStyle = BorderStyle.FixedSingle;           // Neat borders
                }
                else if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#007ACC"); // Blue button background
                    btn.ForeColor = Color.White;                         // White button text
                    btn.FlatStyle = FlatStyle.Flat;                      // Flat design
                    btn.FlatAppearance.BorderSize = 0;                   // No border
                }
                else if (ctrl is ListBox lst)
                {
                    lst.BackColor = ColorTranslator.FromHtml("#2D2D30"); // Same as textbox
                    lst.ForeColor = ColorTranslator.FromHtml("#CCCCCC");
                }
            }
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
