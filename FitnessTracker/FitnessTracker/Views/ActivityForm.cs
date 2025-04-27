using System;
using System.Windows.Forms;
using FitnessTracker.Models;
using FitnessTracker.Services;

namespace FitnessTracker.Views
{
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
            SetupForm();
            SetupPlaceholders();
        }

        private void SetupForm()
        {
            cmbActivityType.Items.AddRange(new string[]
            {
                "Running", "Yoga", "Swimming", "Weightlifting", "Cycling", "Walking"
            });
            cmbActivityType.SelectedIndexChanged += cmbActivityType_SelectedIndexChanged;
            //btnLogActivity.Click += btnLogActivity_Click;
            btnBackToDashboard.Click += btnBackToDashboard_Click;

            // Initial visibility
            ToggleInputs("Walking");
        }

        private void cmbActivityType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selected = cmbActivityType.SelectedItem?.ToString();
            ToggleInputs(selected);
        }

        private void ToggleInputs(string? selected)
        {
            txtSteps.Visible = selected == "Walking";
            txtDistance.Visible = selected == "Running" || selected == "Cycling";
            txtElevation.Visible = selected == "Running";
            txtDuration.Visible = selected == "Yoga" || selected == "Swimming" || selected == "Weightlifting";
        }

        private void btnLogActivity_Click(object? sender, EventArgs e)
        {
            string? activity = cmbActivityType.SelectedItem?.ToString();
            double.TryParse(txtSteps.Text, out double steps);
            double.TryParse(txtDistance.Text, out double distance);
            double.TryParse(txtElevation.Text, out double elevation);
            double.TryParse(txtDuration.Text, out double duration);

            var calories = CalculateCalories(activity, steps, distance, elevation, duration);
            lblCalories.Text = $"Calories: {calories:F1}";

            var log = new ActivityLog
            {
                ActivityType = activity,
                Steps = steps,
                DistanceKm = distance,
                ElevationGain = elevation,
                DurationMinutes = duration,
                CaloriesBurned = calories,
                Timestamp = DateTime.Now
            };

            AnalyticsService.AddLog(log);
            lstActivityLog.Items.Insert(0, $"{log.Timestamp:t} - {log.ActivityType} - {log.CaloriesBurned:F1} kcal");
        }
        private static void SetPlaceholder(TextBox box, string placeholder)
        {
            box.Text = placeholder;
            box.ForeColor = Color.Gray;

            box.Enter += (s, e) =>
            {
                if (box.Text == placeholder)
                {
                    box.Text = "";
                    box.ForeColor = Color.Black;
                }
            };

            box.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.Text = placeholder;
                    box.ForeColor = Color.Gray;
                }
            };
        }
        private void SetupPlaceholders()
        {
            SetPlaceholder(txtSteps, "Enter steps...");
            SetPlaceholder(txtDistance, "Enter distance in km...");
            SetPlaceholder(txtElevation, "Enter elevation gain...");
            SetPlaceholder(txtDuration, "Enter duration in minutes...");
        }

        private double CalculateCalories(string? activity, double steps, double distance, double elevation, double duration)
        {
            return activity switch
            {
                "Walking" => steps * 0.04,
                "Running" => (distance * 60) + (elevation * 0.5),
                "Cycling" => distance * 50,
                "Swimming" => duration * 9.8,
                "Weightlifting" => duration * 5.5,
                "Yoga" => 3.0,
                _ => 0
            };
        }



        private void btnBackToDashboard_Click(object? sender, EventArgs e)
        {
           
            var dash = new DashboardForm(); 
            dash.Show();
            this.Hide();
        }
    }
}
