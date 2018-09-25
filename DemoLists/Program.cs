using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4 };
            numbers.Add(5);
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            numbers.AddRange(collection: new List<int> { 6, 7, 8 });
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            Console.WriteLine($"Index of 4: {numbers.IndexOf(item: 4)}");

            Console.WriteLine($"Count: {numbers.Count}");

            var remove = numbers.Remove(5);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}
