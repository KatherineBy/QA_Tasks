using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void CheckRoomNumberNegative() 
        {
            var room = new Room(-1, 1, "Purpose");
            Assert.AreEqual(0, room.Number);
        }

        [TestMethod]
        public void CheckRoomFloorNegative()
        {
            var room = new Room(1, -1, "Purpose");
            Assert.AreEqual(0, room.Floor);
        }

        [TestMethod]
        public void CheckEqualForRoomsPositive() 
        {
            var room1 = new Room(1, 1, "Purpose");
            var room2 = room1;
            Assert.IsTrue(room1.Equals(room2));
        }

        [TestMethod]
        public void CheckEqualForRoomsNegative()
        {
            var room1 = new Room(1, 1, "Purpose");
            var room2 = new Room(2, 1, "Purpose");
            Assert.IsFalse(room1.Equals(room2));
        }

    }
}
