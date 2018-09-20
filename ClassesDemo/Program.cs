using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";
            person.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(5, 15);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
