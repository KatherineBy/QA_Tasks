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
            if (item == null || item.GetType() != this.GetType()) return false;
            
            Address check = (Address)item;
            
            return 
                check.City == this.City && 
                check.Street == this.Street && 
                check.Number == this.Number;    
        }
    }
}
