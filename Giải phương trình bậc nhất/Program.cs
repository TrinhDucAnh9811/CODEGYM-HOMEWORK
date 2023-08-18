using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'ax + b = 0', please enter constants: ");

            double result;

            Console.WriteLine("Enter number a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number b: ");
            double b = double.Parse(Console.ReadLine());

            if(a==0)
            {
                if(b==0)
                {Console.WriteLine("Infinite Solutions");}

                if(b!=0)
                {Console.WriteLine("No Solution");}
            }
            else
            {
                result = -b/a;
                Console.WriteLine("The solution is: " + result);
            }

        }
    }
}