using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";

            // Concatenating strings
            string fullNameConcat = firstName + " " + lastName;
            Console.WriteLine(fullNameConcat);

            // string.Format method
            string fullNameFormat = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullNameFormat);

            // String template - for me the most readable
            string fullNameTemplate = $"My name is {firstName} {lastName}";
            Console.WriteLine(fullNameTemplate);

            string[] names = { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            // Verbatim string
            var verbatimExample = @"Hi John
                                    Look into the following paths
                                    c:\folder1\folder2\folder3\folder4";
            Console.WriteLine(verbatimExample);

            Console.ReadLine();
        }
    }
}
