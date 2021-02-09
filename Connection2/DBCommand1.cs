using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Connection3
{
    class DBCommand1
    {
        public string ConnectionString { get; set; }

        public string Instructions { get; set; }
        public DbConnection1 conn { get; set; }


        public DBCommand1(DbConnection1 dbConnection1, string instructions)
        {
            conn = dbConnection1 ?? throw new ArgumentNullException(nameof(dbConnection1), "Parameter cannot be null");
            Instructions = instructions ?? throw new ArgumentNullException(nameof(instructions), "Parameter cannot be null");
            ConnectionString = conn.ConnectionString;
        }

        public void Execute()
        {
            Console.WriteLine(conn.Open());
            Console.WriteLine(Instructions);
            Console.WriteLine(conn.Close());
        }


       
    }
}
