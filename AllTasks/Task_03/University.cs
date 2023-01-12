namespace Task_03
{
    internal class University
    {
        
        public Rector Rector { get; set; }
        public LegalAddress LegalAddress { get; set; }
        public UniversityEmployee[] Employees { get; set; }
        public Building[] Buildings { get; set; }

        public University(Rector rector, LegalAddress legalAddress, UniversityEmployee[] employees,  Building[] buildings)
        {
            Employees = employees;
            LegalAddress = legalAddress;
            Rector = rector;
            Buildings = buildings;
        }
    }
}
