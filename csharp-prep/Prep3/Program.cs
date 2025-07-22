using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        bool continuePrompt = true;

        while(continuePrompt)
        {
            Console.Write("What is your guess? ");
            string inputGuess = Console.ReadLine();
            int magicGuess = int.Parse(inputGuess);

            if(magicGuess > magicNumber)
            {

                Console.WriteLine("Lower");
                Console.WriteLine();

            }
            else if(magicGuess < magicNumber)
            {

                Console.WriteLine("Higher");
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine("You guessed it!");
                continuePrompt = false;

            }

        }

    }
}
