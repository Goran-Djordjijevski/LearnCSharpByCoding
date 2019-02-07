using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var dictionary = new GenericDictionary<int, string>();
            dictionary.Add(1, "Goran");

            Console.ReadLine();
        }
    }
}
