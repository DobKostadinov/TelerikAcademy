namespace P09_19
{
    using System.Collections.Generic;
    using System.Linq;
    using P03_P05.Linq;

    public static class Extensions
    {
        public static List<Student> GroupByGroupNumber(this IList<Student> collection, int groupNum)
        {
            return collection.Where(x => x.GroupNumber == groupNum).ToList();
        }
        
        public static IList<Student> StudentsByEmail(this IList<Student> students, string domain)
        {
            return students.Where(x => x.Email.EndsWith(domain)).ToList();
        }

    }
}
