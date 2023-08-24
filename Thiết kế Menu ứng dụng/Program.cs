using System;
using System.Globalization;

int choice;
bool drawAgain = true;
string response;

int height = 10;
int width = 10;
int width_rectangle = 15;
int width_temp = 10;
int width_reverse_triangle = 1;
System.Console.WriteLine("This's a Program for creating your own shape, please see the menu below:");
System.Console.WriteLine("Menu");
System.Console.WriteLine("1. Draw Square");
System.Console.WriteLine("2. Draw the Rectangle");
System.Console.WriteLine("3. Draw the Triangle 1");
System.Console.WriteLine("4. Draw the Triangle 2");


while(drawAgain)
{
    System.Console.WriteLine("Enter your option: ");
    choice = Int32.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
        for(int i = 0; i<height; i++)
        {
            for(int j=0; j<width;j++ )
            {
                Console.Write("* ");
            }
            System.Console.WriteLine("");
        }
        break;

        case 2:
        for(int i = 0; i<height; i++)
        {
            for(int j=0; j<width_rectangle;j++ )
            {
                Console.Write("* ");
            }
             System.Console.WriteLine("");
        }
        break;

        case 3:
        for(int i = 0; i<height; i++)
        {
            for(int j=0; j<width_temp;j++ )
            {
                Console.Write("* ");
            }
            width_temp --;
            System.Console.WriteLine("");
        }
        break;

        case 4:
        for(int i = 0; i<height; i++)
        {
            for(int j=0; j<width_reverse_triangle;j++ )
            {
                Console.Write("* ");
            }
            width_reverse_triangle ++;
            System.Console.WriteLine("");
        }
        break;

    }

    System.Console.WriteLine("Do you want to draw again? (Y/N)");
    response=Console.ReadLine();
    if(response == "Y")
    {drawAgain = true;}
    else if(response == "N")
    {drawAgain=false;}

    }
    System.Console.WriteLine("Thanks for playing!");
