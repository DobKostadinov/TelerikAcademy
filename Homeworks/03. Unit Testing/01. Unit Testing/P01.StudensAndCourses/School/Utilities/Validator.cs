using System;

namespace School.Utilities
{
    public class Validator
    {
        public static void CheckIfNameIsNull(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(GlobalConstants.NullOrEmptyName);
            }
        }

        public static void CheckIfNumberInRange(int number, int minId, int maxId, string message)
        {
            if (number < minId ||
                number > maxId)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(
                        message,
                        minId,
                        maxId));
            }
        }

        public static void CheckIfStudentIdIsUnique(int id)
        {
            if (StudentsIdDb.UniqueStudentIds.Contains(id))
            {
                throw new ArgumentException(GlobalConstants.StudentIdIsNotUnique);
            }
        }

        public static void ValidateIfCourseIsNotFull(Course course)
        {
            if (course.CourseStudents.Count + 1 > GlobalConstants.MaxStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(
                        GlobalConstants.MaxStudentsInCourseReached, 
                        GlobalConstants.MaxStudentsInCourse));
            }
        }

        public static void ValidateIfCourseIsNotEmpty(Course course)
        {
            if (course.CourseStudents.Count == 0)
            {
                throw new ArgumentOutOfRangeException(GlobalConstants.EmptyCourse);
            }
        }

        public static void ValidateIfCourseIsNotNull(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(GlobalConstants.NullCourse);
            }

        }
    }
}
