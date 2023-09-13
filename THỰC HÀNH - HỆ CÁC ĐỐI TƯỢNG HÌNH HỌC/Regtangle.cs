namespace DucAnh
{
    public class Regtangle : Shape
    {
        public double width = 1.0;
        public double length = 1.0;
        public void Rectangle() { }

        public Regtangle() { }
        public Regtangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Regtangle(string color, bool filled, double width, double length) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double GetWidth()
        {
            return width;
        }

        public virtual void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public virtual void SetLength(double length)
        {
            this.length = length;
        }

        public double GetArea()
        {
            return width * this.length;
        }

        public double GetPerimeter()
        {
            return 2 * (width + this.length);
        }

        public override String ToString()
        {
            return "A Rectangle with width =" + GetWidth() + " and " + length + " = " + GetLength() + ", which is a subclass of " + base.ToString();

        }

    }
    
}



    
