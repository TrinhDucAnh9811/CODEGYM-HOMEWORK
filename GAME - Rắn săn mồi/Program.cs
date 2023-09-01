using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 10;
            int height = 8;
            int[,] walls = new int[width, height]; //Mảng 2 chiều của tường
            int[] snake;

            //Vị trí ban đầu của mồi (random + if)     
            Random randomFood = new Random();
            int foodRow = randomFood.Next (1,9);
            int foodCol = randomFood.Next(1, 8);
            if (foodRow == 2 & foodCol == 2)
            {
                 foodRow = randomFood.Next(1, 9);
                 foodCol = randomFood.Next(1, 8);
            }    

            //Vị trí ban đầu của rắn:
            int originalRow = 2;
            int originalCol = 2;

            int tempRow = 0;
            int tempCol = 0;


            bool play = true;



            while (play)
            {
                
                //Set vị trí ban đầu của rắn, đặt màu Green:
                Console.SetCursorPosition(originalRow, originalCol);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(' ');

                //Set vị trí ban đầu của mồi:
                Console.SetCursorPosition(foodRow, foodCol);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("0");

                //Vẽ tường Red:
                Console.BackgroundColor = ConsoleColor.Red;
                //Ve hang tren cung           
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("#");
                }

                //Ve hang cuoi cung
                for (int i = 0; i < width; i++)
                {
                    Console.SetCursorPosition(i, height);
                    Console.Write("#");

                }

                //Ve hang ben trai
                for (int i = 1; i < height; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("#");

                }

                //Ve hang ben phai
                for (int i = 1; i < height + 1; i++)
                {
                    Console.SetCursorPosition(width - 1, i);
                    Console.WriteLine("#");

                }

                //Lấy Input từ người dùng:
                ConsoleKeyInfo player_input = Console.ReadKey();

                // Xóa vị trí cũ của rắn (Test: Nếu không có đoạn code này, sẽ không xóa vị trí cũ)
                Console.SetCursorPosition(originalRow, originalCol);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");

                if (player_input.Key == ConsoleKey.RightArrow)
                {
                    tempRow = originalRow + 1;
                    tempCol = originalCol;
                }
                else if (player_input.Key == ConsoleKey.LeftArrow)
                {
                    tempRow = originalRow - 1;
                    tempCol = originalCol;
                }
                else if (player_input.Key == ConsoleKey.UpArrow)
                {
                    tempRow = originalRow;
                    tempCol = originalCol - 1;
                }
                else if (player_input.Key == ConsoleKey.DownArrow)
                {
                    tempRow = originalRow;
                    tempCol = originalCol + 1;
                }

                originalRow = tempRow;
                originalCol = tempCol;

                // Vẽ rắn mới tại vị trí mới
                Console.SetCursorPosition(originalRow, originalCol);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(' ');
            }
        }
    }
}
               
               

  
