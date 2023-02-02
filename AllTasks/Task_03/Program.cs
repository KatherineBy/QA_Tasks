using System.Collections.Immutable;
using Task_03;

internal class Program
{
    private static void Main(string[] args)
    {
        //create employees list

        var employee1 = new Teacher(
            "N000000001",
            "Dmitry",
            "Dmitriyev",
            new("History", "Studying history etc."),
            "Master",
            "Assistant professor");

        var employee2 = new Teacher(
           "N000000002", 
           "Vasiliy", 
           "Vasiliye", 
           new("Higher Mathematics", "Studying complex calculations etc."), 
           "Doctor", 
           "Professor");
  
        var employee3 = new Teacher(
            "N000000004",
            "Ekaterina",
            "Busel",
            new("Economics", "studying economics etc"),
            "Doctor",
            "Professor");

        var employee4 = new Teacher(
           "N000000003",
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
       
        var employeeList = new List<UniversityEmployee>
        {
            employee1,
            employee2,
            employee3,
            employee4,
            rector,
        };

        //create buildings list

        var building1 = new Building(
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

        var building2 = new Building(
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

        var building3 = new Building(
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
        
        var buildingList = new List<Building>
       {
            building1,
            building2,
            building3,
        };

        //create University

        var university = new University(
            rector,
            new LegalAddress("220-051", "Minsk", "Vaneeva", 27),
            employeeList,
            buildingList);

        Console.WriteLine("5.1 --------------------------------------------------------------");

        // 5.1 employyes with last name starts with X

        var selectedLetter = "A";
        var employeesOnSelectedLetter = university.Employees
            .Where(x => x.LastName.StartsWith(selectedLetter))
            .ToList();

        foreach(var item in employeesOnSelectedLetter) 
        {
            Console.WriteLine("Employee {0} {1}, Tax ID {2}", 
                item.LastName, item.FirstName, item.TaxId);
        }
        Console.WriteLine("5.2 --------------------------------------------------------------");

        // 5.2 teachers of X course

        var selectedCourse = "Higher Mathematics";
        var teachersOfSelectedCourse = university.Employees
            .OfType<Teacher>()
            .Where(x => x.Course.Title == selectedCourse)
            .ToList();
        

        foreach (var item in teachersOfSelectedCourse)
        {
            Console.WriteLine("Employee {0} {1}, Tax ID {2}, course {3}",
                item.LastName, item.FirstName, item.TaxId, item.Course.Title);
        }
        Console.WriteLine("5.3 --------------------------------------------------------------");

        // 5.3 personnel number and professional duties 

        var persNumberAndDuties = university.Employees
            .Select(x => (num: x.TaxId, duty: x.GetOfficialDuties()))
            .ToList();

        foreach (var item in persNumberAndDuties)
        {
            Console.WriteLine("TaxId {0}, official duties: {1}",
                item.num, item.duty);
        }
        Console.WriteLine("5.4 --------------------------------------------------------------");

        // 5.4 buildings with selected room.number

        var selectedRoomNumber = 101;
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
                
        
        Console.WriteLine("6.1 --------------------------------------------------------------");

        var bseu = new University(
            rector,
            new LegalAddress("220-051", "Minsk", "Vaneeva", 15),
            new(),
            new());

        var employee6 = new Teacher(
          "N000000006",
          "Maria",
          "Mariu",
          new("Higher Mathematics", "Studying complex calculations etc."),
          "Doctor",
          "Professor");

        try 
        {
            bseu.AddEmployee(employee6);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("6.3(a) -----------------------------------------------------------");

        university.Employees.Sort();
        university.Employees.Reverse();
        foreach (var x in university.Employees)
        {
            Console.WriteLine("{0} {1} {2}", x.LastName, x.FirstName, x.GetNameLength());
        }

        Console.WriteLine("6.3(b) -----------------------------------------------------------");

        university.Employees.Sort(new TaxIdComparerDescending());
        foreach (var x in university.Employees)
        {
            Console.WriteLine("{0} {1} {2}", x.LastName, x.FirstName, x.GetNameLength());
        }

        Console.WriteLine("6.3(c) -----------------------------------------------------------");

        var sortedEmployees = university.Employees
            .OrderByDescending(x => x.GetNameLength())
	        .ToList();

        foreach (var x in sortedEmployees)
        {
            Console.WriteLine("{0} {1} {2}", x.LastName, x.FirstName, x.GetNameLength());
        }

        var adr = new Address("aaa", "dddd", -1);
                

        
       

    }
}