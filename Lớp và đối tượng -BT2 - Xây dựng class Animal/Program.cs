using System;

namespace Animal
{
    public abstract class Animal
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }

        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        public abstract void PrintInfo();
    }

    class Cat : Animal
    {
        private string Name { get; set; }

        public Cat(string weight, string height, string name)
            : base(weight, height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}\nHeight: {1}\nName: {2}", this.Weight, this.Height, this.Name);
        }
    }

    
   
}
