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
            return $"{Index}, {City}, {Street}, {Number}";
        }

        public override bool Equals(object item)
        {
            if (item == null) return false;
            
            return base.Equals(item) && (item as LegalAddress)?.Index == Index;          
        }
    }
}
