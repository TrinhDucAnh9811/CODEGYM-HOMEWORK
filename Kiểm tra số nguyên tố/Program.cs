using System;

System.Console.WriteLine("This is the program for checking whether a number is a prime or not?");
System.Console.WriteLine("Enter your number here: ");
int number = Int32.Parse(Console.ReadLine());
bool isPrime = true;

if(number<2 && number>0)
{
    isPrime=false;
    System.Console.WriteLine("Please enter again!");
}

else
{
while(isPrime)
{
    for(int i = 2 ; i<number; i++)
    {
        int result = number %i;
        if(result == 0)
        {
            isPrime=false;
        }    
       
    }
      break;  
}
if(isPrime)
{System.Console.WriteLine("This is a Prime");}
else
{System.Console.WriteLine("This is not a Prime");}

}