using System.Collections.Generic;

namespace FitnessTracker.Helpers
{
    public static class UserSession
    {
        public static string CurrentUsername { get; set; } = "User";

        public static int DailyGoal { get; set; } = 2500;

        public static double CaloriesBurnedToday { get; set; } = 0;

        public static List<string> RecentActivities { get; set; } = new List<string>();

        public static Dictionary<string, double> CaloriesByActivity { get; set; } = new Dictionary<string, double>();

        public static void LogActivity(string activityType, double calories)
        {
            CaloriesBurnedToday += calories;
            RecentActivities.Insert(0, $"{System.DateTime.Now:t} - {activityType} - {calories} kcal");

            if (CaloriesByActivity.ContainsKey(activityType))
                CaloriesByActivity[activityType] += calories;
            else
                CaloriesByActivity[activityType] = calories;
        }

        public static void Reset()
        {
            CurrentUsername = "User";
            DailyGoal = 2500;
            CaloriesBurnedToday = 0;
            RecentActivities.Clear();
            CaloriesByActivity.Clear();
        }
    }
}
