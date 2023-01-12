using System;

namespace Task_03
{
    internal class Teacher: UniversityEmployee
    {
        public string Course { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }

        public Teacher(string personnelNumber, string firstName, string lastName, string course, 
            string academicDegree, string academicTitle):
            base(personnelNumber, firstName, lastName)
        {
            Course = course;
            AcademicDegree = academicDegree;
            AcademicTitle = academicTitle;
        }

    }
}
