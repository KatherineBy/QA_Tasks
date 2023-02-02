using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class UniversityEmployeeTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "An unacceptable TaxId was inappropriately allowed.")]
        public void CheckTaxIdValidationForUniversityEmployeeNegative()
        {
            var item = new Teacher(
                "000000001",
                "Peter",
                "Peterson",
                new("Math", "calculations"),
                "Doctor",
                "Professor");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
         "Too long name was inappropriately allowed.")]
        public void CheckNameLengthValidationForUniversityEmployeeNegative()
        {
            var item = new Teacher(
                "000000001",
                "Vitaliy",
                "Vitaliyev",
                new("Math", "calculations"),
                "Doctor",
                "Professor");
        }

        [TestMethod]
        public void CheckEqualsforUniversityEmployeePositive()
        {
            var teacher1 = new Teacher(
               "N1",
               "Anton",
               "Antonov",
               new("History", "History"),
               "Doctor",
               "Professor");

            var teacher2 = teacher1;

            Assert.IsTrue(teacher1.Equals(teacher2));
        }

        [TestMethod]
        public void CheckEqualsforUniversityEmployeeNegative()
        {
            var teacher1 = new Teacher(
               "N1",
               "Anton",
               "Antonov",
               new("History", "History"),
               "Doctor",
               "Professor");

            var teacher2 = new Teacher(
               "N2",
               "Anton",
               "Antonov",
               new("History", "History"),
               "Doctor",
               "Professor");

            Assert.IsFalse(teacher1.Equals(teacher2));
        }

        [TestMethod]
        public void CheckEqualsforUniversityEmployeesWithSameIdAndDifRolesNegative()
        {
            var teacher = new Teacher(
               "N1",
               "Anton",
               "Antonov",
               new("History", "History"),
               "Doctor",
               "Professor");

            var rector = new Rector(
                "N1",
                "Anton",
                "Antonov",
                "Doctor",
                "Professor");

            Assert.IsFalse(teacher.Equals(rector));
        }

    }
}
