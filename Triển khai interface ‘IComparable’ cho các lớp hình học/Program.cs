namespace DucAnh
{ 
class Program
{
        static void Main(string[] args)

        {
            ComperableCircle[] circles = new ComperableCircle[3];
            circles[0] = new ComperableCircle(3.5);
            circles[1] = new ComperableCircle();
            circles[2] = new ComperableCircle(3.5, "Indigo", false);

            Console.WriteLine("Pre-soreted");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Array.Sort(circles);

            Console.WriteLine("After-sorted:");
            foreach (ComperableCircle circle in circles)
            {
                Console.WriteLine(circle);
            }

            Console.ReadKey();
            Console.ReadKey();



            /*Shape shape = new Shape();
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

                Console.ReadKey();*/


        }
}
}

    
