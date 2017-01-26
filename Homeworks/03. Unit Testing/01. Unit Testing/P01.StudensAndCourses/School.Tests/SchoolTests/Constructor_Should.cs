using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.SchoolTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void CreateNewSchool_WhenCorrectNameValueIsPassed()
        {
            School school = new School("Ivan Vazov");

            Assert.AreEqual("Ivan Vazov", school.Name);
        }

        [TestMethod]
        public void CreateNewSchool_WhichShouldHaveEmptyCollectionOfCourses()
        {
            School school = new School("Petyr Beron");

            Assert.AreEqual(0, school.Courses.Count());
        }

        [TestMethod]
        public void ShouldThrowArgumentNullException_WhenNullOrEmptyNameValueIsPassed()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new School(null));
        }

    }
}
