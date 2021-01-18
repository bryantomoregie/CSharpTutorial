using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpTutorial
{
    class Practice
    {
        public static string Solution(string str)
        {
            string newString = String.Empty;
            int length = str.Length - 1;

            for (int i = length; i >= 0; i--)
            {
                newString += str[i];
            }

            return newString;
        }

        public static string PrinterError(String s)
        {
            var denominator = s.Length;
            var numerator = denominator;
            string regexpattern = "[a-m]";
            foreach (var letter in s)
            {
                if (new Regex(regexpattern).IsMatch(letter.ToString()))
                {
                    numerator--;
                }
            }
            return $"{numerator}/{denominator}";
        }

        public class Kata
        {
            public static string OddOrEven(int[] array)
            {
                int total = 0;
                foreach (var num in array)
                {
                    total += num;
                }

                if (total % 2 == 0)
                {
                    return "even";
                }
                else
                {
                    return "odd";
                }
            }
        }


    }

   
        
   
}
