using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            // If no one likes your post, it doesn't display anything.
            // If only one person likes your post, it displays: [Friend's Name] likes your post.
            // If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            // If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

            //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

            //ExerciseOne();

            //2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.

            //ExerciseTwo();

            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //ExerciseThree();

            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.

            //ExerciseFour();

            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list. 

            ExerciseFive();

            Console.ReadLine();
        }

        public static void ExerciseFive()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        private static void ExerciseFour()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type QUIT to exit from app: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                var number = Convert.ToInt32(input);
                numbers.Add(number);
            }

            var distinctValue = numbers.Distinct();
            foreach (var number in distinctValue)
            {
                Console.Write(number);
            }
        }

        private static void ExerciseThree()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.Write(number);
        }

        private static void ExerciseTwo()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        private static void ExerciseOne()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter different names: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                names.Add(input);
            }

            if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count} others like your post.");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} likes your post");
            }
            else
            {
                Console.WriteLine($"Nobody likes currently your post.");
            }
        }
    }
}
