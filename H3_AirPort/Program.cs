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
                DbSet<Airline> airlinesQuery = ctx.Airline;

                Console.WriteLine("Airports:");
                Console.WriteLine("_________________");
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
