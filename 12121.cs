using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial
{
    public class _12121
    {
        public static int MaximumWealth(int[][] accounts)
        {
            

            int max = 0;

            foreach (var element in accounts)
            {
                if (max < element.Sum()){
                    max = element.Sum();
                }
            }

            return max;
        }
    }
}

/*
I need to loop thru this jagged array
get the sum of the array 
and return that number
 */