using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.CourseTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void CreateNewCourse_WhenCorrectNameValueIsPassed()
        {
            Course web = new Course("Web");

            Assert.AreEqual("Web", web.Name);
        }

        [TestMethod]
        public void CreateNewCourse_WhichShouldHaveEmptyCollectionOfStudents()
        {
            Course web = new Course("Node");
            
            Assert.AreEqual(0, web.CourseStudents.Count());
        }

        [TestMethod]
        public void ShouldThrowArgumentNullException_WhenNullOrEmptyNameValueIsPassed()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Course(null));
        }
    }
}
