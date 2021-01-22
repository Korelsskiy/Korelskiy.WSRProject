using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Korelskiy.WSRProject.Models;

namespace Korelskiy.WSRProject.Infrastructure
{
    public interface IDbProccessorSession2
    {
        List<Airport> GetAirports();

        List<Flight> GetFlights();

    }
}
