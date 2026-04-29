using System;

namespace zeropos
{
    internal static class UserSession
    {
        public static int UserId { get; private set; }
        public static string Username { get; private set; }
        public static string Name { get; private set; }
        public static string Role { get; private set; }

        public static bool IsLoggedIn => UserId > 0;

        // 🔐 Login
        public static void Login(int userId, string username, string name, string role)
        {
            UserId = userId;
            Username = username;
            Name = name;
            Role = role;
        }

        // 🔓 Logout
        public static void Logout()
        {
            Clear();
        }

        // 🧹 Clear session
        public static void Clear()
        {
            UserId = 0;
            Username = string.Empty;
            Name = string.Empty;
            Role = string.Empty;
        }

        // 🔑 Check role
        public static bool IsAdmin()
        {
            return Role == "admin";
        }

        public static bool IsStaff()
        {
            return Role == "staff";
        }
    }
}