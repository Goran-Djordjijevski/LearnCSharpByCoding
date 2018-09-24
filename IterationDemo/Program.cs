using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-------------------");

            //// Foreach loop
            //string name = "John Smith";
            //foreach (var c in name)
            //{
            //    Console.WriteLine(c);
            //}

            //Console.WriteLine("-------------------");

            //int[] numbers = { 1, 2, 3, 4 };
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("-------------------");

            //// While loops
            //int i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;
            //}

            Console.WriteLine("-------------------");

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                Console.WriteLine($"@Echo: {input}");
            }

            Console.ReadLine();
        }
    }
}
