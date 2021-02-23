using CSharpTutorial.Connection3;
using CSharpTutorial.Workflow;
using System;
using System.Collections.Generic;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow2 workflow2 = new Workflow2();
            WorkflowEngine.Run(workflow2);

        }

    }
}


