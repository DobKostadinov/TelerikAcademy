using System;
using System.Text;

namespace P02.StudentsAndWorkers
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string secondName, int grade)
            : base(firstName, secondName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return this.grade; }
            set
            {
                CheckIfNumberIsNegative(value);
                this.grade = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.Append($"{base.ToString()} Grade: {this.Grade}");

            return stb.ToString();
        }

        private static void CheckIfNumberIsNegative(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"The grade cannot be negative");
            }
        }
    }
}
