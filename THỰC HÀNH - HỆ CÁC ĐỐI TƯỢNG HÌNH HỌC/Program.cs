namespace DucAnh
{ 
class Program
{
    static void Main(string[] args)

    {
        Shape shape = new Shape();
        Console.WriteLine(shape);
        shape = new Shape("red", false);
        Console.WriteLine(shape);
        

        Circle circle = new Circle();
        Console.WriteLine(circle);

        circle = new Circle(3.5);
        Console.WriteLine(circle);

        circle = new Circle(3.5, "indigo", false);
        Console.WriteLine(circle);


            Regtangle regtangle = new Regtangle();

            Console.WriteLine(regtangle);

            regtangle = new Regtangle(2.3, 5.8);

            Console.WriteLine(regtangle);

            regtangle = new Regtangle( "orange", true, 2.5, 3.8);

            Console.WriteLine(regtangle);

            Console.ReadKey();
    }
}
}

    
