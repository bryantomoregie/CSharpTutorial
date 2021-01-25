using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class DBMigrator
    {
        private Logger _logger;

        public DBMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Migration completed");
        }
    }
}
