using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FitnessTracker.Services;

namespace FitnessTracker.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            lblWelcome.Text = "Welcome back!";
            lblDailyGoal.Text = $"Daily Goal: {AnalyticsService.DailyCalorieGoal} kcal";
            lblCaloriesBurned.Text = $"Calories Burned: {AnalyticsService.TotalCaloriesBurned:F1} kcal";

            lstRecent.Items.Clear();
            foreach (var log in AnalyticsService.GetLogs().OrderByDescending(l => l.Timestamp).Take(5))
            {
                lstRecent.Items.Add($"{log.Timestamp:t} - {log.ActivityType} - {log.CaloriesBurned:F1} kcal");
            }

            lstBreakdown.Items.Clear();
            foreach (var entry in AnalyticsService.CaloriesByActivity)
            {
                lstBreakdown.Items.Add($"{entry.Key}: {entry.Value:F1} kcal");
            }
        }

        private void BtnSetGoal_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new calorie goal:", "Set Daily Goal", AnalyticsService.DailyCalorieGoal.ToString());

            if (int.TryParse(input, out int newGoal) && newGoal > 0)
            {
                AnalyticsService.SetGoal(newGoal);
                MessageBox.Show("Goal updated!");
                LoadDashboardData();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void BtnLogActivity_Click(object sender, EventArgs e)
        {

            var activity = new ActivityForm();
            activity.Show();
            this.Hide();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void lblCaloriesBurned_Click(object sender, EventArgs e)
        {

        }
    }
}
