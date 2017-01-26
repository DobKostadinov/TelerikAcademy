using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.SchoolTests
{
    [TestClass]
    public class AddCourse_Should
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
        public void AddNewCourse()
        {          
            school.AddCourse(math);

            Assert.AreEqual(1, school.Courses.Count());
        }

        [TestMethod]
        public void ThorwArgumentNullException_IfPassedCourseIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => school.AddCourse(null));
        }
    }
}
