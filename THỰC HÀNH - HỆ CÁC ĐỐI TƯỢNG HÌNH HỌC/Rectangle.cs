namespace DucAnh
{
    public class Regtangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;
        public void Rectangle() { }

        public void Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public GetWidth()
        {
            return width;
        }

        public virtual void SetWidth(double width)
        {
            this.width = width;
        }

        public GetLength()
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

    public static void Main(String[] args)
    {

        Rectangle rectangle = new Rectangle();

        Console.WriteLine(rectangle);

        rectangle = new Rectangle(2.3, 5.8);

        Console.WriteLine(rectangle);

        rectangle = new Rectangle(2.5, 3.8, "orange", true);

        Console.WriteLine(rectangle);

    }
}


    
