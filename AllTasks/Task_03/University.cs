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

        
        public void AddObject<T>(T newItem, List<T> items) 
        {
            foreach (T item in items)
            {
                if (item.Equals(newItem))
                {
                    return;
                }
            }
            
            items.Add(newItem);
        }
    }
}
