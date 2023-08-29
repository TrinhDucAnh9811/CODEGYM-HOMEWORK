using System;
using System.Security.Cryptography.X509Certificates;

namespace DucAnh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = false;
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (input_name == students[i])
                {
                    isTrue = true;
                    Console.WriteLine($"The position of student named {input_name} is: {i + 1}");
                    break;
                }
                
            }
            if (!isTrue)
            {
                Console.WriteLine("There's no student that named " + input_name + " in the array");
            }
            Console.ReadKey();
        }
    }
}