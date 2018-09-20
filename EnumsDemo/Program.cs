using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDemo
{
    // We must define enum at the namespace level because it is a new type
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // Result is 3

            int methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // Result is Express

            Console.WriteLine(method.ToString()); // Result is Express

            // Convert string to enum
            var methodName = "Express";
            var convertMethodName = (ShippingMethod)Enum.Parse(enumType: typeof(ShippingMethod), value: methodName);
            Console.WriteLine(convertMethodName);

            Console.ReadLine();
        }
    }
}
