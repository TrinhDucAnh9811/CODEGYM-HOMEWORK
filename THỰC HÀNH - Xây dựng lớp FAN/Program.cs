using System;
using System.Runtime.CompilerServices;

namespace DucAnh
{
    class FAN
    {
        public const int  SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed = SLOW;
        private bool isOn = false;
        private double radius = 5.0d;
        private string color = "Blue";
 
        public FAN() { }  //Constructor
        public FAN(int speed ,double radius, string color, bool isOn) 
        {
            this.speed = speed;
            this.radius = radius;
            this.color = color;
            this.isOn = isOn;
        }
       

        public void ToString()  //Method
        {
            if (isOn == false)
            {
                Console.WriteLine($"Color of the FAN is: {color}, the radius is: {radius} and the FAN is OFF");
            }

            else
            {
                Console.WriteLine($"The Speed of FAN is: {speed}, the Color of the FAN is: {color}, the radius is: {radius} and the FAN is ON");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FAN fan1 = new FAN(3, 10, "yellow", true) ; 
            FAN fan2 = new FAN(2, 5, "blue", false);

            fan1.ToString();
            fan2.ToString();
            Console.ReadKey();
        }
    }
}