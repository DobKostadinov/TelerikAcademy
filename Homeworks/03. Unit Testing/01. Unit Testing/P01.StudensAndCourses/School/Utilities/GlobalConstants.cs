namespace School.Utilities
{
    public class GlobalConstants
    {
        // Student
        public const int MinStudentId = 10000;
        public const int MaxStudentId = 99999;

        // Course
        public const int MaxStudentsInCourse = 30;

        // Validation messages
        public const string NullOrEmptyName = "Name cannot be null or empty";
        public const string IdNotInRange = "Id should be between {0} and {1}";
        public const string MaxStudentsInCourseReached = "The course can have max {0}!";
        public const string EmptyCourse = "The course does not have any students!";
        public const string NullCourse = "The course cannot be null!";
        public const string StudentIdIsNotUnique = "The id is already in use!";
    }
}
