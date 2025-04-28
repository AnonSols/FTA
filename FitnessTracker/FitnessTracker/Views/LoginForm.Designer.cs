namespace FitnessTracker.Views
{
    partial class LoginForm
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
            LblWelcome = new Label();
            LblUsername = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            BtnLogin = new Button();
            label4 = new Label();
            LblRegisterLink = new LinkLabel();
            SuspendLayout();
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblWelcome.ForeColor = Color.DarkBlue;
            LblWelcome.Location = new Point(288, 47);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(238, 45);
            LblWelcome.TabIndex = 0;
            LblWelcome.Text = "Welcome Back";
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsername.ForeColor = Color.DarkBlue;
            LblUsername.Location = new Point(243, 104);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(80, 20);
            LblUsername.TabIndex = 1;
            LblUsername.Text = "Username";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(243, 127);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(313, 37);
            TxtUsername.TabIndex = 2;
            TxtUsername.Enter += TxtUsername_Enter;
            TxtUsername.Leave += TxtUsername_Leave;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(243, 208);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(313, 37);
            TxtPassword.TabIndex = 4;
            TxtPassword.UseSystemPasswordChar = true;
            TxtPassword.Enter += TxtPassword_Enter;
            TxtPassword.Leave += TxtPassword_Leave;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.DarkBlue;
            LblPassword.Location = new Point(243, 185);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(76, 20);
            LblPassword.TabIndex = 3;
            LblPassword.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.DarkBlue;
            BtnLogin.Location = new Point(243, 261);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(313, 39);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Sign in";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(275, 335);
            label4.Name = "label4";
            label4.Size = new Size(156, 17);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account ?";
            // 
            // LblRegisterLink
            // 
            LblRegisterLink.AutoSize = true;
            LblRegisterLink.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblRegisterLink.Location = new Point(433, 335);
            LblRegisterLink.Name = "LblRegisterLink";
            LblRegisterLink.Size = new Size(58, 17);
            LblRegisterLink.TabIndex = 7;
            LblRegisterLink.TabStop = true;
            LblRegisterLink.Text = "Sign up!";
            LblRegisterLink.LinkClicked += LblRegisterLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(LblRegisterLink);
            Controls.Add(label4);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LblUsername);
            Controls.Add(LblWelcome);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblWelcome;
        private Label LblUsername;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label LblPassword;
        private Button BtnLogin;
        private Label label4;
        private LinkLabel LblRegisterLink;
    }
}