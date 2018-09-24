using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note: for all these exercises, ignore input validation unless otherwise directed.Assume the user enters a value in the format that the program expects.For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not. When testing your program, simply enter a number.

            //1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            //ExerciseOne();

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            //ExerciseTwo();

            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var result = 1;

            for (int i = 1; i < input; i++)
            {
                
            }

            Console.WriteLine($"Factorial is {result}");

             Console.ReadLine();
        }

        private static void ExerciseTwo()
        {
            Console.Write("Enter a number or OK if you wan't to exit from application: ");
            var sum = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine($"Sum is {sum}");
        }

        private static void ExerciseOne()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count += 1;
                }
            }

            Console.WriteLine($"We have {count} divisible numbers by 3 between 1 and 100");
        }
    }
}
