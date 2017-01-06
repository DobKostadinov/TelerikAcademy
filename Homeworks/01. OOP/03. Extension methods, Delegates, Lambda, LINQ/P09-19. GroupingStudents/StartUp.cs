namespace P09_19
{
    using P03_P05.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Student> students = new List<Student>
            {
                new Student("Gicheto", "Ginkova", 26, "101006", "027322873713", "gincheto@abv.bg", new List<int> {5, 6, 2}, 2),
                new Student("Alberto", "Dimkov", 28, "201805", "0568137183", "alberto@gmail.com", new List<int> {2, 2}, 1),
                new Student("Penio", "Hubchev", 22, "138406", "0671928391", "Penito@abv.bg", new List<int> {6, 6, 5}, 2),
                new Student("Zuka", "Zubcheva", 26, "174706", "02897111111", "zubata@yahoo.com", new List<int> {3, 4}, 1),
            };

        static void Main()
        {
            TestingTask9();
            TestingTask10();
            TestingTask11();
            TestingTask12();
            TestingTask13();
            TestingTask14();
            TestingTask15();
            TestingTask1819();
        }

        private static void TestingTask9()
        {
            Console.WriteLine("Task 9");


            var studentsFromGroup2 = from student in students
                                     where student.GroupNumber == 2
                                     orderby student.FirstName
                                     select student;

            Console.WriteLine("All students from group 2:");

            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine($"Full name: {student.FirstName} {student.LastName} from Group {student.GroupNumber}");
            }
        }

        private static void TestingTask10()
        {
            Console.WriteLine("\nTask 10");

            var groupedStudendsByUsingExtension = students.GroupByGroupNumber(2);

            foreach (var student in groupedStudendsByUsingExtension)
            {
                Console.WriteLine($"Full name: {student.FirstName} {student.LastName} from Group {student.GroupNumber}");
            }
        }

        private static void TestingTask11()
        {
            Console.WriteLine("\nTask 11");

            var extractedStudsByEmail = students.StudentsByEmail("@abv.bg");

            foreach (var student in extractedStudsByEmail)
            {
                Console.WriteLine($"Full name: {student.FirstName} {student.LastName} Email: {student.Email}");
            }
        }

        private static void TestingTask12()
        {
            Console.WriteLine("\nTask 12");

            var allStudentsWithPhonesInSofia = students.Where(x => x.Telephone.StartsWith("02"));

            foreach (var student in allStudentsWithPhonesInSofia)
            {
                Console.WriteLine($"Full name: {student.FirstName} {student.LastName} Email: {student.Telephone}");
            }
        }

        private static void TestingTask13()
        {
            Console.WriteLine("\nTask 13");

            var newListWithAnonymos = students
                                        .Where(x => x.Marks.Contains(6))
                                        .Select(st => new
                                        {
                                            FullName = st.FirstName + " " + st.LastName,
                                            Marrks = st.Marks
                                        });

            foreach (var student in newListWithAnonymos)
            {
                Console.WriteLine($"{student.FullName} with marks {string.Join(", ", student.Marrks)}");
            }
        }

        private static void TestingTask14()
        {
            Console.WriteLine("\nTask 14");

            var studentsWithTwoMarksTwo = students
                                            .Where(x => (x.Marks.Count == 2))
                                            .ToList();

            foreach (var student in studentsWithTwoMarksTwo)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} with marks {string.Join(", ", student.Marks)}");
            }
        }

        private static void TestingTask15()
        {
            Console.WriteLine("\nTask 15");

            var studsFrom2006 = students
                                    .Where(x => x.FacNum.EndsWith("06"))
                                    .ToList();

            foreach (var student in studsFrom2006)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.FacNum}");
            }
        }

        private static void TestingTask1819()
        {
            Console.WriteLine("\nTask 18 - Task 19");

            var groupedStudsByGrouoNum = from stud in students
                                         group stud by stud.GroupNumber;

            foreach (var group in groupedStudsByGrouoNum)
            {
                Console.WriteLine($"Group {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }

                Console.WriteLine();
            }
        }
    }
}
