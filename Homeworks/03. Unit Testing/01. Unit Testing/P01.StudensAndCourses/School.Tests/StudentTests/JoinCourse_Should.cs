using Microsoft.VisualStudio.TestTools.UnitTesting;
using School.Utilities;
using System;

namespace School.Tests.StudentTests
{
    [TestClass]
    public class JoinCourse_Should
    {
        [TestMethod]
        public void AddNewStudentToCourse()
        {
            Student student = new Student("Moni", 55555);
            Course math = new Course("Math");

            student.JoinCourse(math);

            Assert.AreEqual(1, math.CourseStudents.Count);
        }

        [TestMethod]
        public void ThrowArgumentOutOfRangeException_WhenCourseMaxLimitIsReachedAndStudentsCannotBeAdd()
        {
            Course cSharp = new Course("C#");

            for (int i = 0; i < 30; i++)
            {
                Student student = new Student(
                    DataGenerator.GenerateRandomString(), 
                    DataGenerator.GenerateNumber(
                        GlobalConstants.MinStudentId,
                        GlobalConstants.MaxStudentId));

                student.JoinCourse(cSharp);
            }

            Student lastStudent = new Student("Mitko", 87344);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => lastStudent.JoinCourse(cSharp));
        }


    }
}
