using P03.Animal_hierarchy.Contracts;
using P03.Animal_hierarchy.Enums;
using System;

namespace P03.Animal_hierarchy.Models
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Gender gender;

        public Animal(int age, string name, Gender gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be less than 0");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.name = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public virtual void ProduceSound()
        {
            Console.WriteLine("I Produced sound");
        }
    }
}
