using System;
using Microsoft.VisualBasic;

class Program
{

    //Function displays a simple welcome message.
    static void DisplayWelcome()
    {

        Console.WriteLine("Welcome to the program!");

    }

    //Function prompts user for their name and returns a string containing username.
    static string PromptUserName()
    {

        Console.Write("Please enter your name: ");
        string funUserName = Console.ReadLine();

        return funUserName;

    }

    //Function prompts user for their favorite number and returns favorite number as an integer.
    static int PromptUserNumber()
    {

        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int funUserNumber = int.Parse(userInput);

        return funUserNumber;  

    }

    //Function has parameter int that is squared and returned as an integer value.
    static int SquareNumber(int userNumber)
    {

        double doubleUserNumber = userNumber;
        double exponent = 2.0;
        double funNumSquared = Math.Pow(doubleUserNumber, exponent);

        return (int)funNumSquared;

    }

    //Function displays Main local variables userName and numSquared in a formatted string. Its parameters are the variables to be displayed.
    static void DisplayResult(string name, int squared)
    {

        Console. WriteLine($"{name}, the square of your number is {squared}.");

    }
    static void Main(string[] args)
    {   
        //Function call to welcoming message.
        DisplayWelcome();

        //Function call to store username.
        string userName = PromptUserName();


        //Function call to store user's favorite number.
        int userNumber = PromptUserNumber();

        //Function call to store a number that has been raised to the second power, its argument is the user's favorite number previously 
        // obtained.
        int numSquared = SquareNumber(userNumber);

        //Function call to display username and square of number in the same formatted string.
        DisplayResult(userName, numSquared);





        
    }
}
