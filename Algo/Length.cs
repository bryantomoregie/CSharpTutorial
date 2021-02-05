using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class Length
    {

        public static int lengthOfLastWord(string A)
        {
            int count = 0;

            foreach (var item in A)
            {
                if (item == ' ')
                {
                    count = 0;
                    continue;
                }
                 
                count++;

            }
            return count;
        }


    }
}
