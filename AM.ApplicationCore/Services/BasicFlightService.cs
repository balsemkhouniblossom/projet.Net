using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using AM.ApplicationCore.Domain;
using System.Collections;


namespace AM.ApplicationCore.Services
{
    public class BasicFlightService : Interfaces.IBasicFlightService
    {
        public ICollection source;

        public BasicFlightService(ICollection source )
        {
            this.source = source;
        }

        public void ShowFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach(Flight f in source)
                    {
                        if (filterValue == f.Destination)
                        {
                            Console.WriteLine(f);
                        }
                    }

                    break;
                case "FlightDate":

                    foreach (Flight f in source)
                    {
                        if (DateTime.Parse(filterValue) == f.FlightDate)
                        {
                            Console.WriteLine(f);
                        }
                        
                    }


                    break;

                case "FlightId":

                    foreach (Flight f in source)
                    {
                        if (int.Parse (filterValue) == f.FlightId)
                        {
                            Console.WriteLine(f);
                        }
                       
                    }
                    break;

                default:
                    
                    throw new ArgumentException("Unknown filter", nameof(filterType));
            
        }
        }
    }
}
