using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void CheckEqualsForAddressPositive() 
        {
            var address1 = new Address("City", "Street", 1);
            var address2 = new Address("City", "Street", 1);
            Assert.IsTrue(address1.Equals(address2));      
        }

        [TestMethod]
        public void CheckEqualsForAddressNegative()
        {
            var address1 = new Address("City", "Street", 1);
            var address2 = new Address("City", "Street", 2);
            Assert.IsFalse(address1.Equals(address2));
        }

        [TestMethod]
        public void CheckNumberValidationForAddressNegative()
        {
            var address1 = new Address("City", "Street", -1);
            Assert.AreEqual(0, address1.Number); //bad
        }

        [TestMethod]
        public void CheckToStringForAddress() 
        {
            var address1 = new Address("City", "Street", 1);
            Assert.AreEqual("City, Street, 1", address1.ToString());
        }

    }
}
