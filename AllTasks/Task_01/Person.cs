namespace Task_01
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public Address Address;

        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

    }
}
