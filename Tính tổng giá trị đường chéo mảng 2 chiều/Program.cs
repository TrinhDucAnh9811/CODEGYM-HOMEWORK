﻿using System;

namespace FindDiagonalValue
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[,] mang_hai_chieu = {
                { 3, 8, 2 },
                { 10, 5, 6 },
                { 1, 7, 9 }
            };
            
            int total = 0;
            
            for (int i = 0; i < mang_hai_chieu.GetLength(0); i++)
            {total += mang_hai_chieu[i, i];}

            Console.WriteLine("Total value of diagonal in 2D Array: " + total);
        }
            
    }
}
