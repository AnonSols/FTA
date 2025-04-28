


using System;
using System.Drawing;
using System.Linq;
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
            InitializeActivityForm();
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

        private void InitializeActivityForm()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            cmbActivityType.Items.AddRange(new string[]
            {
                "Running", "Yoga", "Swimming", "Weightlifting", "Cycling", "Walking"
            });
            cmbActivityType.SelectedIndexChanged += cmbActivityType_SelectedIndexChanged;

            //btnLogActivity.Click += btnLogActivity_Click;
            btnBackToDashboard.Click += btnBackToDashboard_Click;

            ToggleInputs("Walking");
            SetupPlaceholders();
        }

        private void SetupPlaceholders()
        {
            SetPlaceholder(txtSteps, "Steps...");
            SetPlaceholder(txtDistance, "Distance (km)...");
            SetPlaceholder(txtDuration, "Duration (min)...");
            SetPlaceholder(txtElevation, "Elevation Gain...");
        }

        private void SetPlaceholder(TextBox box, string placeholder)
        {
            box.Text = placeholder;
            box.ForeColor = Color.Gray;

            box.Enter += (s, e) =>
            {
                if (box.Text == placeholder)
                {
                    box.Text = "";
                    box.ForeColor = Color.White;
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

        private void ToggleInputs(string? selected)
        {
            txtSteps.Visible = selected == "Walking";
            txtDistance.Visible = selected == "Running" || selected == "Cycling";
            txtElevation.Visible = selected == "Running";
            txtDuration.Visible = selected == "Yoga" || selected == "Swimming" || selected == "Weightlifting";
        }

        private void cmbActivityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selected = cmbActivityType.SelectedItem?.ToString();
            ToggleInputs(selected);
        }

        private void btnLogActivity_Click(object sender, EventArgs e)
        {
            if (cmbActivityType.SelectedItem == null)
            {
                MessageBox.Show("Please select an activity type first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? activity = cmbActivityType.SelectedItem.ToString();
            double.TryParse(txtSteps.Text, out double steps);
            double.TryParse(txtDistance.Text, out double distance);
            double.TryParse(txtDuration.Text, out double duration);
            double.TryParse(txtElevation.Text, out double elevation);

            double calories = CalculateCalories(activity, steps, distance, duration, elevation);
            lblCalories.Text = $"Calories Burned: {calories:F1} kcal";

            var log = new ActivityLog
            {
                ActivityType = activity,
                Steps = steps,
                DistanceKm = distance,
                DurationMinutes = duration,
                ElevationGain = elevation,
                CaloriesBurned = calories,
                Timestamp = DateTime.Now
            };

            AnalyticsService.AddLog(log);
            lstActivityLog.Items.Insert(0, $"{log.Timestamp:t} - {log.ActivityType} - {log.CaloriesBurned:F1} kcal");
        }

        private double CalculateCalories(string? activity, double steps, double distance, double duration, double elevation)
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

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {

            DashboardForm dashB = new();
            dashB.Show();
            this.Hide();
        }
    }
}
