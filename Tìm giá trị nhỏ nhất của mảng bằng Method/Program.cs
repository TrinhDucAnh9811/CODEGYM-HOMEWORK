using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string option;

            while (playAgain)
            {
                Console.WriteLine("The array");
                int[,] mang_so = new int[3, 3];
                Random random = new Random();

                for (int i = 0; i < mang_so.GetLength(0); i++)
                {
                    for (int j = 0; j < mang_so.GetLength(1); j++)
                    {
                        mang_so[i, j] = random.Next(0, 10);
                        Console.Write(mang_so[i, j] + " ");

                    }
                    Console.WriteLine();
                }

                Tim_Gia_Tri_Nho_Nhat(mang_so);
                Console.WriteLine($"The min value of the array we've just created is: {Tim_Gia_Tri_Nho_Nhat(mang_so)}");
                

                Console.WriteLine("Do you want to play again? Y/N");
                option = Console.ReadLine().ToUpper();
                if(option =="Y")
                {
                    playAgain = true;
                }
                else if(option =="N")
                {
                    playAgain= false;
                }
                else if(option == "")
                {
                    playAgain = false;
                }

                
            }
        }


    public static int Tim_Gia_Tri_Nho_Nhat(int[,] mang_so)
        {
            int gtnn = int.MaxValue;
            for (int i = 0; i < mang_so.GetLength(0); i++)
            {
                for (int j = 0; j < mang_so.GetLength(1); j++)
                {
                    if (mang_so[i, j] <gtnn)
                    {
                         gtnn = mang_so[i, j];
                    }
                }
              
            }
            return gtnn;
        }
    }
}