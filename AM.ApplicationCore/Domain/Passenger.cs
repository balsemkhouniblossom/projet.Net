using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime Birthdate { get; set; }
        public String EmailAddress { get; set; }    
        public String FirstName {  get; set; }
        public String LastName { get; set; }
        public String PassportNumber { get; set; }
        public String TelNumber { get; set; }

        public List<Flight> Flights { get; set; }

    }
}
