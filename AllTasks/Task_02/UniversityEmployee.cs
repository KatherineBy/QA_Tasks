namespace Task_02
{
    internal abstract class UniversityEmployee
    {
        public Person PersonalInfo { get; set; }
        public int TaxId { get; set; }

        public UniversityEmployee(Person personalInfo, int taxID)
        {
            PersonalInfo = personalInfo;
            TaxId = taxID;
        }

        public abstract string GetOfficialDuties();
        
    }
}