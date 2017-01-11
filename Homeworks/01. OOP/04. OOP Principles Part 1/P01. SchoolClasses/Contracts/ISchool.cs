namespace P01.SchoolClasses.Contracts
{
    using Models;

    public interface ISchool
    {
        void AddClass(ClassOfStudents schoolClass);

        void RemoveClass(ClassOfStudents schoolClass);   
    }
}
