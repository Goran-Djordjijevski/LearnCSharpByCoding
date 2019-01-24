using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionDemo
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
}
