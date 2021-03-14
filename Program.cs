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
            List<Transaction> list = new List<Transaction>();
            
            list.Add(new Transaction(500, true, "system"));
            list.Add(new Transaction(15, false, "ach"));
            list.Add(new Transaction(100, false, "card"));
            list.Add(new Transaction(50, false, "card"));
            list.Add(new Transaction(75, true, "ach"));

            List<string> categoriesRequested  = new List<string>();
            categoriesRequested.Add("ach");
            categoriesRequested.Add("card");
            //categoriesRequested.Add("system");



            Transform(list, categoriesRequested);
            
        }

        //TransactionLIst -> Non-Public Members -> Results View -> 

        public static int[] Transform(List<Transaction> transactions, List<string> categoriesRequested){
            
            return (from p in GetProducts()
            where prodIDs.Contains(p.ProductID)
            select p).ToArray<Product>();
            // IEnumerable<int> transactionList;
            // foreach (var category in categoriesRequested)
            // {
            //     transactionList =
            //     from transaction in transactions
            //     where transaction.Category == category
            //     select transaction.Amount;
            // }

            // int[] arr = transactionList.ToArray<int>();
            // return arr;
        }

        /*
        this function returns an int array of the effective change (so plus minus) of the transactions of only the transaction types I specify in the string 
        for{
        if Transaction.Category == categpry
        }
        */
    }  
}



