using P01.SchoolClasses.Contracts;
using System.Collections.Generic;

namespace P01.SchoolClasses.Models
{
    public class School : ISchool
    {
        private ICollection<ClassOfStudents> classesOfStudents;

        public School()
        {
            this.classesOfStudents = new HashSet<ClassOfStudents>();
        }

        public ICollection<ClassOfStudents> ClassesOfStudents
        {
            get { return this.classesOfStudents; }
            set { this.classesOfStudents = value; }
        }

        public void AddClass(ClassOfStudents schoolClass)
        {
            this.ClassesOfStudents.Add(schoolClass);
        }

        public void RemoveClass(ClassOfStudents schoolClass)
        {
            this.ClassesOfStudents.Remove(schoolClass);
        }
    }
}
