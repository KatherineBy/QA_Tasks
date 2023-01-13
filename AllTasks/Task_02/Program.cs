using Task_02;

internal class Program 
{
    private static void Main(string[] args) 
    { 
        var employee1 = new Teacher(
            new("Vasiliy", "Vasiliyev",
                new(1, 1, "Pobediteley", "Minsk")),
            13547622,
            new("Higher Mathematics", "Studying complex calculations etc."));

        var employee2 = new DegreeTeacher(
            new("Dmitry", "Dmitriyev",
                new(34, 2, "Nebesnaya", "Minsk")),
            60937564,
            new("History", "Studying history etc."),
            "Doctor", 
            "Professor");

        var employee3 = new SupportStaff(
            new("Oleg", "Olegov",
                new(45, 3, "Vaneeva", "Minsk")),
            75639562,
            "Cleaning");

        var employee4 = new DegreeTeacher(
            new("Anton", "Antonov",
                new(5, 4, "Miastrowskaya", "Brest")),
            60937564,
            new ("Economics", "studying economics etc"),
            "Master", 
            "Assistant professor");

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
            Console.WriteLine(employee.GetOfficialDuties());
        }

        Console.WriteLine("--------------------------------");

        
        // to show teachers

        Console.WriteLine("The following is a list of all teachers:");

        foreach (UniversityEmployee employee in EmployeeList) 
        { 
            if (employee is Teacher) 
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }
        }

    }
}