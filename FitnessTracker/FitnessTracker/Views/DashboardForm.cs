using System;
using System.Linq;
using System.Windows.Forms;
using FitnessTracker.Services;
using FitnessTracker.Models;

namespace FitnessTracker.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboard();
            ApplyDarkTheme();
        }

        private void LoadDashboard()
        {
            lblNickname.Text = $"Welcome, {AnalyticsService.Nickname ?? "User"}";
            lblGoal.Text = $"Goal: {AnalyticsService.DailyCalorieGoal} kcal";
            lblCalories.Text = $"Burned: {AnalyticsService.TotalCaloriesBurned:F1} kcal";
            UpdateRecentActivities();
            DisplayRandomTip();
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

        private void UpdateRecentActivities()
        {
            lstRecentActivities.Items.Clear();
            var logs = AnalyticsService.GetLogs()
                .OrderByDescending(a => a.Timestamp)
                .Take(5)
                .ToList();

            foreach (var log in logs)
            {
                lstRecentActivities.Items.Add($"{log.Timestamp:t} - {log.ActivityType} - {log.CaloriesBurned:F1} kcal");
            }
        }

        private void BtnLogActivity_Click(object sender, EventArgs e)
        {

            var activityForm = new ActivityForm();
            activityForm.Show();
            this.Hide();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }


        private void BtnUpdateGoal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNewGoal.Text, out int newGoal))
            {
                AnalyticsService.UpdateDailyGoal(newGoal);
                lblGoal.Text = $"Goal: {newGoal} kcal";
                MessageBox.Show("Goal updated successfully!");
                txtNewGoal.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for goal.");
            }
        }

        private void DisplayRandomTip()
        {
            var tips = new string[]
            {
                "Stay hydrated during your workout!",
                "Stretch after exercising to reduce soreness.",
                "Set realistic fitness goals!",
                "Consistency beats intensity.",
                "Listen to your body and rest when needed."
            };

            Random rand = new Random();
            int index = rand.Next(tips.Length);
            lblTips.Text = tips[index];
        }
    }
}
