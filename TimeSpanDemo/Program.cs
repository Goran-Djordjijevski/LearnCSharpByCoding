using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating
            var timeSpan = new TimeSpan(hours: 1, minutes: 2, seconds: 3);

            // Second way to declare TimeSpan
            var fromHours = TimeSpan.FromHours(value: 14);
            Console.WriteLine(fromHours);

            // If we subtract two DateTime we get TimeSpan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(15);
            var duration = end - start;
            Console.WriteLine($"Duration: {duration}");

            // Properties
            Console.WriteLine($"Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}");

            // Add
            Console.WriteLine($"Add example: {timeSpan.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"Subtract example: {timeSpan.Add(TimeSpan.FromMinutes(2))}");

            // ToString()
            Console.WriteLine($"ToString: {timeSpan.ToString()}");

            Console.ReadLine();
        }
    }
}
