using School.Utilities;

namespace School
{
    public class Student
    {  
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfNameIsNull(value);

                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                Validator.CheckIfNumberInRange(
                    value,
                    GlobalConstants.MinStudentId,
                    GlobalConstants.MaxStudentId,
                    GlobalConstants.IdNotInRange);

                Validator.CheckIfStudentIdIsUnique(value);

                StudentsIdDb.UniqueStudentIds.Add(value);

                this.id = value;
            }
        }

        public void JoinCourse(Course course)
        {
            Validator.ValidateIfCourseIsNotFull(course);

            course.CourseStudents.Add(this);
        }

        public void LeaveCourse(Course course)
        {
            Validator.ValidateIfCourseIsNotEmpty(course);

            course.CourseStudents.Remove(this);
        }
    }
}
