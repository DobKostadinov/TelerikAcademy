namespace P06.IsDivisibl
{
    using System.Linq;

    public static class DivisibleChecker
    {
        public static int[] CheckIfDivisibleBy7And3(int[] numbers)
        {
            var allDivisibleNums = numbers.Where(num => (num % 7 == 0 && num % 3 == 0)).ToArray();

            return allDivisibleNums;
        }

        public static int[] CheckIfDivisibleBy7And3LINQ(int[] numbers)
        {
            var allDivisibleNums = from num in numbers
                                   where (num % 3 == 0) && (num % 7 == 0)
                                   select num;

            return allDivisibleNums.ToArray();
        }
    }
}
