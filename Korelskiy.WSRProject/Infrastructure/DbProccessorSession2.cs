using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Korelskiy.WSRProject.Models;

namespace Korelskiy.WSRProject.Infrastructure
{
    public class DbProccessorSession2 : IDbProccessorSession2
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Session2_Korelskiy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        private SqlDataReader dr;

        public DbProccessorSession2()
        {
            connection = new SqlConnection(connectionString);
        }

        public List<Airport> GetAirports()
        {
            List<Airport> airports = new List<Airport>();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Airports", connection);
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Airport airport = new Airport();
                    string name = dr["Name"].ToString();
                    airport.Name = name;
                    airports.Add(airport);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
            finally
            {
                connection.Close();
            }

            return airports;
        }

        public void SetAirportsCodes(List<int> routeIds, List<Flight> flights)
        {
            try
            {
                connection.Open();

                int i = 0;
                foreach (var item in routeIds)
                {
                  
                    SqlCommand command = new SqlCommand("SELECT DepartureAirportID, ArrivalAirportID FROM Routes WHERE ID=@ID", connection);
                    command.Parameters.AddWithValue("ID", item);
                    dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        int depId = Convert.ToInt32(dr["DepartureAirportID"]);
                        int arrId = Convert.ToInt32(dr["ArrivalAirportID"]);

                        string dep = Airport.AirportsCode.FirstOrDefault(x => x.Key == depId).Value;
                        string arr = Airport.AirportsCode.FirstOrDefault(x => x.Key == arrId).Value;

                        flights[i].IATACodeFrom = dep;
                        flights[i].IATACodeTo = arr;

                        
                    }
                    dr.Close();
                    i++;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        public List<Flight> GetFlights()
        {
            List<Flight> flights = new List<Flight>();
            List<int> routeIds = new List<int>();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Schedules", connection);
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Flight flight = new Flight();

                    DateTime date = Convert.ToDateTime(dr["Date"]).Date;
                    TimeSpan time = TimeSpan.Parse(dr["Time"].ToString());
                    int economyPrice = Convert.ToInt32(dr["EconomyPrice"]);
                    int flightNumber = Convert.ToInt32(dr["FlightNumber"]);
                    routeIds.Add(Convert.ToInt32(dr["RouteID"]));

                    flight.Date = date;
                    flight.Time = time;
                    flight.EPrice = economyPrice;
                    flight.FlighNumber = flightNumber;

                    flights.Add(flight);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            SetAirportsCodes(routeIds, flights);

            return flights;
        }
    }
}
