using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class DegreeTeacher : Teacher
    {
        public string AcademicDegree;
        public string AcademicTitle;

        public DegreeTeacher(Person personalInfo, int taxID, Course course, string academicDegree, string academicTitle) : 
            base(personalInfo, taxID, course)
        {
            AcademicDegree= academicDegree;
            AcademicTitle= academicTitle;
        }
        public override void GetOfficialDuties()
        {
            Console.WriteLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName} specializes on {Course.Title}, " +
                $"has the following academic degree: {AcademicDegree}, " +
                $"and the following academic title: {AcademicTitle}");
        }
    }
}
