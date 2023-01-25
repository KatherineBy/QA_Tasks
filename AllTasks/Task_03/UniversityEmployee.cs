using System.Reflection.Metadata.Ecma335;

namespace Task_03
{
    internal abstract class UniversityEmployee
    {
        public string PersonnelNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UniversityEmployee (string personnelNumber, string firstName, string lastName)
        {
            PersonnelNumber = personnelNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract string GetOfficialDuties();

        public override bool Equals(object item)
        {
            if (item == null || item.GetType() == this.GetType()) return false;
            
            UniversityEmployee check = (UniversityEmployee)item;

            return check.PersonnelNumber == this.PersonnelNumber;
        }
              
    }
}
