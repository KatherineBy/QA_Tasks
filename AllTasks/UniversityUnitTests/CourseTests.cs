using Task_03;

namespace UniversityUnitTests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CheckEqualsForCoursePositive() 
        {
            var course1 = new Course("Title", "Description");
            var course2 = course1;
            Assert.IsTrue(course1.Equals(course2));
        }

        [TestMethod]
        public void CheckEqualsForCourseNegative()
        {
            var course1 = new Course("Title", "Description");
            var course2 = new Course("Title1", "Description1");
            Assert.IsFalse(course1.Equals(course2));
        }


    }
}
