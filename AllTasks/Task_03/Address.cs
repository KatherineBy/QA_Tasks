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
            return $"{City}, {Street}, {Number}";
        }

        public override bool Equals(object item) 
        {
            if (item == null || item.GetType() != GetType()) return false;
            //GetType used, as the method is used further by derived class LegalAddress

            Address check = (Address)item;
            
            return 
                check.City == City && 
                check.Street == Street && 
                check.Number == Number;    
        }
    }
}
