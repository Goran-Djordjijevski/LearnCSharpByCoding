using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Explicit cast
            int second = 1000;
            byte bSecond = (byte)second;
            Console.WriteLine(bSecond);

            // Non-compatible types
            string number = "1234";
            int convertNumber = Convert.ToInt32(number);
            Console.WriteLine(convertNumber);

            string boolean = "true";
            bool isResult = Convert.ToBoolean(boolean);
            Console.WriteLine(isResult);

            Console.ReadLine();
        }
    }
}
