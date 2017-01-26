using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace School.Tests.SchoolTests
{
    [TestClass]
    public class RemoveCourse_Should
    {
        private School school;
        private Course math;

        [TestInitialize]
        public void CreateNeededSchoolAndCourse()
        {
            school = new School("Beronov");
            math = new Course("Math");
        }

        [TestMethod]
        public void RemoveCourse()
        {
            school.AddCourse(math);

            school.RemoveCourse(math);

            Assert.AreEqual(0, school.Courses.Count());
        }

        [TestMethod]
        public void ThorwArgumentNullException_IfPassedCourseIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => school.RemoveCourse(null));
        }
    }
}
