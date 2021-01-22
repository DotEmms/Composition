﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPracticeEx1
{
    class DbMigrator
    {
        private Logger _logger;
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            //Do migrator magic
            _logger.Log("Logging started");
        }
    }
}
