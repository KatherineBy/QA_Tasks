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

        // оптыным путем было определено, что List.Contains все-таки использует метод Equals объекта,
        // поэтому метод Equals был изменен, чтобы один и тот же человек с разной ролью мог быть добавлен в список
        
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
