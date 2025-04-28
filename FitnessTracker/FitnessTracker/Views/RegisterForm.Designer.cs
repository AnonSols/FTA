namespace FitnessTracker.Views
{
    partial class RegisterForm
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
            TxtUsername = new TextBox();
            LblUsername = new Label();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            TxtConfirmPassword = new TextBox();
            LblChangePassword = new Label();
            BtnRegister = new Button();
            LblLoginLink = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // LblWelcome
            // 
            LblWelcome.AutoSize = true;
            LblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblWelcome.ForeColor = Color.DarkBlue;
            LblWelcome.Location = new Point(247, 29);
            LblWelcome.Name = "LblWelcome";
            LblWelcome.Size = new Size(293, 45);
            LblWelcome.TabIndex = 1;
            LblWelcome.Text = "Create an Account";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(238, 112);
            TxtUsername.Multiline = true;
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(313, 37);
            TxtUsername.TabIndex = 4;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblUsername.ForeColor = Color.DarkBlue;
            LblUsername.Location = new Point(238, 89);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(80, 20);
            LblUsername.TabIndex = 3;
            LblUsername.Text = "Username";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(238, 189);
            TxtPassword.Multiline = true;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(313, 37);
            TxtPassword.TabIndex = 6;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblPassword.ForeColor = Color.DarkBlue;
            LblPassword.Location = new Point(238, 166);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(76, 20);
            LblPassword.TabIndex = 5;
            LblPassword.Text = "Password";
            // 
            // TxtConfirmPassword
            // 
            TxtConfirmPassword.Location = new Point(238, 263);
            TxtConfirmPassword.Multiline = true;
            TxtConfirmPassword.Name = "TxtConfirmPassword";
            TxtConfirmPassword.Size = new Size(313, 37);
            TxtConfirmPassword.TabIndex = 8;
            TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // LblChangePassword
            // 
            LblChangePassword.AutoSize = true;
            LblChangePassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblChangePassword.ForeColor = Color.DarkBlue;
            LblChangePassword.Location = new Point(238, 240);
            LblChangePassword.Name = "LblChangePassword";
            LblChangePassword.Size = new Size(132, 20);
            LblChangePassword.TabIndex = 7;
            LblChangePassword.Text = "Change Password";
            // 
            // BtnRegister
            // 
            BtnRegister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegister.ForeColor = Color.DarkBlue;
            BtnRegister.Location = new Point(238, 318);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(313, 42);
            BtnRegister.TabIndex = 9;
            BtnRegister.Text = "Sign up";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // LblLoginLink
            // 
            LblLoginLink.AutoSize = true;
            LblLoginLink.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblLoginLink.Location = new Point(472, 388);
            LblLoginLink.Name = "LblLoginLink";
            LblLoginLink.Size = new Size(54, 17);
            LblLoginLink.TabIndex = 11;
            LblLoginLink.TabStop = true;
            LblLoginLink.Text = "Sign up";
            LblLoginLink.LinkClicked += LblLoginLink_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(297, 388);
            label4.Name = "label4";
            label4.Size = new Size(169, 17);
            label4.TabIndex = 10;
            label4.Text = "Already have an account ?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblLoginLink);
            Controls.Add(label4);
            Controls.Add(BtnRegister);
            Controls.Add(TxtConfirmPassword);
            Controls.Add(LblChangePassword);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LblUsername);
            Controls.Add(LblWelcome);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblWelcome;
        private TextBox TxtUsername;
        private Label LblUsername;
        private TextBox TxtPassword;
        private Label LblPassword;
        private TextBox TxtConfirmPassword;
        private Label LblChangePassword;
        private Button BtnRegister;
        private LinkLabel LblLoginLink;
        private Label label4;
    }
}