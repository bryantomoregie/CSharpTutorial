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

        public static void NonFactorial()
        {
            Console.WriteLine("Enter number:");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            int n = number;

            while(number >= 1)
            {
                n *= n - 1;
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

            Console.WriteLine("My result:" + numbers[6]);

            Console.WriteLine(max);
        }

        public static void ReverseString()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            char[] array = name.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}

//for each number divisible by 3 console.writeline 
