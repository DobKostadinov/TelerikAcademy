namespace P01.SchoolClasses.Contracts
{
    using Models;

    public interface IClassOfStudents
    {
        void AddStudent(Student student);


        void RemoveStudent(Student student);


        void AddTeacher(Teacher teacher);


        void RemoveTeacher(Teacher teacher);
    }
}
