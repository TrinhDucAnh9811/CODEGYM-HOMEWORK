using System;
namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string option;
            int number;
            int position;
            

            while (playAgain)
            {
                Console.WriteLine("The array");
                int[] mang_so = new int[6];
                Random random = new Random();

                for (int i = 0; i < mang_so.Length; i++)
                { 
                        mang_so[i] = random.Next(0, 10);
                        Console.Write(mang_so[i] + " ");      
                }

                //Nhap gia tri can xoa:
                Console.WriteLine("Enter the number you want to delete: ");
                number = int.Parse(Console.ReadLine());

                Delete_Value_In_Array(mang_so, number);

                Console.WriteLine("\nThe new array will be: ");

                Print_New_Array(mang_so, number);

                Console.WriteLine("\nDo you want to play again? Y/N");
                option = Console.ReadLine().ToUpper();
                if (option == "Y")
                {
                    playAgain = true;
                }
                else if (option == "N")
                {
                    playAgain = false;
                }
                else if (option == "")
                {
                    playAgain = false;
                }


            }
        }


        public static int Delete_Value_In_Array(int[] mang_so, int number)
        {
            for (int i = 0; i < mang_so.Length; i++) 
                if (mang_so[i] == number)
                {
                    mang_so[i] = 0;
                    
                    for (int j = i; j < mang_so.Length - 1; j++)
                    {
                        mang_so[j] = mang_so[j+1];
                    }
                    mang_so[mang_so.Length - 1] = 0;

                  
                    
                }
            return number;
        }

        public static void Print_New_Array(int[] mang_so, int number)
        {
            for (int i = 0; i < mang_so.Length; i++)
            {
                Console.Write(mang_so[i] + " ");
            }          
        }

    }
    }