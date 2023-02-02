namespace Task_03
{
    internal class Rector : UniversityEmployee
    {
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }

        public Rector(string taxId, string firstName, string lastName,
            string academicDegree, string academicTitle)
            : base(taxId, firstName, lastName)
        {
            AcademicDegree = academicDegree;
            AcademicTitle = academicTitle;
        }

        public override string GetOfficialDuties()
        {
            return $"{FirstName} {LastName} is a rector";
        }           
    }
}
