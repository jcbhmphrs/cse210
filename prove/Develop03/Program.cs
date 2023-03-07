using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Memorizer");
        Console.WriteLine("Would you like to: ");
        Console.WriteLine("1: Study a random scripture.");
        Console.WriteLine("2: Select a scripture by reference.");
        int userInput = int.Parse(Console.ReadLine());
        int frequency = 0;
        switch (userInput)
        {
            case 1:
                Console.Write("How many words do you want to disappear at a time? ");
                frequency = int.Parse(Console.ReadLine());
                Prompt _randPrompt = new Prompt();
                MainLoop(_randPrompt, frequency);
                break;
            case 2:
                Console.Write("How many words do you want to disappear at a time? ");
                frequency = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("Reference: ");
                string userRef = Console.ReadLine();
                Prompt _userPrompt = new Prompt(userRef);
                MainLoop(_userPrompt, frequency);
                break;
        }

        static void MainLoop(Prompt prompt, int frequency)
        {
            string loopKey = "";
            do
            {
                Console.Clear();
                prompt.Show();
                Console.WriteLine("\nPress Enter to remove words, or type quit.");
                loopKey = Console.ReadLine();
                prompt.HideWords(frequency);

            } while (loopKey != "quit" && !prompt.GetScriptureVisability());
            Console.Clear();
            prompt.Show();
            Console.WriteLine("\nAll words are Hidden. Press Enter to quit.");
            Console.ReadLine();
            Console.Clear();
        }
    }

}