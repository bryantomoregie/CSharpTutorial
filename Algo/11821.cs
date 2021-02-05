using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutorial
{
    class _11821
    {
        public static void Matrix(int num)
        {
            int[,] array2d = new int[3, 4] { {1, 3, 5, 7 }, {10, 11, 16, 20 }, {23, 30, 34, 60 } };

            var jaggedArry = new int[3][];

      


            //for (int i = 0; i < array2d.Length; i++)
            //{
            //    if(Array.BinarySearch(array2d[i], 3))
            //    {

            //    }
            //}
           
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    if(array2d[i, j] == num)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                }
            }
            Console.WriteLine("false");
        }
    }
}
