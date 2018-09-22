using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwitchExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note: for all these exercises, ignore input validation unless otherwise directed.Assume the user enters a value in the format that the program expects.For example, if the program expects the user to enter a number, don't worry about validating if the input is a number or not. When testing your program, simply enter a number.

            //1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            //ExampleOne();

            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.
            //ExampleTwo();

            Console.ReadLine();
        }

        private static void ExampleTwo()
        {
            Console.Write("Enter two numbers: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int maximum = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.WriteLine($"The maximum of two numbers is: {maximum}");
        }

        private static void ExampleOne()
        {
            Console.Write("Enter a number between 1 to 10: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
