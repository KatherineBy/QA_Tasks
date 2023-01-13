namespace Task_02
{
    internal class SupportStaff : UniversityEmployee
    {
        public string JobResponsibilities { get; set; }

        public SupportStaff(Person personalInfo, int taxId, string jobResponsibilities): 
            base(personalInfo, taxId) 
        { 
            JobResponsibilities= jobResponsibilities;
        }

        public override string GetOfficialDuties()
        {
            return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}," +
                $" has the following responsibilities: {JobResponsibilities}";
        }
    }
}
