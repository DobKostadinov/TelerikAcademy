using P03.Animal_hierarchy.Enums;
using System;

namespace P03.Animal_hierarchy.Models
{
    public abstract class Cat : Animal
    {
        public Cat(int age, string name, Gender gender)
            : base(age, name, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Miay");
        }
    }
}
