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


            //var list = new List<string>()
            //{
            //    "yo", "act", "flop", "tac", "foo", "cat", "oy", "olfp"
            //};
            var list = new List<string>()
            {
                "yo", "act", "oy", "yo", "cat"
            };
            Console.WriteLine(AlgoExper.GroupAnagram.groupAnagrams(list));
            


        }

        

    }  
}
