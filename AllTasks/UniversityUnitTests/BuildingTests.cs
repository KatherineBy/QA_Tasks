using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class BuildingTests
    {
        Building building1 = new(
                "Title",
                "11111",
                new("City", "Street", 1),
                new List<Room>()
                );

        [TestMethod]
        public void CheckEqualsForBuildingsPositive()
        {
            
            var building2 = building1;
          
            Assert.IsTrue(building1.Equals(building2));
           
        }

        [TestMethod]
        public void CheckEqualsForBuildingsNegative()
        {
            var building2 = new Building(
               "Title",
               "11112",
               new("City", "Street", 1),
               new List<Room>()
               );

            Assert.IsFalse(building1.Equals(building2));         
        }

        [TestMethod]
        public void CheckToStringForBuildingPositive() 
        {
            Assert.AreEqual("Title, 11111, City, Street, 1", building1.ToString());
        }

    }
}