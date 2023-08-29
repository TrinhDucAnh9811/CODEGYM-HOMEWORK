
using System;

namespace MaxValue2DArray
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] mang = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Nhap so can chen vao mang: ");
            int so_can_chen = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vi tri can chen vao mang: ");
            int vi_tri_chen = int.Parse(Console.ReadLine());

            if(vi_tri_chen >mang.Length-1 || vi_tri_chen<0 )
            { Console.WriteLine("Khong the chen vao trong mang"); }

            else
            {
                for (int i = mang.Length - 1; i > vi_tri_chen; i--)
                {
                    mang[i] = mang[i - 1];
                }
                mang[vi_tri_chen] = so_can_chen;

            }

            IN_MANG(mang);
            Console.ReadKey();
        }


        public static void IN_MANG(int[] mang)
        {
            for(int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }
    }
}
