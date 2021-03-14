using System;
using System.Linq;


public class EngineerFirm : ICompany
{
    
    int[] income;

    public EngineerFirm(int n) //n is the number of engineers
    {
        income = new int[n]; //income of each engineer
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

    public int Sum(params int[] income){
        int result = 0;

        for(int i = 0; i < income.Length; i++)
        {
        result += income[i];
        }

        return result;
    }

    public void MaxSalary(){
        int max = income.Max();
        System.Console.WriteLine($"Maximum salary among engineers is {max}.");
    }

    public void MinSalary(){
        int min = income.Min();
        System.Console.WriteLine($"Minimum salary among engineers is {min}.");
    }

    public void AverageSalary(){
        int sum = Sum(income);
        int average = sum/income.Length;
        System.Console.WriteLine($"Average salary of engineers is {average}.");
    }   




    
}