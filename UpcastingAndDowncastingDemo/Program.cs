using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDowncastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // UPCASTING
            //var text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;
            //Console.WriteLine(text.Width); // Result is 100

            // DOWNCASTING
            Shape shape = new Text();
            Text text = (Text)shape;

            Console.ReadLine();
        }
    }
}
