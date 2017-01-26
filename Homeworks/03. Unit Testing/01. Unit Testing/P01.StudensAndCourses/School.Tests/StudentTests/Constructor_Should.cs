using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests.StudentTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void CreateNewStudentWithCorrectName_WhenCorrectNameIsPassed()
        {
            var student = new Student("Ivan", 10001);

            Assert.AreEqual("Ivan", student.Name);
        }

        [TestMethod]
        public void CreateNewStudentWithCorrectId_WhenValidIdIsPassed()
        {
            var student = new Student("Penko", 10002);

            Assert.AreEqual(10002, student.Id);
        }
        
        [TestMethod]
        public void ShouldThrowArgumentNullException_WhenNullOrEmptyNameValueIsPassed()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Student(null, 10003));
        }

        [TestMethod]
        public void ShouldThrowArgumentOutOfRangeException_WhenNotInRangeValueIsPassed()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Student("Ivan", 657));
        }

        [TestMethod]
        public void ShouldThrowArgumentException_WhenStudentIdAlreadyExistIsPassed()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student("Petkan", 10001));
        }
    }
}
