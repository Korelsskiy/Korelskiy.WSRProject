using System;
using System.Collections.Generic;
using System.Drawing;

namespace Korelskiy.WSRProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int NumberOfCrashes { get; set; }
        public string UserRole { get; set; }
        public string EmailAddress { get; set; }
        public string Office { get; set; }
        public DateTime Birthday { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Color UserColorInDataGrid { get; set; }
        public TimeSpan TimeSpentOnSystem { get; set; }

        public static Dictionary<int, string> Offices = new Dictionary<int, string>
        {
                {1, "Abu dhabi" },
                { 3, "Cairo"},
                {4, "Bahrain" },
                {5, "Doha" },
                {6, "Riyadh" },
                {7, "Show All Offices" }
        };

        public User() { }
        public User(int active, int roleId)
        {
            if (active == 0)
            {
                UserColorInDataGrid = Color.LightPink;
            }
            else
            {
                UserColorInDataGrid = roleId == 2 ? Color.White : Color.LightGreen;
            }
            
        }

    }
}
