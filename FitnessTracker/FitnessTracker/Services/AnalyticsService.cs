using System;
using System.Collections.Generic;
using System.Linq;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public static class AnalyticsService
    {
        private static List<ActivityLog> activityLogs = new List<ActivityLog>();

        public static int DailyCalorieGoal { get; private set; } = 2500;
        public static string Nickname { get; private set; } = "Champion";

        private static readonly string[] MotivationalTips = new[]
        {
            "Consistency beats intensity.",
            "Stay hydrated throughout your workout.",
            "Small progress is still progress!",
            "Believe in yourself and push forward.",
            "Fitness is a journey, not a destination.",
            "You are stronger than you think."
        };

        private static Random random = new Random();

        public static double TotalCaloriesBurned =>
            activityLogs.Sum(a => a.CaloriesBurned);

        public static Dictionary<string, double> CaloriesByActivity =>
            activityLogs
                .GroupBy(a => a.ActivityType ?? "Unknown")
                .ToDictionary(g => g.Key, g => g.Sum(a => a.CaloriesBurned));

        public static void AddLog(ActivityLog log)
        {
            activityLogs.Add(log);
        }

        public static List<ActivityLog> GetLogs() => activityLogs;

        public static void SetGoal(int newGoal)
        {
            DailyCalorieGoal = newGoal;
        }

        public static void UpdateDailyGoal(int newGoal)
        {
            DailyCalorieGoal = newGoal;
        }

        public static void UpdateNickname(string newNickname)
        {
            if (!string.IsNullOrWhiteSpace(newNickname))
            {
                Nickname = newNickname;
            }
        }

        public static string GetRandomTip()
        {
            return MotivationalTips[random.Next(MotivationalTips.Length)];
        }
    }
}
