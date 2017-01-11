using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.StudentsAndWorkers
{
    public class StartUp
    {
        static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Jorko", "Dimitrov", 5));
            students.Add(new Student("Metodi", "Jechev", 2));
            students.Add(new Student("Toni", "Binkov", 3));
            students.Add(new Student("Haralampi", "Prokopiev", 4));
            students.Add(new Student("Mitio", "TheEyes", 5));
            students.Add(new Student("Qvor", "Georgiev", 6));
            students.Add(new Student("Maria", "Pincheva", 2));
            students.Add(new Student("Stanislava", "Metodieva", 3));
            students.Add(new Student("Elena", "Atanasaova", 5));
            students.Add(new Student("Huben", "Svilenov", 6));

            var studsByGrades = students.OrderBy(x => x.Grade);

            Console.WriteLine(("Students ordered by grades in ascending order:"));

            foreach (var stud in studsByGrades)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine();

            var workers = new List<Worker>();

            workers.Add(new Worker("Blagoi", "Dimitriev", 1246, 8));
            workers.Add(new Worker("Haralampi", "Petrov", 600, 6));
            workers.Add(new Worker("Tihomir", "Tapalev", 876, 8));
            workers.Add(new Worker("Yordan", "Filipiev", 1246, 5));
            workers.Add(new Worker("Konstantin", "Pentriev", 2000, 11));
            workers.Add(new Worker("Florian", "Ignatov", 1246, 8));
            workers.Add(new Worker("Ana", "Mitrova", 241, 4));
            workers.Add(new Worker("Vesela", "Elenova", 899, 10));
            workers.Add(new Worker("Traqn", "Firkov", 999, 8));
            workers.Add(new Worker("Jana", "Boqnova", 741, 6));

            var workersByMoneyPerHour = workers.OrderByDescending(x => x.MoneyPerHour());

            Console.WriteLine(("Workers ordered by money per hour in descending order:"));

            foreach (var worker in workersByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }

            var allHumans = new List<Human>();
            allHumans.AddRange(students);
            allHumans.AddRange(workers);

            var allHumansSortedByFirstAndLastName = allHumans.Select(x => new
            {
                FirstName = x.FirstName,
                LastName = x.LastName
            })
            .OrderBy(a => a.FirstName)
            .ThenBy(a => a.LastName)
            .ToList();

            Console.WriteLine();
            Console.WriteLine("All students and workes sorder by first and last name: ");
            foreach (var human in allHumansSortedByFirstAndLastName)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }
        }
    }
}
