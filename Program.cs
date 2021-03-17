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
            string str = "AAAAAAAAAAAAABBCCCCDD";
           System.Console.WriteLine(RunLengthEncoding(str));
            

            // List<Transaction> list = new List<Transaction>();
            
            // list.Add(new Transaction(500, true, "system"));
            // list.Add(new Transaction(15, false, "ach"));
            // list.Add(new Transaction(100, false, "card"));
            // list.Add(new Transaction(50, false, "card"));
            // list.Add(new Transaction(75, true, "ach"));

            // List<string> categoriesRequested  = new List<string>();
            // categoriesRequested.Add("ach");
            // categoriesRequested.Add("card");
            // //categoriesRequested.Add("system");



            // Transform(list, categoriesRequested);
            
        }

        //TransactionLIst -> Non-Public Members -> Results View -> 

        // public static int[] Transform(List<Transaction> transactions, List<string> categoriesRequested){
        //     //https://www.google.com/search?q=linq+query+to+select+matching+myltiple+values&oq=linq+query+to+select+matching+myltiple+values&aqs=chrome..69i57j33i10i22i29i30.17171j0j7&sourceid=chrome&ie=UTF-8
        //     return (from p in GetProducts()
        //     where prodIDs.Contains(p.ProductID)
        //     select p).ToArray<Product>();
        //     // IEnumerable<int> transactionList;
        //     // foreach (var category in categoriesRequested)
        //     // {
        //     //     transactionList =
        //     //     from transaction in transactions
        //     //     where transaction.Category == category
        //     //     select transaction.Amount;
        //     // }

        //     // int[] arr = transactionList.ToArray<int>();
        //     // return arr;
        // }

        static string RunLengthEncoding(string str) {
            StringBuilder sb = new StringBuilder();
            int count = 1;
            

            for (int i = 1; i < str.Count(); i++)
            {
                char currentChar = str[i];
                char previousChar = str[i - 1];

                if(currentChar != previousChar || count == 9){
                    sb.Append(count);
                    sb.Append(previousChar);
                    count = 1;
                }else{
                    count++;
                }
            }

            sb.Append(count);
            sb.Append(str[str.Length - 1]);

            return sb.ToString();
	    }

  
    }  
}


//"AAAAAAAAAAAAABBCCCCDD"
//"9A4A2B4C2D"
