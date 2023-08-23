using System;

int choice;
bool drawAgain = true;
string response;
System.Console.WriteLine("This's a Program for creating your own shape, please see the menu below:");
System.Console.WriteLine("Menu");
System.Console.WriteLine("1. Draw Triangle");
System.Console.WriteLine("2. Draw the Square");
System.Console.WriteLine("3. Draw the Rectangle");


while(drawAgain)
{
    System.Console.WriteLine("Enter your option: ");
    choice = Int32.Parse(Console.ReadLine());
    switch(choice)
    {
        case 1:
        Console.WriteLine("******");
        Console.WriteLine("*****");
        Console.WriteLine("****");
        Console.WriteLine("***");
        Console.WriteLine("**");
        Console.WriteLine("*");
        break;

        case 2:
        Console.WriteLine("Draw the square");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        break;

        case 3:
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
        Console.WriteLine("* * * * * *");
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
