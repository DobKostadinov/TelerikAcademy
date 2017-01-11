using P03.Animal_hierarchy.Enums;
using System;

namespace P03.Animal_hierarchy.Models
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I am a Tomcat and i say Miaooo");
        }
    }
}
