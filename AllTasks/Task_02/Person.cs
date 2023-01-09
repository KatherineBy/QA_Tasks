namespace Task_02
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

    }
}
