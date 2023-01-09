using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class SupportStaff : UniversityEmployee
    {
        public string JobResponsibilities;

        public SupportStaff(Person personalInfo, int taxID, string jobResponsibilities): base(personalInfo, taxID) 
        { 
            JobResponsibilities= jobResponsibilities;
        }

        public override void GetOfficialDuties()
        {
            Console.WriteLine($"{PersonalInfo.FirstName} {PersonalInfo.LastName} has the following responsibilities: {JobResponsibilities}");
        }
    }
}
