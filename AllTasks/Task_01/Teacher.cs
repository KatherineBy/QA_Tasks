using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Teacher : UniversityEmployee
    {
        public Course Course;

        public Teacher(Person personalInfo, int taxID, Course course): base(personalInfo, taxID)
        {
            Course = course;
        }

        public override void GetOfficialDuties()
        {
            Console.WriteLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName} specializes on {Course.Title}");
        }
    }
}
