using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]); // Result is 1
            Console.WriteLine(numbers[1]); // Result is 0
            Console.WriteLine(numbers[2]); // Result is 0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); // Result is true
            Console.WriteLine(flags[1]); // Result is false
            Console.WriteLine(flags[2]); // Result is false

            Console.ReadLine();
        }
    }
}
