using System;
using System.Collections.Generic;

namespace oops_lab_final_project_Front_End
{
    
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

   
    public static class TempDatabase
    {
        public static List<User> Users = new List<User>()
        {
            
            new User { Username = "muhammad salman", Password = "1234", Role = "Buyer" },
            
            
            new User { Username = "abdullah", Password = "4321", Role = "Seller" }
        };
    }
}