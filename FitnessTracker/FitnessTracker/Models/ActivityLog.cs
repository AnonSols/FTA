using System;

namespace FitnessTracker.Models
{
    public class ActivityLog
    {
        public string? ActivityType { get; set; } = String.Empty;
        public double Steps { get; set; }
        public double DistanceKm { get; set; }
        public double ElevationGain { get; set; }
        public double DurationMinutes { get; set; }
        public double CaloriesBurned { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
