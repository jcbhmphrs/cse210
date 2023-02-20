using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        int userGuess = 0;
        int guessCount = 1;


        do
        {
            guessCount = 1;
            Console.WriteLine("Im thinking of a number between 1 and 100. Can you guess it?");
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);


            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
                guessCount ++;
            }
                else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
                guessCount ++;
            }
            }
            

            Console.WriteLine($"You guessed it in {guessCount} guesses! The magic number was {magicNumber}");
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}