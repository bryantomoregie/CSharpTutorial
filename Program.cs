using CSharpTutorial.Connection3;
using System;

namespace CSharpTutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            SqlConnection1 sqlConnection1 = new SqlConnection1("connectionString");
            DBCommand1 dBCommand1 = new DBCommand1(sqlConnection1, "SELECT * FROM Table WHERE id = 1");
            Console.WriteLine(dBCommand1.ConnectionString);
            dBCommand1.Execute();
        }

      
    }
}
