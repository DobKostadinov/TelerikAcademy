namespace P06.IsDivisibl
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Console.Write("Enter sequence of integer numbers separated by spaces: ");

            var inputNumbersAsArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var divisibleNumbers = DivisibleChecker.CheckIfDivisibleBy7And3(inputNumbersAsArray);

            var divisibleNumbersLinq = DivisibleChecker.CheckIfDivisibleBy7And3LINQ(inputNumbersAsArray);

            Console.WriteLine($"All divisible by 3 and 7: {(divisibleNumbers.Length != 0 ? (string.Join(", ", divisibleNumbers)) : "None")}");
            Console.WriteLine($"All divisible by 3 and 7 by using LINQ: {(divisibleNumbersLinq.Length != 0 ? (string.Join(", ", divisibleNumbersLinq)) : "None")}");
        }
    }
}
