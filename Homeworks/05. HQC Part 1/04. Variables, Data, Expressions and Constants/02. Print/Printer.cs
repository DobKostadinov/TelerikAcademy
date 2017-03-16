namespace _02.Print
{
    using System;

    public static class Printer
    {
        public static void PrintStatistics(double[] statistics)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;

            double sum = 0;

            int statisticLenght = statistics.Length;

            for (int i = 0; i < statisticLenght; i++)
            {
                double currentValue = statistics[i];

                if (maxValue < currentValue)
                {
                    maxValue = currentValue;
                }

                if (minValue > currentValue)
                {
                    minValue = currentValue;
                }

                sum += currentValue;
            }

            PrintNumber(maxValue);
            PrintNumber(minValue);

            double averageValue = sum / statisticLenght;

            PrintNumber(averageValue);
        }

        public static void PrintNumber(double number)
        {
            Console.WriteLine(number);
        }
    }
}
