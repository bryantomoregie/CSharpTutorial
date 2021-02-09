using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public abstract class DbConnection1
    {
        public string ConnectionString { get; set; }

        public TimeSpan Timeout { get; set; }

        public DbConnection1()
        {
            /*Example ask for this class to be instantiated with a connectionString,
            but the two derived classes have two different connectionStrings.
            Makes more sense to me to initialize the derived classes with their unique 
            strings, and have the logic in the ctor of those classes.
             */
        }

        public abstract string Open();


        public abstract string Close();
        
    }
}
