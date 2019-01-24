using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigration(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();

            Console.ReadLine();
        }
    }
}
