namespace P01___P02.Extensions
{
    using System;
    using System.Text;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            TestingStringBuilderExtention();
            TestExtendedIEnumerable();
        }

        private static void TestingStringBuilderExtention()
        {
            Console.WriteLine("Task 1");

            Console.Write("Enter text by your choice: ");
            var inputText = Console.ReadLine();

            Console.Write("Enter value for start index: ");
            var startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter value for desired length of the subStringBuilder: ");
            var lengthOfSubStrBuilder = int.Parse(Console.ReadLine());


            StringBuilder inputStringBuilder = new StringBuilder(inputText);
            var processedStB = inputStringBuilder.Substring(startIndex, lengthOfSubStrBuilder);

            Console.WriteLine($"Initial StringBuilder: {inputStringBuilder.ToString()}");
            Console.WriteLine($"After substring operation: {processedStB}\n");
        }

        public static void TestExtendedIEnumerable()
        {
            Console.WriteLine("Task 2");

            Console.WriteLine("On a single line write the numbers, separated by space, on which the new extension methods will be applied:");
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine($"Our array on which the new methods will be tested: {string.Join(", ", numbers)}");

            //Testing the new Sum method;
            var sum = numbers.NewImplSum();
            Console.WriteLine("Sum = {0};", sum);

            //Testing the new Product method;
            var product = numbers.NewImplProduct();
            Console.WriteLine("Product = {0};", product);

            //Testing the new Min method;
            var min = numbers.NewImplMin();
            Console.WriteLine("Min = {0};", min);

            //Testing the new Max method;
            var max = numbers.NewImplMax();
            Console.WriteLine("Max = {0};", max);

            //Testing the new Average method;
            var avg = numbers.NewImplAverage();
            Console.WriteLine("Average = {0:f2};", avg);
        }
    }
}
