using System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This's a program to convert Celsius to Fahrenheit and in versa");
        Console.WriteLine("--------------------------------------------------------------");

        //Convert C to F:
        Console.WriteLine("Please enter the Celsius degree: ");
        double celsius = double.Parse(Console.ReadLine());
        Console.WriteLine($"The Fehrenheit is: {celsiusToFehrenheit(celsius)}\n");


        //Convert F to C:
        Console.WriteLine("Please enter the Fehrenheit degree: ");
        double Fehrenheit = double.Parse(Console.ReadLine());
        Console.WriteLine($"The Celsius is: {FehrenheitToCelsius(Fehrenheit)}\n");

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




