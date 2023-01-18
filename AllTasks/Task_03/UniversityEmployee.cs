﻿using System.Reflection.Metadata.Ecma335;

namespace Task_03
{
    internal class UniversityEmployee
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
                
        public override bool Equals(object item)
        {
            if (item is UniversityEmployee)
            {
                UniversityEmployee check = (UniversityEmployee)item;
                return check.PersonnelNumber == this.PersonnelNumber;
            }
            else
            {
                return false;
            }
        }
              
    }
}
