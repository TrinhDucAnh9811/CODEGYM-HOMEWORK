using System;
using System.Security.Cryptography.X509Certificates;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] martrix = new int[4, 3];
            GanSoChoMang(martrix);
            In_So_Ra_Man_Hinh(martrix);
            Console.WriteLine("Ma tran sau khi bien doi: ");
            

            for (int i = 0; i < martrix.GetLength(0); i++)
            {
                for (int j = 0; j < martrix.GetLength(1); j++)
                {
                    int i1 = rand.Next(0, martrix.GetLength(0));
                    int j1 = rand.Next(0, martrix.GetLength(1));
                    //Swap
                    int temp = martrix[i, j];
                    martrix[i, j] = martrix[i1, j1];
                    martrix[i1, j1] = temp;

                    Console.Write(martrix[i, j] + " ");

                }
                Console.WriteLine();

            }
            Console.ReadKey();





        }

        public static void GanSoChoMang(int[,] martrix)
        {
            Random rand2 = new Random();
            for (int i = 0; i < martrix.GetLength(0); i++)
            {
                for (int j = 0; j < martrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the value of array, position: {i}, {j}");
                    martrix[i, j] = (int)(rand2.Next(0, 10));

                }

            }


        }

        public static void In_So_Ra_Man_Hinh(int[,] martrix)
        {
            // In ra giá trị của mảng
            for (int i = 0; i < martrix.GetLength(0); i++)
            {
                for (int j = 0; j < martrix.GetLength(1); j++)
                {
                    Console.Write(martrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}


