using System;
using System.Drawing;

namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2d = new Point2D(12.3f, 22.2f);
            Point3D point3d = new Point3D(2.1f, 51.51f, 33.13f);
            Console.WriteLine(point2d);
            Console.WriteLine(point3d);
        }
    }
}