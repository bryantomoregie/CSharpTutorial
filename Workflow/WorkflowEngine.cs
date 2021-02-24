using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Workflow
{
    class WorkflowEngine
    {
        readonly IWorkflow _workflow;
        public WorkflowEngine(IWorkflow workflow)
        {
            _workflow = workflow;
        }
        public void Run()
        {
            _workflow.Instructions();
        }
    }
}
