using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class OracleConnection : DbConnection
    {

        public string ConnectionString { get; set; }
        public OracleConnection(string connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString), "Parameter cannot be null");

        }

        public override void Open()
        {
            Console.WriteLine("Oracle Database connection is open");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Database connection is closed");
        }
    }
}
