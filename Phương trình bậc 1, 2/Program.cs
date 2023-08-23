using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            float result;
            System.Console.WriteLine("Program for solving quadratic equation: ax^2 + bx +c = 0");
            System.Console.WriteLine("Please Enter a: ");
            float a = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Please Enter b: ");
            float b = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Please Enter c: ");
            float c = float.Parse(Console.ReadLine());

            if(a==0)
            {
                if(b==0 && c==0)
                {Console.WriteLine("Infinite Solutions");}

                if(b!=0)
                 
                {result = -c/b;
                    Console.WriteLine("The solution is: " + result);}
            }
            

            if(a!=0)
            {
            double delta = Math.Pow(b,2) - 4*a*c;

            if(delta < 0)
            {
                System.Console.WriteLine("Phuong trinh vo nghiem");
            }
            if(delta == 0)
            {
                System.Console.WriteLine($"Phuong trinh co nghiem kep: {-b/(2*a)}");
            }
            if(delta > 0)
            {
                System.Console.WriteLine($"Phuong trinh co 2 nghiem rieng biet x1, x2: {(-b - (float)(Math.Sqrt(delta)))/(2*a)}, {(-b + (float)(Math.Sqrt(delta)))/(2*a)}");
            }
            }


        }
    }
}