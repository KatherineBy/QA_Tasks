using Task_02;

internal class Program 
{
    private static void Main(string[] args) 
    { 
        UniversityEmployee employee1 = new Teacher(
            new Person("Vasiliy", "Vasiliyev",
                new Address(1, 1, "Pobediteley", "Minsk")),
                    13547622,
                        new Course("Higher Mathematics", "Studying complex calculations etc."));

        UniversityEmployee employee2 = new DegreeTeacher(
            new Person("Dmitry", "Dmitriyev",
                new Address(34, 2, "Nebesnaya", "Minsk")),
                    60937564,
                        new Course("History", "Studying history etc."),
                            "Doctor", "Professor");

        UniversityEmployee employee3 = new SupportStaff(
            new Person("Olga", "Olgova",
                new Address(45, 3, "Vaneeva", "Minsk")),
                    75639562,
                       "Cleaning");

        UniversityEmployee employee4 = new DegreeTeacher(
            new Person("Anton", "Antonov",
                new Address(5, 4, "Miastrowskaya", "Brest")),
                    60937564,
                        new Course("Economics", "studying economics etc"),
                            "Master", "Assistant professor");

        UniversityEmployee[] EmployeeList = 
        { 
            employee1,
            employee2,
            employee3,
            employee4
        };

        
        // to show all employees and their duties

        Console.WriteLine("The following is a list of all employees:");

        foreach (UniversityEmployee employee in EmployeeList)
        {
            employee.GetOfficialDuties();
        }

        Console.WriteLine("--------------------------------");

        
        // to show teachers

        Console.WriteLine("The following is a list of all teachers:");

        foreach (UniversityEmployee employee in EmployeeList) 
        { 
            if (employee is Teacher | employee is DegreeTeacher) 
            {
                employee.GetOfficialDuties();
            }
        }

    }
}