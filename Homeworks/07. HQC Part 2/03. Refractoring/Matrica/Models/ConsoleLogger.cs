using GameFifteen.Contracts;
using System;

namespace GameFifteen.Models
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
