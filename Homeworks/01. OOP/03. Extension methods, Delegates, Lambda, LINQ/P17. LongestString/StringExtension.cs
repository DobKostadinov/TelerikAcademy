namespace P17.LongStr
{
    using System.Collections;

    public static class StringExtension
    {
        public static string FindLongestStringExt(this IList arr)
        {
            string longest = arr[0].ToString();

            for (int i = 1; i < arr.Count - 1; i++)
            {
                if (longest.Length < arr[i].ToString().Length)
                {
                    longest = arr[i].ToString();
                }
            }

            return longest;
        }
    }
}
