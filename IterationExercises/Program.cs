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

            //ExerciseThree();

            //4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //ExampleFour();

            Console.ReadLine();
        }

        private static void ExampleFour()
        {
            Console.WriteLine("Random number game");

            var random = new Random();
            var number = random.Next(minValue: 1, maxValue: 10);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Pick a number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (number == input)
                {
                    Console.WriteLine("You won!");
                    break;
                }

                Console.WriteLine("You lost!");
            }
        }

        private static void ExerciseThree()
        {
            Console.Write("Enter a number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var result = input;

            for (int i = 1; i < input; i++)
            {
                result *= i;
            }

            Console.WriteLine($"Factorial is {result}");
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
