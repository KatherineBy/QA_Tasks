using System.Net;
using System;

using Task_02;

internal class Program 
{
    private static void Main(string[] args) 
    { 
        UniversityEmployee employee1 = new Teacher(
        new Person("Vasiliy", "Vasilyev",
                        new Address(1, 1, "D", "D")),
                            11111111,
                                new Course("Math", "Studying calculations etc."));

        UniversityEmployee employee2 = new DegreeTeacher(
            new Person("Dmitry", "Dmitryev",
                new Address(1, 1, "D", "D")),
                    11111111,
                        new Course("Math", "Studying calculations etc."),
                            "Doctor", "Professor");

        UniversityEmployee[] EmployeeList = { employee1, employee2 };

        foreach (UniversityEmployee employee in EmployeeList)
        {
            employee.GetOfficialDuties();
        }
    }
}