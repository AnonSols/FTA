
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text.Trim();
            string password = TxtPassword.Text.Trim();
            string confirmPassword = TxtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (UserService.UserExists(username))
            {
                MessageBox.Show("User already exists.");
                return;
            }

            UserService.Register(username, password);
            MessageBox.Show("Registration successful! Please login.");

            // Optionally navigate back to LoginForm
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void LblLoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
