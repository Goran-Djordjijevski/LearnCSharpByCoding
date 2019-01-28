using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndInheritanceDemo
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized.");
        //}

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;

            Console.WriteLine($"Vehicle is being initialized. {registrationNumber}");
        }
    }
}
