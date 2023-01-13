using System;
using Task_03;

internal class Program
{
    private static void Main(string[] args)
    {
        //create employees list

        var employee1 = new Teacher(
           "N000000001", "Vasiliy", "Vasiliyev", "Higher Mathematics", "Doctor", "Professor");

        var employee2 = new Teacher(
            "N000000002", "Dmitry", "Dmitriyev", "History", "Master", "Assistant professor");
            
        var rector = new Rector(
            "N000000003", "Anton", "Antonov", "Doctor", "Professor");
       

        UniversityEmployee[] employeeList =
        {
            employee1,
            employee2,
            rector,
        };

        //create buildings list

        Building building1 = new(
            "Main Building", 
            "I000001",
            new ("Minsk", "Vaneeva", 27),
            new Room[]
            {
                new(101, 1, "Lecture Hall"),
                new(102, 1, "Lecture Hall"),
                new(103, 1, "Utility Room"),
                new(201, 2, "Laboratory"),
                new(202, 2, "Classroom")
            });

        Building building2 = new(
            "Academic Building N2", 
            "I000002",
            new("Minsk", "Vaneeva", 28),
            new Room[]
            {
                new(101, 1, "Classroom"),
                new(102, 1, "Classroom"),
                new(201, 2, "Classroom"),
                new(202, 2, "Classroom"),
                new(301, 1, "Rectorate")
            });

        Building building3 = new(
            "Academic Building N3", 
            "I000003",
            new Address("Minsk", "Vaneeva", 30),
            new Room[]
            {
                new(201, 2, "Lecture Hall"),
                new(202, 2, "Lecture Hall"),
                new(203, 2, "Classroom"),
                new(204, 2, "Classroom"),
                new(205, 2, "Laboratory")
            });

        Building[] buildingList =
       {
            building1,
            building2,
            building3,
        };

        //create University

        University university = new(
            rector,
            new LegalAddress("220-051", "Minsk", "Vaneeva", 27),
            employeeList,
            buildingList);
     
    }
}