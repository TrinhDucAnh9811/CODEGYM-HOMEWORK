using System;
using System.Security.Cryptography.X509Certificates;

namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 1, 31, 5, 62, 46, 2, 2, 4, 4, 1, };
            int count = 0;
            Console.WriteLine("Please enter the number wanted to count: ");
            int number = int.Parse(Console.ReadLine());

            count_character(array, count, number);
            
            
            Console.ReadKey();

            
        }
        public static void count_character(int[] array, int count, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    count++;
                }
            }
            Console.WriteLine("The number of occurrences of then number in the aray is: " + count);
        }
    }
}