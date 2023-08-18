using System;
namespace ducAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Width: ");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Area of the rectangle is: " + height*width);
        }
}
}