using System;

namespace P01.Shapes.Common
{
    public class Validator
    {
        public static void NonNegativeNumbersValidation(double value, string side)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{side} cannot be negative");
            }
        }
    }
}
