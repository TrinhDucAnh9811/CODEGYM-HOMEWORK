using System;
using System.Security.Cryptography.X509Certificates;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang = { 1, 2, 4, 5, 31 };
            int total = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                total += mang[i];
            }
            Console.WriteLine($"Tong cua mang 1 chieu: {total}");
            Console.ReadKey();
        }
    }
}
