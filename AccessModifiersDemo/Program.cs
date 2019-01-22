using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(year: 1987, month: 8, day: 23));
            Console.WriteLine(person.GetBirthdate());

            Console.ReadLine();
        }
    }
}
