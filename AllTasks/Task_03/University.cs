using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Task_03
{
    internal class University
    {      
        public Rector Rector { get; set; }
        public LegalAddress LegalAddress { get; set; }
        public List<UniversityEmployee> Employees { get; set; }
        public List<Building> Buildings { get; set; }

        public University(Rector rector, LegalAddress legalAddress, 
            List<UniversityEmployee> employees,  List<Building> buildings)
        {
            Employees = employees;
            LegalAddress = legalAddress;
            Rector = rector;
            Buildings = buildings;
        }       
        public void AddEmployee(UniversityEmployee newEmployee, List<UniversityEmployee> employees) 
        {
            foreach (UniversityEmployee item in employees)
            {
                if (item.Equals(newEmployee))
                {
                    return;
                }
            }
            
            employees.Add(newEmployee);
        }
        public void AddBuilding(Building newBuilding, List<Building>buildings)
        {
            foreach (Building item in buildings)
            {
                if (item.Equals(newBuilding))
                {
                    return;
                }
            }

            buildings.Add(newBuilding);
        }

    }
}
