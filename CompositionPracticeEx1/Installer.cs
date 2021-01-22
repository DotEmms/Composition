using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPracticeEx1
{
    class Installer
    {
        private Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Installing()
        {
            //Do magic
            _logger.Log("Installing app");
            _logger.LogInformation("Installing app");
            _logger.LogError("Something went wrong!");

        }
    }
}
