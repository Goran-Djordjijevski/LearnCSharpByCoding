using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Goran Djordjijevski         ";

            Console.WriteLine($"Trim: {fullName.Trim()}");
            Console.WriteLine($"Trim: {fullName.ToUpper()}");
            Console.WriteLine($"Trim: {fullName.ToLower()}");

            Console.WriteLine();

            // Split string first way
            var index = fullName.IndexOf(' ');
            Console.WriteLine(index);
            var firstName = fullName.Substring(startIndex: 0, length: index);
            var lastName = fullName.Substring(startIndex: index + 1);
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");

            Console.WriteLine();

            // Split string second way and better
            var names = fullName.Split(' ');
            Console.WriteLine($"First name: {names[0]}");
            Console.WriteLine($"Last name: {names[1]}");

            Console.WriteLine();

            // Replace
            var replace = fullName.Replace(oldValue: "Goran", newValue: "Lazar");
            Console.WriteLine(replace);

            Console.WriteLine();

            // Working with null and empty string
            if (string.IsNullOrWhiteSpace(value: null))
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine();

            // Convert numbers to string and vice versa
            var str = "31";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            Console.WriteLine();

            float price = 29.95f;
            var priceString = price.ToString("C");
            Console.WriteLine(priceString);

            Console.ReadLine();
        }
    }
}
