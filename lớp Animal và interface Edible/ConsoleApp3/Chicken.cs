using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Chicken: Animal, IEdible
    {
        public override string MakeSound()
        {
            return "Ò ó o o";
        }

        public string HowToEat()
        {
            return "Fried or boiled";
        }
    }
}
