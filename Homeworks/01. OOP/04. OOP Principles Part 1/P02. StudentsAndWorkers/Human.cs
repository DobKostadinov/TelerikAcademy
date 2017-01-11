using System.Text;

namespace P02.StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.Append($"{this.FirstName} {this.LastName}");

            return stb.ToString();
        }
    }
}
