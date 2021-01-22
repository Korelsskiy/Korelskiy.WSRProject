using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.WSRProject.Models
{
    public class Airport
    {
        public string Name { get; set; }
        public static Dictionary<int, string> AirportsCode = new Dictionary<int, string>
        {
                {2, "AUH" },
                {3, "CAI"},
                {4, "BAH" },
                {5, "ADE" },
                {6, "DOH" },
                {7, "RUH" }
        };
    }
}
