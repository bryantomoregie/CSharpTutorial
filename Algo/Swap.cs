using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpTutorial
{
    public class Swap
    {
        public static string SwapCharacters()
        {
            string s = "aiohn";
            int length = s.Length;
            string[] array = new string[length];
            int[] indices = { 3, 1, 4, 2, 0 };

            StringBuilder sb = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {


                int index = indices[i];
                string letter = s[i].ToString();

                array.SetValue(letter, index);
            }


            //
            //Console.ReadLine();

            return string.Join("", array);
        }
    }
}

/*
heap stack
reference vs value


 */ 