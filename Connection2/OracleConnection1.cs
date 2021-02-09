using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class OracleConnection1 : DbConnection1
    {



        public OracleConnection1(string connectionString)
        {
            ConnectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString), "Parameter cannot be null");
        }


        public override string Open()
        {
            return "Oracle Database connection is open";
        }

        public override string Close()
        {
            return "Oracle Database connection is closed";
        }
    }
}
