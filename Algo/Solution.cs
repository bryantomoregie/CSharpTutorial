using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial.Algo
{
    class Solution
    {
        public static bool IsValid(string s)
        {
            int length = s.Length;
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(')');
                }
                else if (s[i] == '{')
                {
                    stack.Push('}');
                }
                else if (s[i] == '[')
                {
                    stack.Push(']');
                }
                else
                {
                    if (stack.Peek() == s[i])
                    {
                        stack.Pop();
                        continue;
                    }
                    else if(stack.Count == 0 || stack.Peek() != s[i])
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0 ? true : false;
         }

    }
}

/*
  Push the opposite into an array
if it is the closing, check to see if equal is last
if so pop and continue
if not, return false 

if the loop is finished, check to see if the array is empty.
If not return false, if so return true
 */
