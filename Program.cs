using CSharpTutorial.Algo;
using CSharpTutorial.Connection3;
using CSharpTutorial.Workflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountantFirm accountantFirm = new AccountantFirm(5);
            EngineerFirm engineerFirm = new EngineerFirm(5);
            
            int[] accountantSalaries = new int[]{6848, 9329, 9984, 5543, 7986};
            int[] engineerSalaries  = new int[]{9317, 7796, 3352, 7068, 9500};

            engineerFirm.AssignSalaries(engineerSalaries);
            accountantFirm.AssignSalaries(accountantSalaries);

            engineerFirm.AverageSalary();
            engineerFirm.MaxSalary();
            engineerFirm.MinSalary();

            accountantFirm.AverageSalary();
            accountantFirm.MaxSalary();
            accountantFirm.MinSalary();

        }

    }  
}



