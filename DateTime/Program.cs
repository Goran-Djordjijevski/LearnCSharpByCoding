﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(year: 2018, month: 8, day: 23);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now);
            Console.WriteLine(today);

            Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());

            Console.ReadLine();
        }
    }
}
