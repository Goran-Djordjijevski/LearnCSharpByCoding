﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            int number;
            var convert = int.TryParse("abc", out number);
            if (convert == true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

            Console.ReadLine();
        }

        public static void UseParams()
        {
            var calculator = new Calculator();
            int result = calculator.Add(1, 2, 3, 4);
            Console.WriteLine(result);
        }

        public static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at {point.X} and {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X} and {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
