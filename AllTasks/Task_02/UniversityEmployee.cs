namespace Task_02
{
    internal class UniversityEmployee
    {
        public Person PersonalInfo { get; set; }
        public int TaxID { get; set; }

        public UniversityEmployee(Person personalInfo, int taxID)
        {
            PersonalInfo = personalInfo;
            TaxID = taxID;
        }

        public virtual void GetOfficialDuties()
        {
            Console.WriteLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName} " +
                $"works in the university but has no duties yet");
        }

    }
}