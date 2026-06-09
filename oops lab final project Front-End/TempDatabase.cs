using System;
using System.Collections.Generic;

namespace oops_lab_final_project_Front_End
{
    // 1. User Data Model Class
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    // 2. Static Temporary Database Class
    public static class TempDatabase
    {
        // Global static list jo poore project mein access hogi
        public static List<User> Users = new List<User>()
        {
            new User { Username = "muhammad salman", Password = "1234", Role = "Buyer" },
            new User { Username = "abdullah", Password = "4321", Role = "Seller" }
        };
    }
}