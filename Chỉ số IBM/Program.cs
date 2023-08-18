using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI - Body Mass Index program");
            Console.WriteLine("Given your height and Weight to calculate");

            double height;
            double weight;

            Console.WriteLine("Enter number your height: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number your weight: ");
            weight = double.Parse(Console.ReadLine());
          
            double BMI = weight/Math.Pow(height,2);
            Console.WriteLine("Your BMI Index is:" + BMI );

            if(BMI<18.5)
            {Console.WriteLine("Underweight");}
            else if(BMI<25)
            {Console.WriteLine("Normal");}
            else if(BMI<30)
            {Console.WriteLine("Overweight");}
            else
            {Console.WriteLine("Obese");}
        

        }
    }
}

