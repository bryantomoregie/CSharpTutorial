using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Workflow
{
    class WorkflowEngine
    {
        public static void Run(IWorkflow workflow)
        {
            workflow.Instructions();
        }
    }
}
