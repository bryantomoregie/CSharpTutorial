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
            Console.WriteLine(CaesarCypherEncryptor("xyz", 2)); //zab
        }

        static string CaesarCypherEncryptor(string str, int key) {
		string alpha = "abcdefghijklmnopqrstuvwxyz";
		Dictionary<char, int> alphaDic = new Dictionary<char, int>();
		StringBuilder sb = new StringBuilder();
		
		for(int i = 0; i < alpha.Length; i++ ){
			alphaDic.Add(alpha[i], i);
        }

		
		for(int i = 0; i < str.Length; i++ ){
            System.Console.WriteLine(str[i]);
			int indx = alphaDic[str[i]];
            System.Console.WriteLine(indx);
			var newindx = (indx + key); 
			while(newindx > 25){
				newindx = newindx - 26;
			}
			sb.Append(alpha[newindx]);
		}
		return sb.ToString();
	}

    }  
}

//dotnet run 


