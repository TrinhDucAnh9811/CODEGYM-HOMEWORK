using System;
namespace DucAnh
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter you height: ");
            double height = double.Parse(Console.ReadLine());

            Regtangle regtangle = new Regtangle(width, height);

            Console.WriteLine("The area of the regtangel is:" + regtangle.GetArea());
            Console.WriteLine("The Perimeter of the regtangle is: " + regtangle.GetPerimeter());
            Console.WriteLine("The Regtangle \n: " + regtangle.Display());
        }
    }
    class Regtangle
    {
        double width, height;
        public Regtangle() { }

        public Regtangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return (width * height);
        }

        public double GetPerimeter()
        {
            return (width + height) * 2;
        }

        public string Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";
        }
    }



}