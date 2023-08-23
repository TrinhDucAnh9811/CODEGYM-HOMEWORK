using System;
namespace DucAnh
{
    class program
    {
        static void Main(string[]args)
        {
            int player;
            string[] numberBelow10 = {"","One","Two","Three","Four","Five","Six","Seven","Eight","Nine", "Ten"};
            string[] numberBelow20 = {"","Eleven","Twelve","Thirteen","Fourteen","Fifteen","Sixteen","Seventeen","Eighteen","Nineteen","Twenty"};
            string[] headNumber = {"","","Tweny", "Thirty", "Fourty","Fifty","Sixty","Seventy","Eighty","Ninety"};
            string hundred = "Hundred";

            System.Console.WriteLine("Enter number wanted to translate to text: ");
            player =Int32.Parse(Console.ReadLine());

            if(player <10)
            {
                System.Console.WriteLine($"Your number is: {numberBelow10[player]}");
            }

            else if(player < 21)
            {
                System.Console.WriteLine($"Your number is: {numberBelow20[player - 10]}");
            }

            else if(player<100)
            {
            System.Console.WriteLine($"Your number is: {headNumber[player/10]} - {numberBelow10[player%10]}");
            }

            else if(player == 100)
            {
                System.Console.WriteLine($"Your number is: One-hundred");
            }

            else if(player < 1000)
            {
                int remainder = player % 100;
                Console.WriteLine($"Your number is: {numberBelow10[player / 100]}-{hundred} {headNumber[remainder / 10]} {numberBelow10[remainder % 10]}");
           
        }
    }
}
}