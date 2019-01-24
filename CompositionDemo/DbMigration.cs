using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionDemo
{
    public class DbMigration
    {
        private readonly Logger _logger;

        public DbMigration(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migration some stuff...");
        }
    }
}
