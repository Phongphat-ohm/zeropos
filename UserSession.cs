using System;
using System.Collections.Generic;
using System.Text;

namespace zeropos
{
    internal class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }
        public static bool IsLoggedIn { get; set; } = true;

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            Name = null;
            Role = null;
            IsLoggedIn = false;
        }
    }
}
