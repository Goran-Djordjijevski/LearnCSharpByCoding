using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAndDirectoryInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Directory static class
            Directory.CreateDirectory(path: @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\DirectoryAndDirectoryInfoDemo\test");

            var files = Directory.GetFiles(path: @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\DirectoryAndDirectoryInfoDemo", searchPattern: ".", searchOption: SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(path: @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\DirectoryAndDirectoryInfoDemo", searchPattern: ".", searchOption: SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var isExists = Directory.Exists(path: @"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\DirectoryAndDirectoryInfoDemo\test");
            Console.WriteLine(isExists);

            // DirectoryInfo Instance class
            var directoryInfo = new DirectoryInfo(@"C:\Users\goran\Documents\GitHub\LearnCSharpByCoding\DirectoryAndDirectoryInfoDemo\test");

            Console.ReadLine();
        }
    }
}
