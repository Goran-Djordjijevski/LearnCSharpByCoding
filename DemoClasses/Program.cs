using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Goran";
            person.Introduce("Pixi");

            Console.ReadLine();
        }
    }
}
