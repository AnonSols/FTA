using System.Collections.Generic;
using System.Linq;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public static class AnalyticsService
    {
        public static int DailyCalorieGoal { get; private set; } = 2500; // default goal

        private static List<ActivityLog> activityLogs = new List<ActivityLog>();

        public static double TotalCaloriesBurned =>
            activityLogs.Sum(a => a.CaloriesBurned);

        public static Dictionary<string, double> CaloriesByActivity =>
            activityLogs
                .GroupBy(a => a.ActivityType)
                .ToDictionary(g => g.Key!, g => g.Sum(a => a.CaloriesBurned));

        public static void AddLog(ActivityLog log)
        {
            activityLogs.Add(log);
        }

        public static List<ActivityLog> GetLogs() => activityLogs;

        public static void SetGoal(int newGoal)
        {
            DailyCalorieGoal = newGoal;
        }
    }

}
