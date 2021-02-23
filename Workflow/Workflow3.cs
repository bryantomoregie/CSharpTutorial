using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Workflow
{
    class Workflow3 : IWorkflow
    {
        public void Instructions()
        {
            Console.WriteLine("Workflow 3 first instruction");
            Console.WriteLine("Workflow 3 second instruction");
            Console.WriteLine("Workflow 3 third instruction");
        }
    }
}
