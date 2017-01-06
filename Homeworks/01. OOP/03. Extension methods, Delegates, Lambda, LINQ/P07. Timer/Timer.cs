namespace P07.Timer
{
    using System;
    using System.Diagnostics;

    public class Timer
    {
        private readonly int seconds;
        public delegate void Print();

        public Timer(int seconds)
        {
            this.seconds = seconds;

        }

        public void InvokeDelegate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var myDelegate = new Print(PrintTime);

            while (true)
            {
                if (stopwatch.Elapsed.Seconds != this.seconds)
                {
                    continue;
                }

                myDelegate.Invoke();
                stopwatch.Restart();
            }
        }

        private static void PrintTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
