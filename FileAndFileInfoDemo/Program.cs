using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(sourceFileName: @"c:\temp\myfile.jpg", destFileName: @"d:\temp\myfile.jpg", overwrite: true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            Console.ReadLine();
        }
    }
}
