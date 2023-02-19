using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you recieve in class? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        string grade = "";
        if (percent >= 90)
        {
            grade = "A";
        } 
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        bool pass = true;
        if (percent >= 70)
        {
            pass = true;
        }
        else
        {
            pass = false;
        }
        if (pass)
        {
            Console.Write($"Your grade is: {grade}. Hurray! You Passed.");
        }
        else
        {
            Console.Write($"Your grade is: {grade}. You didnt pass. Better luck next time.");
        }
    }
}