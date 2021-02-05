using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class SqlConnection : DbConnection
    {

        public string ConnectionString { get; set; }
        public SqlConnection(string connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString), "Parameter cannot be null");
        }

        public override void Open()
        {
            Console.WriteLine("SQL Database connection is open");
        }

        public override void Close()
        {
            Console.WriteLine("SQL Database connection is closed");
        }
    }
}
