using System;
using System.Collections.Generic;
using System.Linq;
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
                if (num % 3 == 0)
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

            while (number >= 2)
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

            while (num.ToString() != input && trys < 4)
            {
                trys++;
                Console.WriteLine("Try Again");
                input = Console.ReadLine();
            }
            if (num.ToString() == input)
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

            for (int i = 0; i < numbers.Length; i++)
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
                if (input[i] == ' ')
                {
                    continue;
                }
                if (Char.IsNumber(input, i))
                {
                    sb.Append(input[i]);
                }
                else if (input[i] == ',')
                {
                    list.Add(sb.ToString());
                    sb.Clear();
                }
                if (i == input.Length - 1)
                {
                    list.Add(sb.ToString());
                }
            }

            string[] array = list.ToArray();
            //Array.Sort(array);

            for (var i = 0; i < array.Length; i++)
            {
                Char.GetNumericValue(array[i], i);
            }
        }

        public static void Continuous()
        {
            Console.WriteLine("Please enter number or type Quit");
            string input = Console.ReadLine().Trim();
            List<int> list = new List<int>();
           
            while (input != "Quit" || input != "Save")
            {
                list.Add(Int32.Parse(input));
                Console.WriteLine("If done type Save. Else, type another number, or type Quit.");
                input = Console.ReadLine();
               
            }
            if (input == "Save")
            {
                Console.WriteLine(list.Distinct().ToList()) ;
                return;
            }
            else
            {
                return;
            }
            
        }

        public static void Time()
        {
            Console.WriteLine("Please write a time value in the 24 hour format (e.g. 19:00)");
            string time = Console.ReadLine();
            if (time.Length == 4)
            {
                if (Char.GetNumericValue(time, 0) < 3 && time[1] == ':' && Char.GetNumericValue(time, 2) < 6 && Char.GetNumericValue(time, 3) <= 9)
                {
                    Console.WriteLine("ok");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                    return;
                }
            }
            else if(time.Length == 5)
            {

                if (Char.GetNumericValue(time, 0) < 2 && Char.GetNumericValue(time, 1) < 3 && time[2] == ':' && Char.GetNumericValue(time, 3) < 6 && Char.GetNumericValue(time, 4) <= 9)
                {
                    Console.WriteLine("ok");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid Time");
                return;
            }

        }

        public static void Vowels()
        {
            Console.WriteLine("Please enter a word");
            string word = Console.ReadLine();
            int count = 0;
            foreach (var item in word)
            {
                if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}

/*
 I need to loop thru this string, if char is a number, check the next char.
If char I want to concat?
Turn that concat into a int, and stick it into an array.
Maybe use a method to order the array and then return 
*/