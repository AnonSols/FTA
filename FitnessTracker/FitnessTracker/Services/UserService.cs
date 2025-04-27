using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.Services
{
    public static class UserService
    {
        private static List<User> users = new List<User>
        {
            new User { Username = "solomon", Password = "Solomon123!" },
            new User { Username = "omolara", Password = "Password123!" }
        };

        public static bool Register(string username, string password)
        {
            if (users.Any(u => u.Username == username)) return false;

            users.Add(new User { Username = username, Password = password });
            return true;
        }

        public static bool Authenticate(string username, string password)
        {
            return users.Any(u => u.Username == username && u.Password == password);
        }
        public static bool UserExists(string username)
        {
            return users.Any(u => u.Username == username);
        }
    }
}
