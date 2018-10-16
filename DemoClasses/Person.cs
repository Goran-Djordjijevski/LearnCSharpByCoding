using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClasses
{
    public class Person
    {
        public string Name { get; set; }

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {this.Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
}
