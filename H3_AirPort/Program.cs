using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_AirPort
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AirPortDbEntities ctx = new AirPortDbEntities())
            {
                // Using current time, with a format string!
                DateTime time = DateTime.Now;
                string format = "HH:mm";
                Console.WriteLine(time.ToString(format));

                int ranTake = 0;
                int newTime = 0;

                if (time.Hour >= 0 && time.Hour <= 5) { newTime = 1; }
                if (time.Hour >= 6 && time.Hour <= 11) { newTime = 2; }
                if (time.Hour >= 12 && time.Hour <= 17) { newTime = 3; }
                if (time.Hour >= 18) { newTime = 4; }

                switch (newTime)
                {
                    case 1:
                        ranTake = 2;
                        break;
                    case 2:
                        ranTake = 4;
                        break;
                    case 3:
                        ranTake = 6;
                        break;
                    case 4:
                        ranTake = 4;
                        break;
                    default:
                        break;
                }

                var flights = (from f in ctx.Flight
                                 join al in ctx.Airline
                                   on f.FlightNum equals al.FlightNum
                                 join o in ctx.Operater
                                   on al.AirlineId equals o.AirlineId
                                 join fr in ctx.FlightRoute
                                   on o.RouteId equals fr.RouteId
                                 select new
                                 {
                                     f.FlightNum,
                                     f.FlightName,
                                     al.AirlineName,
                                     fr.Departure,
                                     fr.Arrival,
                                     fr.RouteOwner,
                                 }).OrderBy(x => Guid.NewGuid()).Take(ranTake);

                foreach (var all in flights)
                {
                    Console.WriteLine("_________________");
                    Console.Write("\nWithin the last 6 hours, the following airline flights have taken off: \n" + all.FlightNum + " " + all.FlightName + " \n\nfrom this airline: \n" + all.AirlineName + "\n\nThis flight travel from: \n" + all.Departure + " to " + all.Arrival + "\n\nRoute owner: " + all.RouteOwner + " \n");
                }




                DbSet<Airline> airlinesQuery = ctx.Airline;

                Console.WriteLine("\n_________________");
                Console.WriteLine("Airports: \n");

                foreach (AirportTerminal airport in ctx.AirportTerminal)
                {
                        Console.WriteLine("IATA: " + airport.IATA);
                        Console.WriteLine("Airport: " + airport.AirportName);
                        Console.WriteLine("Terminal:  " + airport.TerminalName);
                        Console.WriteLine("Zipcode:  " + airport.ZipCode);

                    Console.WriteLine();
                }
                Console.ReadKey();
            }

        }
    }
}
