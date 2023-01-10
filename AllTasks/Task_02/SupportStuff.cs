namespace Task_02
{
    internal class SupportStaff : UniversityEmployee
    {
        public string JobResponsibilities { get; set; }

        public SupportStaff(Person personalInfo, int taxID, string jobResponsibilities): 
            base(personalInfo, taxID) 
        { 
            JobResponsibilities= jobResponsibilities;
        }

        public override void GetOfficialDuties()
        {
            Console.WriteLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName}," +
                $" has the following responsibilities: {JobResponsibilities}");
        }
    }
}
