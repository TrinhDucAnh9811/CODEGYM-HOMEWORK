using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*Circle circle = new Circle();*/
            Cylinder cylinder = new Cylinder(12.3, "Red", 13.0);
            Console.WriteLine(cylinder);

            Circle circle = new Circle(12.3, "Blue");
            Console.WriteLine(circle);
        }
    }
}