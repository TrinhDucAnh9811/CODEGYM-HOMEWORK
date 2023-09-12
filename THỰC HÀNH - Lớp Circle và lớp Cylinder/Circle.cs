using System;
namespace DucAnh
{
     public class Circle
    {
        public double radius;
        public string color;

        public Circle (double radius, string color)                                    //Constructor để khởi tạo radius và color
        {
            this.radius = radius;
            this.color = color;
        }

        public double GetRadius() { return radius; }
        public string GetColor() { return color; }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()                                          //ToString là hàm có sẵn, phải Override lên nó
        {
            return "The Circle with radius: " + GetRadius() + " and color: " + GetColor() + " has Area: " + GetArea();
        }
    }
}