namespace Task_02
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }

        public Teacher(Person personalInfo, int taxID, Course course): base(personalInfo, taxID)
        {
            Course = course;
        }

        public override void GetOfficialDuties()
        {
            Console.WriteLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName} " +
                $"specializes on {Course.Title}");
        }
    }
}
