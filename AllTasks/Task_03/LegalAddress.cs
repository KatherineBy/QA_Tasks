namespace Task_03
{
    internal class LegalAddress: Address
    {
        public string Index { get; set; }

        public LegalAddress(string index, string city, string street, int number): base(city, street, number) 
        { 
            Index = index;
        }
    }
}
