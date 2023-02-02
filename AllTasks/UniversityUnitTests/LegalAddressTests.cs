using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class LegalAddressTests
    {
        [TestMethod]
        public void CheckToStringForLegalAddress() 
        {
            var laddress1 = new LegalAddress("11111", "City", "Street", 1);
            Assert.AreEqual("11111, City, Street, 1", laddress1.ToString());
        }

        [TestMethod]
        public void CheckEqualsForLegalAddressPositive() 
        {
            var laddress1 = new LegalAddress("11111", "City", "Street", 1);
            var laddress2 = laddress1;
            Assert.IsTrue(laddress1.Equals(laddress2));
        }

        [TestMethod]
        public void CheckEqualsForLegalAddressNegative()
        {
            var laddress1 = new LegalAddress("11111", "City", "Street", 1);
            var laddress2 = new LegalAddress("11111", "City", "Street", 2);
            Assert.IsFalse(laddress1.Equals(laddress2));
        }

    }
}
