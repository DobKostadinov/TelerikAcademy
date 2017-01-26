using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace School.Tests.StudentTests
{
    [TestClass]
    public class LeaveCourse_Should
    {
        [TestMethod]
        public void RemoveStudentFromCourse()
        {
            Course java = new Course("Java");
            Student james = new Student("James", 32454);
            Student mark = new Student("Mark", 87893);

            james.JoinCourse(java);
            mark.JoinCourse(java);

            mark.LeaveCourse(java);

            Assert.AreEqual(1, java.CourseStudents.Count);
        }

        [TestMethod]
        public void ThrowArgumentOutOfRangeException_IfStudentWantsToLeaveEmptyCourse()
        {
            Course js = new Course("JS");
            Student james = new Student("James", 54634);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => james.LeaveCourse(js));
        }
    }
}
