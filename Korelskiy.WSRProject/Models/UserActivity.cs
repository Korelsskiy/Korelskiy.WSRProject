using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.WSRProject.Models
{
    public class UserActivity
    {
        public int UserId { get; set; }
        public TimeSpan LoginTime { get; set; }
        public TimeSpan LogoutTime { get; set; }
        public TimeSpan TimeSpentOnSystem { get; set; }
        public string LogoutReason { get; set; }

    }
}
