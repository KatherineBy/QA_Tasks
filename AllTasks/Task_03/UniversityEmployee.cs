namespace Task_03
{
    internal class UniversityEmployee
    {
        public string PersonnelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UniversityEmployee (string personnelNumber, string firstName, string lastName)
        {
            PersonnelNumber = personnelNumber;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
