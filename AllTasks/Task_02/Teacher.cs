namespace Task_02
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(Person personalInfo, int taxId, Course course): base(personalInfo, taxId)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return $"{PersonalInfo.FirstName} {PersonalInfo.LastName} " +
                $"specializes on {Course.Title}";
        }
    }
}
