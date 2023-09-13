using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach(var anim in animals)
            {
                Console.WriteLine(anim.MakeSound());
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Apple();
            fruits[1] = new Orange();

            foreach (Fruit fruit in fruits) 
            {
                Console.WriteLine(fruit.HowToEat());
            }


            
        }
    }
}