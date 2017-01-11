using P01.SchoolClasses.Contracts;
using System.Collections.Generic;

namespace P01.SchoolClasses.Models
{
    public class ClassOfStudents : IClassOfStudents, ICommentable
    {
        private string id;
        private string comment;
        private ICollection<Teacher> teachers;
        private ICollection<Student> students;

        public ClassOfStudents(string id)
        {
            this.Id = id;
            this.teachers = new HashSet<Teacher>();
            this.students = new HashSet<Student>();
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public ICollection<Teacher> Teachers
        {
            get { return this.teachers; }
            private set { this.teachers = value; }
        }

        public ICollection<Student> Students
        {
            get { return this.students; }
            private set { this.students = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Remove(teacher);
        }
    }
}
