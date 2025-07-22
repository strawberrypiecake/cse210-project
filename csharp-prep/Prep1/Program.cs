using System;

class Program
{
    static void Main(string[] args)
    {
        //Prompts user for first name and stores it in variable.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Prompts user for last name and stores it in variable.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        //Displays formatted text back in one line.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
