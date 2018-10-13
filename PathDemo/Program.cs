using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\PathDemo.sln";

            string extension = Path.GetExtension(path);
            Console.WriteLine($"Extension: {extension}");

            Console.WriteLine($"File name: {Path.GetFileName(path)}");
            Console.WriteLine($"File name without extension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"Directory name: {Path.GetDirectoryName(path)}");

            Console.ReadLine();
        }
    }
}
