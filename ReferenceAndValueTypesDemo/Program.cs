using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypesDemo
{
    public class Person
    {
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            b++;

            Console.WriteLine(a); // Result of a is 10
            Console.WriteLine(b); // Result of b is 11

            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;

            array2[0] = 25;
            foreach (var arr in array1)
            {
                Console.WriteLine(arr);
            }

            int number = 1;
            Increment(number);
            Console.WriteLine(number); // Because the number is a value type we send a copy of the number and the result is 1

            var person = new Person()
            {
                Age = 20
            };

            MakeOld(person);
            Console.WriteLine(person.Age); // Because the person is a reference type we point to the same location on the memory and age is 30

            Console.ReadLine();
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
