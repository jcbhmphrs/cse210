using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favoriteNumber = int.Parse(Console.ReadLine());
            return favoriteNumber;
        }
        static int SquareNumber(int value)
        {
            return value * value;
        }
        static void DisplayResults(string userName, int favoriteNumber)
        {
            int valueSquared = SquareNumber(favoriteNumber);
            Console.WriteLine($"{userName}, your favorite number squared is {valueSquared}");
        }
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        DisplayResults(userName, favoriteNumber);
    }
}