namespace Task_03
{
    internal class LegalAddress: Address
    {
        public string Index { get; set; }

        public LegalAddress(string index, string city, string street, int number): 
            base(city, street, number) 
        { 
            Index = index;
        }

        public override string ToString()
        {
            return $"{this.Index}, {this.City}, {this.Street}, {this.Number}";
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
