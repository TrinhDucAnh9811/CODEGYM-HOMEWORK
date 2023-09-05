using System;
namespace DucAnh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student.Change();
            Student s1 = new Student(01, "Duc Anh");
            Student s2 = new Student(02, "Dieu Hoa");
            Student s3 = new Student(03, "Thu Thuy");
            s1.Display();
            s2.Display();
            s3.Display();
            Console.ReadKey();
        }
    }


        public class Student
        {
            private int rollno;
            private string name;
            private static string college = "HUST"; //Không có static sẽ gây lỗi

            //Constructor to initialize the variables:
            public Student(int r, string n)
            {
                rollno = r;
                name = n;
            }

            //Static method to change the value of static variables:
            public static void Change()
            {
                college = "FPT";
            }

            //Method to Display values:
            public void Display() //Không được thêm static
            {
                Console.WriteLine(rollno + " " + name + " " + college);
            }
        
        }
    
    
}