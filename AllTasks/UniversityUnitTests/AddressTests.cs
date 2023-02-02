using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void CheckNumberValidationInConstructorForAddressNegative()
        {
            var address1 = new Address("City", "Street", -1);
            Assert.AreEqual(address1.Number, 0); //bad
        }

    }
}
