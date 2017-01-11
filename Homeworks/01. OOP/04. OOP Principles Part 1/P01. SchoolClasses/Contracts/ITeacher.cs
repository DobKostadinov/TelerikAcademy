namespace P01.SchoolClasses.Contracts
{
    using Models;

    interface ITeacher
    {
        void AddDiscipline(Discipline discipline);

        void RemoveDiscipline(Discipline discipline);
    }
}
