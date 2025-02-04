using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManuFactureDate { get; set; }
         public int PlaneId { get; set; }
        public PlaneType planeType { get; set; }

        public Plane() { }
        public Plane(PlaneType planeType , int Capacity , DateTime ManuFactureDate )
        {
            this.planeType = planeType;
            this.Capacity = Capacity;
            this.ManuFactureDate = ManuFactureDate;

            
        }

        public List<Flight> flights { get; set; }



    }

}
