using System;
using System.Diagnostics;
using CompareSimpleMaths.Contracts;

namespace CompareSimpleMaths.Models
{
    public static class SimpleMathOperationTestTime
    {
        public static void TestMathOperation(ILogger logger, Action methodToTest)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (long i = 0; i < 10000000; i++)
            {
                methodToTest();
            }
            
            sw.Stop();

            logger.Log(sw.Elapsed.ToString());
        }
    }
}
