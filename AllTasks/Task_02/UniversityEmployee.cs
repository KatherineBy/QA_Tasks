using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class UniversityEmployee
    {
        public Person PersonalInfo;
        public int TaxID;

        public UniversityEmployee(Person personalInfo, int taxID)
        {
            PersonalInfo = personalInfo;
            TaxID = taxID;
        }

        public virtual void GetOfficialDuties()
        {
            Console.WriteLine("aaaa");
        }
    }
}
