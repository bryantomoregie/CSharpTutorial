using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class DBMigrator
    {
        private ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration completed");
        }
    }
}
