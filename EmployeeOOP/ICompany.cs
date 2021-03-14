using System;


public interface ICompany
{
    void AssignSalaries(int[] salaries );

    void AverageSalary();

    void MaxSalary();

    void MinSalary();
}



    //  AccountantFirm accountantFirm = new AccountantFirm(5);
    //         EngineerFirm engineerFirm = new EngineerFirm(5);
            
    //         int[] accountantSalaries = new int[]{6848, 9329, 9984, 5543, 7986};
    //         int[] engineerSalaries  = new int[]{9317, 7796, 3352, 7068, 9500};

    //         engineerFirm.AssignSalaries(engineerSalaries);
    //         accountantFirm.AssignSalaries(accountantSalaries);

    //         engineerFirm.AverageSalary();
    //         engineerFirm.MaxSalary();
    //         engineerFirm.MinSalary();

    //         accountantFirm.AverageSalary();
    //         accountantFirm.MaxSalary();
    //         accountantFirm.MinSalary();