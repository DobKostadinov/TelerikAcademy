namespace StudentMethod
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Student ivan = new Student("Ivan", "Ivanov", new DateTime(2008, 04, 14), "Sofia");
            Console.WriteLine(ivan);
        }
    }
}
