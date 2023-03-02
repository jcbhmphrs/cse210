using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Prompt newPrompt = new Prompt();
        newPrompt.setScripture();

        do
        {
            Console.Clear();
            newPrompt.Show();
            Console.WriteLine("Press Enter to remove words, or type quit.");
            userInput = Console.ReadLine().ToLower();
            newPrompt.HideWords(4);

        } while (userInput != "quit" && newPrompt.getHiddenWordsCount() >= newPrompt.getTotalWords());

    }
}