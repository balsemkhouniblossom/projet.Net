using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;


namespace AM.ApplicationCore.Domain

{
    public static class InMemorySource


    {
        public static Plane Boeing1 { get; private set; }
        public static readonly Plane Boeing2 = new Plane(PlaneType.Boeing, 150, new DateTime(2015, 2, 3)) { PlaneId = 2 };
        public static readonly Plane Airbus = new Plane() { PlaneId = 3, Capacity = 200, planeType = PlaneType.Airbus, ManuFactureDate = new DateTime(2019, 11, 31) };
        public static Staff staff1 = new Staff() { FirstName = "captain", LastName = "Captain", EmailAddress = "captain@gmail.com", Birthdate = new DateTime(1965, 1, 1), EmployementDate = new DateTime(1999, 1, 1), Salary = 10000 };
        public static Staff staff2 = new Staff() { FirstName = "Hostess1", LastName = "Hostess1", EmailAddress = "Hostess1@gmail.com", Birthdate = new DateTime(1995, 1, 1), EmployementDate = new DateTime(2019, 1, 1), Salary = 5000 };
        public static Staff staff3 = new Staff() { FirstName = "Hostess2", LastName = "Hostess2", EmailAddress = "Hostess2@gmail.com", Birthdate = new DateTime(1996, 1, 1), EmployementDate = new DateTime(2018, 1, 1), Salary = 5000 };
        public static Traveller t1 = new Traveller() { FirstName = "traveller1", LastName = "traveller1", Birthdate = new DateTime(1980, 1, 1), HealthlnInfo = "No troubles", Nationality = "American" };
        public static Traveller t2 = new Traveller() { FirstName = "traveller2", LastName = "traveller1", Birthdate = new DateTime(1981, 1, 1), HealthlnInfo = "Some troubles", Nationality = "French" };
        public static Traveller t3 = new Traveller() { FirstName = "traveller3", LastName = "traveller3", Birthdate = new DateTime(1982, 1, 1), HealthlnInfo = "No troubles", Nationality = "Tunisian" };
        public static Traveller t4 = new Traveller() { FirstName = "traveller4", LastName = "traveller4", Birthdate = new DateTime(1983, 1, 1), HealthlnInfo = "Some troubles", Nationality = "American" };
        public static Traveller t5 = new Traveller() { FirstName = "traveller5", LastName = "traveller5", Birthdate = new DateTime(1984, 1, 1), HealthlnInfo = "Some troubles", Nationality = "Spanish" };
        public static List<Staff> Staffs = new List<Staff>() { staff1, staff2, staff3 };
        public static List<Traveller> Travellers = new List<Traveller>() { t1, t2, t3, t4, t5 };

        public static Flight f1 = new Flight() { FlightId = 1, FlightDate = new DateTime(2022, 1, 1, 15, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 2, 1, 23, 10, 0), EstimatedDuration = 2, Plane = Boeing1 };
        public static Flight f2 = new Flight() { FlightId = 2, FlightDate = new DateTime(2022, 1, 1, 15, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 1, 1, 23, 10, 0), EstimatedDuration = 2, Plane = Boeing1 };
        public static Flight f3 = new Flight() { FlightId = 3, FlightDate = new DateTime(2022, 2, 1, 21, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 2, 1, 23, 10, 0), EstimatedDuration = 2, Plane = Boeing2 };
        public static Flight f4 = new Flight() { FlightId = 4, FlightDate = new DateTime(2022, 4, 1, 6, 10, 0), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 4, 1, 8, 40, 0), EstimatedDuration = 2, Plane = Boeing2 };
        public static Flight f5 = new Flight() { FlightId = 5, FlightDate = new DateTime(2022, 5, 1, 17, 10, 0), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 5, 1, 19, 40, 0), EstimatedDuration = 2, Plane = Airbus };
        public static Flight f6 = new Flight() { FlightId = 6, FlightDate = new DateTime(2022, 6, 1, 20, 10, 0), Destination = "Lisbonne", EffectiveArrival = new DateTime(2022, 6, 1, 23, 10, 0), EstimatedDuration = 3, Plane = Airbus };



        public static List<Flight> Flights = new List<Flight>() { f1, f2, f3, f4, f5, f6 };


        static Plane GetFirstPlane()
        {
            var plane = new Plane();
            plane.PlaneId = 1;
            plane.planeType = PlaneType.Boeing;
            plane.Capacity = 200;
            plane.ManuFactureDate = new DateTime(2020, 11, 11);




            return plane;
        }

    }
}