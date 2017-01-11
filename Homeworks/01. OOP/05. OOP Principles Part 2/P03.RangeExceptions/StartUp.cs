using System;

namespace P03.RangeExceptions
{
    public class StartUp
    {
        static void Main()
        {
            const int start = 0;
            const int end = 100;

            DateTime LowerDate = new DateTime(1980, 1, 1);
            DateTime UpperDate = new DateTime(2013, 12, 31);

            try
            {
                int wrongNumber = 150;

                if (wrongNumber < start || wrongNumber > end)
                {
                    throw new InvalidRangeException<int>("Wrong", start, end);
                }

                DateTime wrongDate = new DateTime(2015, 10, 15);

                if (wrongDate < LowerDate || wrongDate > UpperDate)
                {
                    throw new InvalidRangeException<DateTime>("Date out of range!", LowerDate, UpperDate);
                }
            }

            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine($"Wrong number entered. Number must be in range {ex.LowerLimit} - {ex.UpperLimit}");
            }

            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine($"Wrong date entered. Date must be in range {ex.LowerLimit:dd/MM/yyyy} - {ex.UpperLimit:dd/MM/yyyy}");
            }
        }
    }
}
