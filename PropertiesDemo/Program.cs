using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1987, 8, 23));
            Console.WriteLine(person.Age);

            Console.ReadLine();
        }
    }
}
