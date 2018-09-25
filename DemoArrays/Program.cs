using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine(numbers.Length);

            Console.WriteLine();

            // IndexOf()
            var index = Array.IndexOf(array: numbers, value: 9);
            Console.WriteLine($"Index of 9: {index}");

            Console.WriteLine();

            // Clear()
            Array.Clear(array: numbers, index: 0, length: 2);
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            // Copy()
            int[] another = new int[3];
            Array.Copy(sourceArray: numbers, destinationArray: another, length: 3);
            foreach (var item in another)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            // Sort()
            Array.Sort(array: numbers);
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            // Reverse()
            Array.Reverse(array: numbers);
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
