using System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main(string[] args)
    {
        double celsius;
        double Fehrenheit;
        int choice;
        string option;
        bool playAgain = true;

        

        while (playAgain)
        {
            Console.WriteLine("This's a program to convert Celsius to Fahrenheit and in versa");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("Please choose one of these options:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("3. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        //Convert F to C:
                        Console.WriteLine("Please enter the Fehrenheit degree: ");
                        Fehrenheit = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The Celsius is: {FehrenheitToCelsius(Fehrenheit)}\n");
                    }
                    break;

                case 2:
                    {
                        //Convert C to F:
                        Console.WriteLine("Please enter the Celsius degree: ");
                        celsius = double.Parse(Console.ReadLine());
                        Console.WriteLine($"The Fehrenheit is: {celsiusToFehrenheit(celsius)}\n");                   
                    }
                    break;

                case 3:
                    {
                        playAgain = false;                       
                    }
                    break;

            }
            Console.WriteLine("Do you want to reset and choose again ? Y / N");
            option = Console.ReadLine().ToUpper();
            if (option == "Y")
            {
                playAgain = true;
            }
            else if (option == "N")
            {
                playAgain = false;
            }
        }


    }

    public static double celsiusToFehrenheit(double celsius)
    {
        double Fehrenheit = celsius / (5.0 / 9) + 32;

        return Fehrenheit;
        Console.WriteLine($"hehrenheit degree is: {Fehrenheit}");
    }

    public static double FehrenheitToCelsius(double Fehrenheit)
    {
        double Celsius = (5.0 / 9) * (Fehrenheit - 32);

        return Celsius;
        Console.WriteLine($"hehrenheit degree is: {Celsius}");
    }



}




