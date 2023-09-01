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
            int Score = 0;

            //Vị trí ban đầu của mồi, đảm bảo khác vị trí của rắn ban đầu (random + if):     
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

            //Biến lưu trữ vị trí tạm thời sau khi di chuyển:
            int tempRow = 0;
            int tempCol = 0;


            bool play = true;


            while (play)
            {
                //vị trí điểm số (score position):
                Console.SetCursorPosition(15, 4);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Your score:" + Score);

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


                //Trường hợp rắn ăn được mồi, tạo mồi mới:
                if(originalCol == foodCol & originalRow == foodRow)
                {
                    //1. Xóa mồi cũ
                    Console.SetCursorPosition(foodRow, foodCol);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    //2. Tạo mồi mới random:
                    foodRow = randomFood.Next(1, 9);
                    foodCol = randomFood.Next(1, 8);
                    Score++;
                }


                //Trường hợp rắn chạm vào tường, kết thúc vòng lặp + hiển thị Game-Over:
                if (originalRow >8 || originalRow < 1 ||  originalCol > 7 || originalCol <1)
                {
                    play = false;
                }
            }

            //Hiển thị Game-Over:
            Console.SetCursorPosition(2, 5);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Game Over");
            Console.ReadKey();
        }
    }
}
               
               

  
