using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            Console.WriteLine(a + b); // Result is 13
            Console.WriteLine((float)a / (float)b); // We need to cast the variables to get float point value

            int first = 1;
            int second = 2;
            int third = 3;

            Console.WriteLine(third > second && third > first); // Result is true
            Console.WriteLine(third > second || third > first); // Result is true

            Console.ReadLine();
        }
    }
}
