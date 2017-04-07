using CompareSimpleMaths.Contracts;
using CompareSimpleMaths.Models;

namespace CompareSimpleMaths
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            var logger = new ConsoleLogger();

            TestInt(logger);
            TestLong(logger);
            TestFloat(logger);
            TestDouble(logger);
            TestDecimal(logger);
        }

        private static void TestInt(ILogger logger)
        {
            logger.Log("-INT-");
            logger.Log("Adding time: ");

            SimpleMathOperationTestTime.TestMathOperation(
                logger, () =>
            {
                int a = 5 + 10;
            });

            logger.Log("Substracting time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                int b = 50 - 10;
            });

            logger.Log("Multiplication time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                int c = 5 * 10;
            });

            logger.Log("Dividing time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                int d = 50 / 10;
            });
        }

        private static void TestLong(ILogger logger)
        {
            logger.Log("-LONG-");

            logger.Log("Adding time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                long e = 5 + 10;
            });

            logger.Log("Substracting time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                long f = 50 - 10;
            });

            logger.Log("Multiplication time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                long g = 5 * 10;
            });

            logger.Log("Dividing time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                long k = 50 / 10;
            });
        }

        private static void TestFloat(ILogger logger)
        {
            logger.Log("-FLOAT-");

            logger.Log("Adding time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                float a = 5f + 10f;
            });

            logger.Log("Substracting time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                float a = 50f - 10f;
            });

            logger.Log("Multiplication time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                float a = 5f * 10f;
            });

            logger.Log("Dividing time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                float a = 50f / 10f;
            });
        }

        private static void TestDouble(ILogger logger)
        {
            logger.Log("-DOUBLE-");

            logger.Log("Adding time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                double a = 5d + 10d;
            });

            logger.Log("Substracting time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                double a = 50d - 10d;
            });

            logger.Log("Multiplication time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                double a = 5d * 10d;
            });

            logger.Log("Dividing time: ");

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                double a = 50d / 10d;
            });
        }

        private static void TestDecimal(ILogger logger)
        {
            logger.Log("-DECIMAL-");

            logger.Log("Adding time: ");           

            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                decimal a = 5m + 10m;
            });

            logger.Log("Substracting time: ");
            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                decimal a = 50m - 10m;
            });

            logger.Log("Multiplication time: ");
            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                decimal a = 5m * 10m;
            });

            logger.Log("Dividing time: ");
            SimpleMathOperationTestTime.TestMathOperation(logger, () =>
            {
                decimal a = 50m / 10m;
            });
        }
    }
}
