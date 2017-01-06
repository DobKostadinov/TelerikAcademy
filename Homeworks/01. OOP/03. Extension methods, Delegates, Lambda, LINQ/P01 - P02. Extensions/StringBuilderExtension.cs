namespace P01___P02.Extensions
{
    using System;
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder stb, int startIndex, int lengthOfSubStb)
        {
            var stbLength = stb.Length;

            if (startIndex > stbLength ||
                lengthOfSubStb > stbLength ||
                startIndex + lengthOfSubStb > stbLength)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or length for subStringBuilder");
            }

            StringBuilder substrBuilder = new StringBuilder();

            for (int i = startIndex, j = 0; j < lengthOfSubStb; i++, j++)
            {
                substrBuilder.Append(stb[i]);
            }

            return substrBuilder;
        }
    }
}
