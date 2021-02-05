using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class DbCommand
    {
        public string CommandString { get; set; }
        public SqlConnection SqlConnection { get; set; }
        public OracleConnection OracleConnection { get; set; }
       
        public DbCommand(string commandString, OracleConnection oracleConnection)
        {
            CommandString = commandString;
            OracleConnection = oracleConnection;
        }

        public DbCommand(string commandString, SqlConnection sqlConnection)
        {
            CommandString = commandString;
            SqlConnection = sqlConnection;
        }



        public void Execute()
        {
            if (SqlConnection != null)
            {
                SqlConnection.Open();
                Console.WriteLine(CommandString);
                SqlConnection.Close();
                Console.ReadLine();
            }
            else
            {
                OracleConnection.Open();
                Console.WriteLine(CommandString);
                OracleConnection.Close();
                Console.ReadLine();
            }

            Console.WriteLine();
        }
    }
}
