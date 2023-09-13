using System;
using System.Drawing;

namespace DucAnh
{
    public class Shape
    {
        public string color = "green";
        public bool filled = true;

        public Shape() { }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor()
        {
            this.color = color;
        }

        public bool IsFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }

        public override String ToString()
        {
            return "A Shape with color of " + GetColor() + " and " + (IsFilled() ? "filled" : "not filled");
        }
      
    }
}


