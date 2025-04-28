namespace FitnessTracker.Views
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNickname;
        private Label lblGoal;
        private Label lblCalories;
        private ListBox lstRecentActivities;
        private TextBox txtNewGoal;
        private Button btnUpdateGoal;
        private Button btnLogActivity;
        private Label lblTips;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNickname = new Label();
            lblGoal = new Label();
            lblCalories = new Label();
            lstRecentActivities = new ListBox();
            txtNewGoal = new TextBox();
            btnUpdateGoal = new Button();
            btnLogActivity = new Button();
            lblTips = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblNickname
            // 
            lblNickname.AutoSize = true;
            lblNickname.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNickname.Location = new Point(30, 20);
            lblNickname.Name = "lblNickname";
            lblNickname.Size = new Size(184, 32);
            lblNickname.TabIndex = 0;
            lblNickname.Text = "Welcome, User";
            // 
            // lblGoal
            // 
            lblGoal.AutoSize = true;
            lblGoal.Font = new Font("Segoe UI", 12F);
            lblGoal.Location = new Point(30, 70);
            lblGoal.Name = "lblGoal";
            lblGoal.Size = new Size(116, 21);
            lblGoal.TabIndex = 1;
            lblGoal.Text = "Goal: 2500 kcal";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 12F);
            lblCalories.Location = new Point(30, 100);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(107, 21);
            lblCalories.TabIndex = 2;
            lblCalories.Text = "Burned: 0 kcal";
            // 
            // lstRecentActivities
            // 
            lstRecentActivities.FormattingEnabled = true;
            lstRecentActivities.ItemHeight = 15;
            lstRecentActivities.Location = new Point(30, 140);
            lstRecentActivities.Name = "lstRecentActivities";
            lstRecentActivities.Size = new Size(400, 94);
            lstRecentActivities.TabIndex = 3;
            // 
            // txtNewGoal
            // 
            txtNewGoal.Location = new Point(30, 250);
            txtNewGoal.Multiline = true;
            txtNewGoal.Name = "txtNewGoal";
            txtNewGoal.PlaceholderText = "Enter new goal";
            txtNewGoal.Size = new Size(184, 31);
            txtNewGoal.TabIndex = 4;
            // 
            // btnUpdateGoal
            // 
            btnUpdateGoal.Location = new Point(271, 250);
            btnUpdateGoal.Name = "btnUpdateGoal";
            btnUpdateGoal.Size = new Size(100, 31);
            btnUpdateGoal.TabIndex = 5;
            btnUpdateGoal.Text = "Update Goal";
            btnUpdateGoal.UseVisualStyleBackColor = true;
            btnUpdateGoal.Click += BtnUpdateGoal_Click;
            // 
            // btnLogActivity
            // 
            btnLogActivity.Location = new Point(30, 318);
            btnLogActivity.Name = "btnLogActivity";
            btnLogActivity.Size = new Size(184, 30);
            btnLogActivity.TabIndex = 6;
            btnLogActivity.Text = "Log Activity";
            btnLogActivity.UseVisualStyleBackColor = true;
            btnLogActivity.Click += BtnLogActivity_Click;
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblTips.Location = new Point(30, 379);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(119, 19);
            lblTips.TabIndex = 7;
            lblTips.Text = "Random Tip here!";
            // 
            // button1
            // 
            button1.Location = new Point(246, 318);
            button1.Name = "button1";
            button1.Size = new Size(184, 30);
            button1.TabIndex = 8;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            ClientSize = new Size(500, 450);
            Controls.Add(button1);
            Controls.Add(lblNickname);
            Controls.Add(lblGoal);
            Controls.Add(lblCalories);
            Controls.Add(lstRecentActivities);
            Controls.Add(txtNewGoal);
            Controls.Add(btnUpdateGoal);
            Controls.Add(btnLogActivity);
            Controls.Add(lblTips);
            Name = "DashboardForm";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
    }
}
