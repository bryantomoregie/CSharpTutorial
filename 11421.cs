using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    public class _11421
    {
        public static void DivisibleByThree()
        {
            int num = 1;
            while (num <= 100)
            {
                if(num % 3 == 0)
                {
                    Console.WriteLine(num);
                }

                num++;
            }
        }

        public static void Factorial()
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            int number = Int16.Parse(input);
            Recursion(number);
        }

        public static int Recursion(int number)
        {

            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Recursion(number - 1);
            }
            Console.WriteLine(number);
        }

        public static void NonRecursion()
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            int n = number;

            while(number >= 2)
            {
                n *= number - 1;
                number--;
            }
            Console.WriteLine($"{input}! = {n}");
        }

        public static void RandomGame()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            Console.WriteLine($"Please guess random number {num}");
            string input = Console.ReadLine();
            int trys = 1;
            
            while(num.ToString() != input && trys < 4)
            {
                trys++;
                Console.WriteLine("Try Again");
                input = Console.ReadLine();
            }
            if(num.ToString() == input)
            {
                Console.WriteLine("You Won!");
            }
            if (num.ToString() != input)
            {
                Console.WriteLine("You Lost");
            }            
        }

        public static void MaxNumber()
        {
            Console.WriteLine("Please enter a series of number, seperated by commas");
            string numbers = Console.ReadLine(); //"1, 2, 3"
            double max = 0;
           
            for (int i = 0; i < numbers.Length ; i++)
            {
                if (Char.IsNumber(numbers, i)) //i == 7
                {
                    if (Char.GetNumericValue(numbers, i) > max)
                    {
                        max = Char.GetNumericValue(numbers, i);
                    }
                }
            }

            Console.WriteLine("My result:" + max);
        }

        public static void ReverseString()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            char[] array = name.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }

        public static void Three()
        {
            Console.WriteLine("Please enter at least 5 comma seperated number");

            string input = Console.ReadLine();
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    continue;
                }
                if (Char.IsNumber(input, i))
                {
                    sb.Append(input[i]);
                }else if (input[i] == ',')
                {
                    list.Add(sb.ToString());
                    sb.Clear();
                }
                if (i == input.Length-1)
                {
                    list.Add(sb.ToString());
                }
            }

            string[] array = list.ToArray();
            //Array.Sort(array);

           for(var i = 0; i < array.Length; i++)
            {
                Char.GetNumericValue(array[i], i);
            }



        }
    }
}

/*
 I need to loop thru this string, if char is a number, check the next char.
If char I want to concat?
Turn that concat into a int, and stick it into an array.
Maybe use a method to order the array and then return 
*/