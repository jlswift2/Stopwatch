using System;
using System.Threading;


namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();
            int milliseconds = 10000;
            Thread.Sleep(milliseconds);
            watch.Stop();

            watch.Start();
            Thread.Sleep(milliseconds);
            watch.Stop();

            var duration = watch.Duration;
            Console.WriteLine($"The duration was {duration.Minutes} minutes and {duration.Seconds} seconds.");

        }
    }
}
