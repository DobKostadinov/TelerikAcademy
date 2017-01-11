using P03.Animal_hierarchy.Enums;
using System;

namespace P03.Animal_hierarchy.Models
{
    public class Frog : Animal
    {
        public Frog(int age, string name, Gender gender)
            : base(age, name, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kwa-kwa");
        }
    }
}
