using Task_02;

internal class Program 
{
    private static void Main(string[] args) 
    { 
        UniversityEmployee employee1 = new Teacher(
            new Person("Vasiliy", "Vasiliyev",
                new Address(1, 1, "D", "D")),
                    13547622,
                        new Course("Math", "Studying calculations etc."));

        UniversityEmployee employee2 = new DegreeTeacher(
            new Person("Dmitry", "Dmitriyev",
                new Address(1, 1, "D", "D")),
                    60937564,
                        new Course("Math", "Studying calculations etc."),
                            "Doctor", "Professor");

        UniversityEmployee employee3 = new SupportStaff(
            new Person("Olga", "Olgova",
                new Address(1, 1, "D", "D")),
                    75639562,
                       "Cleaning");

        UniversityEmployee employee4 = new DegreeTeacher(
            new Person("Dmitry", "Dmitriyev",
                new Address(1, 1, "D", "D")),
                    60937564,
                        new Course("Economics", "Economics etc"),
                            "Master", "Assistant professor");

        UniversityEmployee[] EmployeeList = 
        { 
            employee1,
            employee2,
            employee3,
            employee4
        };

        
        // to show all employees and their duties

        Console.WriteLine("The following is a list of all the university employees:");

        foreach (UniversityEmployee employee in EmployeeList)
        {
            employee.GetOfficialDuties();
        }

        Console.WriteLine("--------------------------------");

        
        // to show teachers

        Console.WriteLine("The following is a list of all the university teachers:");

        foreach (UniversityEmployee employee in EmployeeList) 
        { 
            if (employee is Teacher | employee is DegreeTeacher) 
            {
                employee.GetOfficialDuties();
            }
        }

    }
}