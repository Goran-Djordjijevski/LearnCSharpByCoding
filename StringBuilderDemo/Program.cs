using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            var append = builder.Append('-', 10);
            append.AppendLine();
            append.Append("Header");
            append.AppendLine();
            append.Append('-', 10);

            builder.Replace('-', '+');
            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(append);

            Console.ReadLine();
        }
    }
}
