namespace P17.LongStr
{
    using System;

    public class LongestString
    {
        static void Main()
        {
            Console.Write("How many string do you want to enter: ");
            var numberOfInputStrings = int.Parse(Console.ReadLine());

            string[] arrStrings = new string[numberOfInputStrings];

            Console.WriteLine("Enter the desired strings:");

            for (int i = 0; i < numberOfInputStrings; i++)
            {
                arrStrings[i] = Console.ReadLine();
            }

            string longestStr = arrStrings.FindLongestStringExt();

            Console.WriteLine($"The longest string is: {longestStr}");
        }
    }
}
