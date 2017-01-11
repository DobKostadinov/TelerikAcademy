namespace P01.SchoolClasses.Models
{
    using Contracts;

    public abstract class Person : INamable, ICommentable
    {
        private string name;
        private string comment;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}
