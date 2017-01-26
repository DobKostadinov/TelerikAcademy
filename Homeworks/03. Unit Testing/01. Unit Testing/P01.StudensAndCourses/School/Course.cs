using School.Utilities;
using System.Collections.Generic;

namespace School
{    
    public class Course
    {
        private ICollection<Student> courseStudents;

        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.courseStudents = new List<Student>();
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

        public ICollection<Student> CourseStudents
        {
            get
            {
                return this.courseStudents;
            }
        }
    }
}
