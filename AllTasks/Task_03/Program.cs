﻿using System.Security.Cryptography.X509Certificates;
using Task_03;

internal class Program
{
    private static void Main(string[] args)
    {
        //create employees list

        var employee1 = new Teacher(
           "N000000001", 
           "Vasiliy", 
           "Vasiliyev", 
           new("Higher Mathematics", "Studying complex calculations etc."), 
           "Doctor", 
           "Professor");

        var employee2 = new Teacher(
            "N000000002", 
            "Dmitry", 
            "Dmitriyev", 
            new("History", "Studying history etc."),
            "Master", 
            "Assistant professor");

        var employee3 = new Teacher(
            "N000000004",
            "Ekaterina",
            "Busel",
            new("Economics", "studying economics etc"),
            "Doctor",
            "Professor");

        var employee4 = new Teacher(
           "N000000005",
           "Oleg",
           "Dmitriyev",
           new("Higher Mathematics", "Studying complex calculations etc."),
           "Master",
           "Assistant professor");

        var rector = new Rector(
            "N000000003", 
            "Anton", 
            "Antonov", 
            "Doctor", 
            "Professor");
       
        List<UniversityEmployee> employeeList = new List<UniversityEmployee>
        {
            employee1,
            employee2,
            employee3,
            employee4,
            rector,
        };

        //create buildings list

        Building building1 = new(
            "Main Building", 
            "I000001",
            new ("Minsk", "Vaneeva", 27),
            new List<Room>
            {
                new(101, 1, "Lecture Hall"),
                new(102, 1, "Lecture Hall"),
                new(103, 1, "Utility Room"),
                new(201, 2, "Laboratory"),
                new(202, 2, "Classroom"),
                new(301, 3, "Classroom")
            });

        Building building2 = new(
            "Academic Building N2", 
            "I000002",
            new("Minsk", "Vaneeva", 28),
            new List<Room>
            {
                new(101, 1, "Classroom"),
                new(102, 1, "Classroom"),
                new(201, 2, "Classroom"),
                new(202, 2, "Classroom"),
                new(301, 3, "Rectorate"),
                new(302, 3, "Classroom")
            });

        Building building3 = new(
            "Academic Building N3", 
            "I000003",
            new Address("Minsk", "Vaneeva", 30),
            new List<Room>
            {
                new(201, 2, "Lecture Hall"),
                new(202, 2, "Lecture Hall"),
                new(203, 2, "Classroom"),
                new(204, 2, "Classroom"),
                new(205, 2, "Laboratory")
            });

        
        
        List<Building> buildingList = new List<Building>
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

        Console.WriteLine("5.1 --------------------------------------------------------------");

        // 5.1 employyes with last name starts with X

        string selectedLetter = "A";
        var employeesOnSelectedLetter = university.Employees
            .Where(x => x.LastName.StartsWith(selectedLetter))
            .ToList();

        foreach(var item in employeesOnSelectedLetter) 
        {
            Console.WriteLine("Employee {0} {1}, personnel number {2}", 
                item.LastName, item.FirstName, item.PersonnelNumber);
        }
        Console.WriteLine("5.2 --------------------------------------------------------------");

        // 5.2 teachers of X course

        string selectedCourse = "Higher Mathematics";
        var teachersOfSelectedCourse = university.Employees
            .OfType<Teacher>()
            .Where(x => x.Course.Title == selectedCourse)
            .ToList();
        

        foreach (var item in teachersOfSelectedCourse)
        {
            Console.WriteLine("Employee {0} {1}, personnel number {2}, course {3}",
                item.LastName, item.FirstName, item.PersonnelNumber, item.Course.Title);
        }
        Console.WriteLine("5.3 --------------------------------------------------------------");

        // 5.3 personnel number and professional duties 

        var persNumberAndDuties = university.Employees
            .Select(x => (num: x.PersonnelNumber, duty: x.GetOfficialDuties()))
            .ToList();

        foreach (var item in persNumberAndDuties)
        {
            Console.WriteLine("Personnel Number {0}, official duties: {1}",
                item.num, item.duty);
        }
        Console.WriteLine("5.4 --------------------------------------------------------------");

        // 5.4 buildings with selected room.number

        int selectedRoomNumber = 101;
        var buildingsWithRoom = university.Buildings
            .SelectMany(x => x.Rooms,(x, y) => (Addr: x.Address, RoomNum: y.Number))
            .Where(x => x.RoomNum == selectedRoomNumber)
            .Select(x => x.Addr)
            .ToList();

        foreach(var item in buildingsWithRoom) 
        {
            Console.WriteLine($"Address: {item}");
        }
        Console.WriteLine("5.5 --------------------------------------------------------------");

        // 5.5 building with max amount of rooms

        var buildingWithMaxRooms = university.Buildings
            .Select(x => (x.Address, cnt: x.Rooms.Count))
            .GroupBy(x => x.cnt)
            .MaxBy(x => x.Key);
                    
        foreach (var item in buildingWithMaxRooms) 
        {
            Console.WriteLine($"Address: {item.Address}");
        }
        Console.WriteLine("5.6 --------------------------------------------------------------");

        // 5.6 the most popular last name + count

        var mostPopularLastName = university.Employees
            .GroupBy(x => x.LastName)
            .Select(x => new { Name = x.Key, Count = x.Count() })
            .MaxBy(x => x.Count);
                                
                              

        Console.WriteLine($"LastName: {mostPopularLastName.Name}, " +
            $"Amount: {mostPopularLastName.Count}");

    }
}