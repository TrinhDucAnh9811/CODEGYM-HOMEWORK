using System;
namespace DucANh
{
    class Program
    {
        static void Main(string[] args)
        {
            double exchangeRate = 23830;

            Console.WriteLine("Enter the amount of USD: ");
            double uSD = Double.Parse(Console.ReadLine());

            Console.WriteLine("Value when convert from USD to VND is: " + uSD*exchangeRate + " dong. ");
        }
    }
}