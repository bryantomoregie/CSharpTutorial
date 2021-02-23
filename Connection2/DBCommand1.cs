using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Connection3
{
    class DBCommand1
    {
        public string ConnectionString { get; set; }

        public string Instructions { get; set; }
        public DbConnection1 _conn { get; }


        public DBCommand1(DbConnection1 conn, string instructions)
        {
            this._conn = conn ?? throw new ArgumentNullException(nameof(conn), "Parameter cannot be null");
            Instructions = instructions ?? throw new ArgumentNullException(nameof(instructions), "Parameter cannot be null");
            ConnectionString = conn.ConnectionString;
        }

        public void Execute()
        {
            Console.WriteLine(_conn.Open());
            Console.WriteLine(Instructions);
            Console.WriteLine(_conn.Close());
        }


       
    }
}
