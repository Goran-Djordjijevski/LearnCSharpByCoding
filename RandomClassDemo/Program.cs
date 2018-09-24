using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var randomNumber = random.Next(minValue: 97, maxValue: 122);
                Console.Write((char)randomNumber );
            }

            Console.ReadLine();
        }
    }
}
