namespace P03_P05.Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Student> listOfStuds = new List<Student>();

        static void Main()
        {
            TestingTaskThree();
            TestingTaskFour();
            TestingTaskFive();
        }

        private static void TestingTaskThree()
        {
            Console.WriteLine("Task 3");

            Student pecata = new Student("Pesho", "Peshov", 20);
            Student ivanka = new Student("Ivanka", "Margaritova", 28);
            Student jikata = new Student("Jivko", "Mishkarov", 17);
            Student jontan = new Student("Joni", "Boni", 24);
            Student kircata = new Student("Kiro", "Mirov", 19);
            Student milka = new Student("Milka", "Qnakieva", 26);
            Student viksyn = new Student("Vikirito", "Abrazov", 27);      

            listOfStuds.Add(pecata);
            listOfStuds.Add(ivanka);
            listOfStuds.Add(jikata);
            listOfStuds.Add(jontan);
            listOfStuds.Add(kircata);
            listOfStuds.Add(milka);
            listOfStuds.Add(viksyn);

            var listOfStudentsWhereLastNameIsBeforeTheirFirst = listOfStuds
                                                .Where(x => (x.FirstName.CompareTo(x.LastName)) == -1)
                                                .ToList();

            Console.WriteLine("All students whose first name is before its last name alphabetically.");

            foreach (var student in listOfStudentsWhereLastNameIsBeforeTheirFirst)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

        private static void TestingTaskFour()
        {
            Console.WriteLine("\nTask 4");

            var studentsBetween18And24 = listOfStuds
                                       .Where(stud => (stud.Age >= 18 && stud.Age <= 24))
                                       .ToList();

            Console.WriteLine("All students between 18 and 24");

            foreach (var student in studentsBetween18And24)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Age}");
            }
        }

        private static void TestingTaskFive()
        {
            Console.WriteLine("\nTask 5");

            var studsOrderedByFiNameSecName = listOfStuds
                                                .OrderByDescending(x => x.FirstName)
                                                .ThenByDescending(f => f.LastName)
                                                .ToList();

            Console.WriteLine("All students in descending order by first and last name:");

            foreach (var student in studsOrderedByFiNameSecName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Age}");
            }
        }
    }
}
