using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5m", "kitty");
            cat.PrintInfo();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}