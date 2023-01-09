using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Address
    {
        private int _apartment;
        public int Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if (value > 0)
                {
                    _apartment = value;
                }
            }
        }
        private int _building;
        public int Building 
        {
            get 
            {
                return _building;
            }
            set 
            { 
                if(value > 0) 
                { 
                    _building = value;
                }
            }
        }
        public string Street { get; set; }
        public string City { get; set; }

        public Address(int apartment, int building, string street, string city)
        {
            Apartment = apartment;
            Building = building;
            Street = street;
            City = city;
        }

    }
}
