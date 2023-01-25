using System;

namespace Task_03
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course { get; set; }
        public string AcademicDegree { get; set; }
        public string AcademicTitle { get; set; }

        public Teacher(string personnelNumber, string firstName, string lastName, Course course,
            string academicDegree, string academicTitle) :
            base(personnelNumber, firstName, lastName)
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

        public override bool Equals(object item)
        {
            if (item == null || item.GetType() == this.GetType()) return false;

            Teacher check = (Teacher)item;

            return check.PersonnelNumber == this.PersonnelNumber;
        }
    }
}
