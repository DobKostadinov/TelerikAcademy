using System;

namespace School.Utilities
{
    public class DataGenerator
    {
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static Random random = new Random();

        public static string GenerateRandomString()
        {
            var stringChars = new char[8];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = alphabet[random.Next(alphabet.Length)];
            }

            var finalString = new string(stringChars);

            return finalString;
        }

        public static int GenerateNumber(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
