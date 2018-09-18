using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2; // You must initialize variable before use.
            Console.WriteLine(number); // Cannot read the value of a variable unless you have set it before.

            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Goran";
            bool isWorking = true;

            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine($"{byte.MinValue} --- {byte.MaxValue}");
            Console.WriteLine($"{short.MinValue} --- {short.MaxValue}");
            Console.WriteLine($"{int.MinValue} --- {int.MaxValue}");
            Console.WriteLine($"{long.MinValue} --- {long.MaxValue}");
            Console.WriteLine($"{float.MinValue} --- {float.MaxValue}");
            Console.WriteLine($"{double.MinValue} --- {double.MaxValue}");
            Console.WriteLine($"{decimal.MinValue} --- {decimal.MaxValue}");

            // Declare constants
            const float Pi = 3.14f;
            // Pi = 1;  We can't chage the value 
            Console.WriteLine(Pi);

            Console.ReadLine();
        }
    }
}
