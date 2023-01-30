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

        //Personnel Number is unique throughout the university for each employee,
        //however each employee may have several roles (e.g. a Teacher and a Rector);
        //In that case these objects are NOT regarded as Equal.
        
        public override bool Equals(object item)
        {
            if (item == null || item.GetType() != GetType()) return false;
            
            UniversityEmployee check = (UniversityEmployee)item;

            return check.PersonnelNumber == PersonnelNumber;
        }
              
    }
}
