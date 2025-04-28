namespace FitnessTracker.Views
{
    partial class ActivityForm
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
            txtSteps = new TextBox();
            logAnActivity = new Label();
            cmbActivityType = new ComboBox();
            txtDistance = new TextBox();
            txtElevation = new TextBox();
            txtDuration = new TextBox();
            lblCalories = new Label();
            btnBackToDashboard = new Label();
            btnLogActivity = new Button();
            activityHistory = new Label();
            lstActivityLog = new ListBox();
            SuspendLayout();
            // 
            // txtSteps
            // 
            txtSteps.Location = new Point(240, 152);
            txtSteps.Multiline = true;
            txtSteps.Name = "txtSteps";
            txtSteps.Size = new Size(313, 37);
            txtSteps.TabIndex = 6;
            // 
            // logAnActivity
            // 
            logAnActivity.AutoSize = true;
            logAnActivity.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logAnActivity.ForeColor = Color.DarkSlateBlue;
            logAnActivity.Location = new Point(288, 21);
            logAnActivity.Name = "logAnActivity";
            logAnActivity.Size = new Size(199, 45);
            logAnActivity.TabIndex = 5;
            logAnActivity.Text = "Activity Log";
            // 
            // cmbActivityType
            // 
            cmbActivityType.FormattingEnabled = true;
            cmbActivityType.Location = new Point(240, 80);
            cmbActivityType.Name = "cmbActivityType";
            cmbActivityType.Size = new Size(200, 23);
            cmbActivityType.TabIndex = 7;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(240, 109);
            txtDistance.Multiline = true;
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(313, 37);
            txtDistance.TabIndex = 8;
            // 
            // txtElevation
            // 
            txtElevation.Location = new Point(240, 195);
            txtElevation.Multiline = true;
            txtElevation.Name = "txtElevation";
            txtElevation.Size = new Size(313, 37);
            txtElevation.TabIndex = 9;
            // 
            // txtDuration
            // 
            txtDuration.AcceptsReturn = true;
            txtDuration.Location = new Point(240, 238);
            txtDuration.Multiline = true;
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(313, 37);
            txtDuration.TabIndex = 10;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalories.ForeColor = Color.DarkSlateBlue;
            lblCalories.Location = new Point(345, 278);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(78, 20);
            lblCalories.TabIndex = 11;
            lblCalories.Text = "Calories: -";
            // 
            // btnBackToDashboard
            // 
            btnBackToDashboard.AutoSize = true;
            btnBackToDashboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToDashboard.ForeColor = Color.DarkSlateBlue;
            btnBackToDashboard.Location = new Point(392, 305);
            btnBackToDashboard.Name = "btnBackToDashboard";
            btnBackToDashboard.Size = new Size(141, 20);
            btnBackToDashboard.TabIndex = 12;
            btnBackToDashboard.Text = "Back to Dashboard";
            btnBackToDashboard.Click += btnBackToDashboard_Click;
            // 
            // btnLogActivity
            // 
            btnLogActivity.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogActivity.ForeColor = Color.DarkSlateBlue;
            btnLogActivity.Location = new Point(263, 301);
            btnLogActivity.Name = "btnLogActivity";
            btnLogActivity.Size = new Size(123, 28);
            btnLogActivity.TabIndex = 13;
            btnLogActivity.Text = "Log activity";
            btnLogActivity.UseVisualStyleBackColor = true;
            btnLogActivity.Click += btnLogActivity_Click;
            // 
            // activityHistory
            // 
            activityHistory.AutoSize = true;
            activityHistory.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activityHistory.ForeColor = Color.DarkSlateBlue;
            activityHistory.Location = new Point(240, 346);
            activityHistory.Name = "activityHistory";
            activityHistory.Size = new Size(119, 20);
            activityHistory.TabIndex = 14;
            activityHistory.Text = "Activity History";
            // 
            // lstActivityLog
            // 
            lstActivityLog.FormattingEnabled = true;
            lstActivityLog.ItemHeight = 15;
            lstActivityLog.Location = new Point(240, 369);
            lstActivityLog.Name = "lstActivityLog";
            lstActivityLog.Size = new Size(313, 79);
            lstActivityLog.TabIndex = 15;
            // 
            // ActivityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstActivityLog);
            Controls.Add(activityHistory);
            Controls.Add(btnLogActivity);
            Controls.Add(btnBackToDashboard);
            Controls.Add(lblCalories);
            Controls.Add(txtDuration);
            Controls.Add(txtElevation);
            Controls.Add(txtDistance);
            Controls.Add(cmbActivityType);
            Controls.Add(txtSteps);
            Controls.Add(logAnActivity);
            Name = "ActivityForm";
            Text = "ActivityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSteps;
        private Label logAnActivity;
        private ComboBox cmbActivityType;
        private TextBox txtDistance;
        private TextBox txtElevation;
        private TextBox txtDuration;
        private Label lblCalories;
        private Label btnBackToDashboard;
        private Button btnLogActivity;
        private Label activityHistory;
        private ListBox lstActivityLog;
    }
}