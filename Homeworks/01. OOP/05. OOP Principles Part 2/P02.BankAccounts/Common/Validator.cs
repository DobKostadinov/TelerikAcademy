using System;

namespace P02.BankAccounts.Common
{
    public class Validator
    {
        public static void CheckForNegativeValues(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException($"{value.GetType().Name} cannot be negative!");
            }
        }
        public static void EmptyValidation(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NullReferenceException($"{value.GetType().Name} cannot be null or empty!");
            }
        }
    }
}
