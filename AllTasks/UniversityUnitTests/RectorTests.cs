using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class RectorTests
    {
        [TestMethod]
        public void CheckGetOfficialDutiesForRector() 
        {
            var rector = new Rector(
                "N1",
                "Anton",
                "Antonov",
                "Doctor",
                "Professor");
            Assert.AreEqual("Anton Antonov is a rector", rector.GetOfficialDuties());
        }

    }
}
