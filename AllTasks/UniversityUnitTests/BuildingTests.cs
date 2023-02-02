using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class BuildingTests
    {
        [TestMethod]
        public void CheckEqualForBuildingsPositive()
        {
            var building1 = new Building(
                "aaa",
                "1111",
                new("Minsk", "Kosmonavtov", 15),
                new List<Room>
                {
                new(101, 1, "Purpose1"),
                new(201, 2, "Purpose2")
                });

            var building2 = new Building(
                "aaa",
                "1111",
                new("Minsk", "Kosmonavtov", 15),
                new List<Room>
                {
                new(101, 1, "Purpose1"),
                new(201, 2, "Purpose2")
                });

            var building3 = new Building(
               "aaa",
               "1112",
               new("Minsk", "Kosmonavtov", 15),
               new List<Room>
               {
                new(101, 1, "Purpose1"),
                new(201, 2, "Purpose2")
               });

            Assert.IsTrue(building1.Equals(building2));
           
        }

        [TestMethod]
        public void CheckEqualForBuildingsNegative()
        {
            var building1 = new Building(
                "aaa",
                "1111",
                new("Minsk", "Kosmonavtov", 15),
                new List<Room>
                {
                new(101, 1, "Purpose1"),
                new(201, 2, "Purpose2")
                });

            var building2 = new Building(
               "aaa",
               "1112",
               new("Minsk", "Kosmonavtov", 15),
               new List<Room>
               {
                new(101, 1, "Purpose1"),
                new(201, 2, "Purpose2")
               });

            Assert.IsFalse(building1.Equals(building2));
            
        }
    }
}