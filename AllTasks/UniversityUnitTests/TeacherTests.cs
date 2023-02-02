using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class TeacherTests
    {
        [TestMethod]
        public void CheckGetOfficaiDutiesForTeacher()
        {
            var teacher = new Teacher(
                "N1",
                "Anton",
                "Antonov",
                new("History", "History"),
                "Doctor",
                "Professor");
            
            Assert.AreEqual("Anton Antonov specializes on History, " +
                "has an academic degree: Doctor, and an academic title: Professor",
                teacher.GetOfficialDuties());
        }
    }
}
