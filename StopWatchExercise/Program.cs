using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopwatchDemo();

            for (int i = 0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine($"Duration: {stopwatch.GetInterval()}");
            }

            Console.ReadLine();
        }
    }
}
