using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Address
    {
        public int Apartment;
        public int Building;
        public string Street;
        public string City;

        public Address(int apartment, int building, string street, string city)
        {
            Apartment = apartment;
            Building = building;
            Street = street;
            City = city;
        }

    }
}
