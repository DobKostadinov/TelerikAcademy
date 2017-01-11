using System;
using System.Text;

namespace P02.StudentsAndWorkers
{
    public class Worker : Human
    {
        private const int MinWorkHours = 1;
        private const int MaxWorkHours = 24;
        private const int WorkingDays = 5;

        private double weekSalary;
        private double workHourPerDay;

        public Worker(string firstName, string secondName, double weekSalary, double workHourPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                CheckIfNumberIsNegative(value);
                this.weekSalary = value;
            }
        }

        public double WorkHourPerDay
        {
            get { return this.workHourPerDay; }
            set
            {
                CheckIfNumberIsInRange(value);

                this.workHourPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            var moneyPerHour = (this.weekSalary / (this.WorkHourPerDay * WorkingDays));

            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.Append(base.ToString());
            stb.Append($" Week salary: {this.WeekSalary}");
            stb.Append($" Week salary: {this.WorkHourPerDay}");
            stb.Append($" Money per hour: ${this.MoneyPerHour():F2}");

            return stb.ToString();
        }

        private static void CheckIfNumberIsNegative(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"The week salary cannot be less than 0");
            }
        }

        private static void CheckIfNumberIsInRange(double value)
        {
            if (value < MinWorkHours && value > MaxWorkHours)
            {
                throw new ArgumentOutOfRangeException($"Work hours should be between {MinWorkHours} and {MaxWorkHours}");
            }
        }
    }
}
