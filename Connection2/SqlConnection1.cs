using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class SqlConnection1 : DbConnection1
    {
        public SqlConnection1(string connectionString) : base(connectionString)
        {
        }

        public override string Open()
        {
            return "SQL Database connection is open";
        }

        public override string Close()
        {
            return "SQL Database connection is closed";
        }
    }
}

