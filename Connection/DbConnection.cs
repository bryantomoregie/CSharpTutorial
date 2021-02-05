using System;

namespace CSharpTutorial
{
    public class DbConnection
    {

        public TimeSpan Timeout { get; set; }
       
        public virtual void Open()
        {
            Console.WriteLine("Generic database is open");
        }

        
        public virtual void Close()
        {
            Console.WriteLine("Generic database is closed");
        }


    }
}

/*
 It seems to me to only makes sense to either make Dbconnection an interface or the parent class of 
oracle and sql connection.
In either case, I don't see the need for a constructor, since we wil not be instantiating this class.
If theres no ctor in the base class, the ctor and null check must happen in the children class.
That makes the way i set up the Dbcommand class necessary
*/


  