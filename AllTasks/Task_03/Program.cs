using System;
using Task_03;

internal class Program
{
    private static void Main(string[] args)
    {
        //create employees list

        UniversityEmployee employee1 = new Teacher(
           "N000000001", "Vasiliy", "Vasiliyev", "Higher Mathematics", "Doctor", "Professor");

        UniversityEmployee employee2 = new Teacher(
            "N000000002", "Dmitry", "Dmitriyev", "History", "Master", "Assistant professor");
            
        Rector rector = new Rector(
            "N000000003", "Anton", "Antonov", "Doctor", "Professor");
       

        UniversityEmployee[] employeeList =
        {
            employee1,
            employee2,
            rector,
        };

        //create buildings list

        Building building1 = new("Main Building", "I000001",
            new Address("Minsk", "Vaneeva", 27),
                new Room[]
                {
                    new Room(101, 1, "Lecture Hall"),
                    new Room(102, 1, "Lecture Hall"),
                    new Room(103, 1, "Utility Room"),
                    new Room(201, 2, "Laboratory"),
                    new Room(202, 2, "Classroom")
                });

        Building building2 = new("Academic Building N2", "I000002",
            new Address("Minsk", "Vaneeva", 28),
                new Room[]
                {
                    new Room(101, 1, "Classroom"),
                    new Room(102, 1, "Classroom"),
                    new Room(201, 2, "Classroom"),
                    new Room(202, 2, "Classroom"),
                    new Room(301, 1, "Rectorate")
                });

        Building building3 = new("Academic Building N3", "I000003",
            new Address("Minsk", "Vaneeva", 30),
                new Room[]
                {
                    new Room(201, 2, "Lecture Hall"),
                    new Room(202, 2, "Lecture Hall"),
                    new Room(203, 2, "Classroom"),
                    new Room(204, 2, "Classroom"),
                    new Room(205, 2, "Laboratory")
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