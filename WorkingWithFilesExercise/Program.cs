using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFilesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.
            //ExampleOne();

            //2 - Write a program that reads a text file and displays the longest word in the file. 
            ExampleTwo();

            Console.ReadLine();
        }

        private static void ExampleTwo()
        {
            string path = @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\WorkingWithFilesExercise\test\test.txt";

            var read = File.ReadAllText(path);
            var splitString = read.Split(' ');
            var longestWord = 0;
            var word = string.Empty;

            foreach (var str in splitString)
            {
                if (str.Length > longestWord)
                {
                    word = str;
                    longestWord = str.Length;
                }
            }

            Console.WriteLine(word);
        }

        private static void ExampleOne()
        {
            var path = @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\WorkingWithFilesExercise\test\test.txt";

            var read = File.ReadAllText(path).Length;
            Console.WriteLine($"The length of the text is {read}");
        }
    }
}
