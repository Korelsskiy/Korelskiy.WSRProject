using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.WSRProject.Models
{
    public class Flight
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string IATACodeFrom { get; set; }
        public string IATACodeTo { get; set; }
        public int FlighNumber { get; set; }
        public string Aicraft { get; set; }
        public int EPrice { get; set; }
        public int BPrice { get; set; }
        public int FPrice { get; set; }
    }
}
