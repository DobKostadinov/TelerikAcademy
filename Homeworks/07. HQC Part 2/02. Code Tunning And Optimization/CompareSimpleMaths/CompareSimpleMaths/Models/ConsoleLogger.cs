using System;
using CompareSimpleMaths.Contracts;

namespace CompareSimpleMaths.Models
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
