using P03.Animal_hierarchy.Enums;
using System;

namespace P03.Animal_hierarchy.Models
{
    public class Kitten : Animal
    {
        public Kitten(int age, string name)
            : base(age, name, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitten says miay");
        }
    }
}
