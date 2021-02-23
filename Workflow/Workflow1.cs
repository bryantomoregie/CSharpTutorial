using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Workflow
{
    class Workflow1 : IWorkflow
    {

        public void Instructions()
        {
            Console.WriteLine("Workflow 1 first instruction");
            Console.WriteLine("Workflow 1 second instruction");
            Console.WriteLine("Workflow 1 third instruction");
        }
    }
}
