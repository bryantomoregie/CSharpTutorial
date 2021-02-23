using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Workflow
{
    class Workflow2 : IWorkflow
    {
        public void Instructions()
        {
            Console.WriteLine("Workflow 2 first instruction");
            Console.WriteLine("Workflow 2 second instruction");
            Console.WriteLine("Workflow 2 third instruction");
        }
    }
}
