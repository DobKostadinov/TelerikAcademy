namespace P01.SchoolClasses.Models
{
    public class Student : Person
    {
        private string facultyNumber;

        public Student(string name, string facultyNumber)
            : base(name)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            private set { this.facultyNumber = value; }
        }
    }
}
