namespace PersonCreationMain
{
    using Enums;

    public static class PersonCreation
    {
        public static Person CreatePerson(int age)
        {
            Person person = new Person();

            person.Age = age;

            if (age%2 == 0)
            {
                person.Name = "Ivan";
                person.Gender = Gender.Male;
            }

            else
            {
                person.Name = "Minka";
                person.Gender = Gender.Female;
            }

            return person;
        }
    }
}
