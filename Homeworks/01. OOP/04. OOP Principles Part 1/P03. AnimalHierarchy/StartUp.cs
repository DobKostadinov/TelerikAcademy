using P03.Animal_hierarchy.Enums;
using P03.Animal_hierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Animal_hierarchy
{
    public class StartUp
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(6, "Miki", Gender.Male));
            animals.Add(new Dog(2, "Puf", Gender.Female));
            animals.Add(new Dog(20, "Zikki", Gender.Female));
            animals.Add(new Frog(3, "Tin", Gender.Other));
            animals.Add(new Frog(5, "Kwiki", Gender.Other));
            animals.Add(new Kitten(12, "Tom"));
            animals.Add(new Kitten(10, "Moks"));
            animals.Add(new Kitten(12, "Fiksi"));
            animals.Add(new Tomcat(10, "Mianko"));
            animals.Add(new Tomcat(10, "Bruno"));

            CalculateAverageAgeOfAllAnimalKinds(animals);
        }

        public static void CalculateAverageAgeOfAllAnimalKinds(List<Animal> animals)
        {
            var avgAgeOfKinds = animals
                .GroupBy(x => x.GetType().Name)
                .Select(x => new
            {
                Kind = x.Key,
                AverageAgeOfKind = x.Average(a => a.Age)
            })
            .ToList();

            foreach (var kind in avgAgeOfKinds)
            {
                Console.WriteLine($"The average age of {kind.Kind}s is {kind.AverageAgeOfKind:F2} years.");
            }
        }
    }
}
