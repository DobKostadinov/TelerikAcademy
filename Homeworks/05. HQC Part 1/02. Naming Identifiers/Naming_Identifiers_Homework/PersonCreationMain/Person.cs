namespace PersonCreationMain
{
    using System.Text;
    using Enums;

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }


        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Name: {0}", this.Name));
            result.AppendLine(string.Format("Age: {0}", this.Age));
            result.AppendLine(string.Format("Gender: {0}", this.Gender));

            return result.ToString();
        }
    }
}
