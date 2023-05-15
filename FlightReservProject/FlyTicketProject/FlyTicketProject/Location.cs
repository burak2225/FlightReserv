using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTicketProject
{
    internal class Location
    {
        public string Country;
        public string City;
        public string Airport;
        public Location(string country, string city, string airport)
        {
            Country = country; 
            City = city;    
            Airport = airport;

        }
    }
}
