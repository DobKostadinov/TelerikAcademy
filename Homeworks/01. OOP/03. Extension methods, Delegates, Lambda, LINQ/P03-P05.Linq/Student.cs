namespace P03_P05.Linq
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facNum;
        private string telephone;
        private string email;
        private List<int> marks;
        private int groupNumber;


        public Student(string firstName,
            string lastName,
            int age, 
            string facNum, 
            string telephone, 
            string email,
            List<int> marks, 
            int groupNumber)
            : this(firstName, lastName, age)
        {
            this.FacNum = facNum;
            this.Telephone = telephone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                ValidateString(value);

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                ValidateString(value);

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= 0 || value > 120)
                {
                    throw new ArgumentException("Ages have to be in range 1 to 120!");
                }

                this.age = value;
            }
        }

        public string FacNum { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        private static void ValidateString(string value)
        {
            if (value == string.Empty)
            {
                throw new ArgumentException($"{value.GetType().Name} cannot be empty");
            }
        }
    }
}
