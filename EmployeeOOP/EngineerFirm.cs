using System;



public class EngineerFirm : ICompany
{
    
    int[] income;

    public EngineerFirm(int n) //n is the number of engineers
    {
        int[] income = new int[n]; //income of each engineer
        for (int i = 0; i < n; i++)
        {
           income.SetValue(0, i);
        }
    }

    public void AssignSalaries(int[] salaries){
        for (int i = 0; i < salaries.Length; i++)
        {
            income[i] = salaries[i];
        }
        Console.WriteLine("Incomes of engineers credited");
    }

    public void MaxSalary(){

    }

    public void MinSalary(){

    }

    public void AverageSalary(){
        
    }   


    
}