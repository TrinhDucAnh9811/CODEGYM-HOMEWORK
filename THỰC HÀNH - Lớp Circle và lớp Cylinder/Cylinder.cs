using System;
namespace DucAnh
{
    public class Cylinder : Circle
    {
        private double height;
        public Cylinder(double radius, string color, double height) : base(radius, color) //Gọi constructor lớp cha bằng base(radius, color) để khởi tạo radius và color
        {
            this.height = height;                                  // Vì đã gọi 2 trường radius và color từ lớp cha nên thỉ phải khởi tạo height thôi
        }

        public double GetVolume()
        {
            return GetArea() * height;
        }

        public override string ToString()
        {
            return "The Cylinder with radius: " + GetRadius() + " and color: " + GetColor() + " has Area: " + GetArea() + " and has Volume: " + GetVolume(); 
        }
    }
}