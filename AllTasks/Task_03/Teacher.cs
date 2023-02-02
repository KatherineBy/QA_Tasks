namespace Task_03
{
    public class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }

        public Teacher(string taxId, string firstName, string lastName, Course course,
            string academicDegree, string academicTitle) :
            base(taxId, firstName, lastName)
        {
            Course = course;
            AcademicDegree = academicDegree;
            AcademicTitle = academicTitle;
        }

        public override string GetOfficialDuties()
        {
            return $"{FirstName} {LastName} " +
                $"specializes on {Course.Title}, " +
                $"has an academic degree: {AcademicDegree}, " +
                $"and an academic title: {AcademicTitle}";
        }

    }
}
