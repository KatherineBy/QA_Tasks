namespace Task_02
{
    internal class DegreeTeacher : Teacher
    {
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }

        public DegreeTeacher(Person personalInfo, int taxId, 
            Course course, string academicDegree, string academicTitle) : 
            base(personalInfo, taxId, course)
        {
            AcademicDegree= academicDegree;
            AcademicTitle= academicTitle;
        }
        public override string GetOfficialDuties()
        {
            return $"{PersonalInfo.FirstName} {PersonalInfo.LastName}," + 
                $"specializes on {Course.Title}, " +
                $"has the following academic degree: {AcademicDegree}, " +
                $"and the following academic title: {AcademicTitle}";
        }
    }
}
