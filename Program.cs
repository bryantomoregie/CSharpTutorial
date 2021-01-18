using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Post algo = new Post("What is an Algo", "What is an algo");
            algo.UpVote();
            algo.UpVote();
            algo.UpVote();
            algo.DownVote();
            Console.WriteLine(algo.Vote);
            Console.WriteLine(algo.DateTime);
        }
    }
}
