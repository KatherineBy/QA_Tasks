namespace Task_03
{
    public class University
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
                
        public void AddEmployee(UniversityEmployee newEmployee) 
        {
            if(Employees.Contains(newEmployee))
            {
                return;
            }             
            Employees.Add(newEmployee);
        }
        public void AddBuilding(Building newBuilding)
        {
            if (Buildings.Contains(newBuilding))
            {
                return;
            }
            Buildings.Add(newBuilding);
        }

    }
}
