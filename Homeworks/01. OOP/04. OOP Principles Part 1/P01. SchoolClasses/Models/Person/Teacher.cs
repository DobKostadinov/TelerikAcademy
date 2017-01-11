namespace P01.SchoolClasses.Models
{
    using Contracts;
    using System.Collections.Generic;

    public class Teacher : Person , ITeacher
    {
        private ICollection<Discipline> disciplines;

        public Teacher(string name) 
            : base(name)
        {
            this.disciplines = new HashSet<Discipline>();
        }       

        public ICollection<Discipline> Disciplines
        {
            get { return this.disciplines; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }
    }
}
