using School.Utilities;
using System.Collections.Generic;

namespace School
{
    public class School
    {
        private string name;
        private ICollection<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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


        public ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
        }

        public void AddCourse(Course course)
        {
            Validator.ValidateIfCourseIsNotNull(course);

            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Validator.ValidateIfCourseIsNotNull(course);

            this.Courses.Remove(course);
        }
    }
}
