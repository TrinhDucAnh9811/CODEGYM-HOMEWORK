using System;

namespace MaxValue2DArray
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int[,] mang_hai_chieu = {
                { 3, 8, 2 },
                { 10, 4, 6 },
                { 1, 7, 9 }
            };
            
            int maxValue = int.MinValue;

            for (int i = 0; i < mang_hai_chieu.GetLength(0); i++)
            {
                for (int j = 0; j < mang_hai_chieu.GetLength(1); j++)
                {
                    if (mang_hai_chieu[i, j] > maxValue)
                    {
                        maxValue = mang_hai_chieu[i, j];
                    }
                }
            }
            Console.WriteLine("Max value in the 2D array: " + maxValue);
        }
    }
}