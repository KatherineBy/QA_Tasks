namespace Task_03
{
    internal class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value > 0)
                {
                    _number = value;
                }
            }
        }

        public Address(string city, string street, int number)
        {
            City = city;
            Street = street;
            Number = number;
        }

        public override string ToString() 
        { 
            return $"{this.City}, {this.Street}, {this.Number}";
        }

        public override bool Equals(object item) 
        { 
            if (item is Address)
            { 
                Address check = (Address)item;
                return check.ToString() == this.ToString(); 
            }
            else 
            {
                return false;
            }
        }
    }
}
