using System;

public class Prompt
{
    private string[] _splitScripture;
    private static Library _newLibrary = new Library();
    private static Scripture _newScript = new Scripture();
    private static Random random = new Random();
    private static List<int> hiddenIndices = new List<int>();
    private static int totalWords = 0;


    public string[] SetSplitVerse()
    {
        return _newScript.GetVerse().Split(" ");
    }
    public void setScripture()
    {
        int position = random.Next(1, _newLibrary.GetEntryCount());
        _newScript.SetReference(_newLibrary.GetEntry(position).Split("|")[0]);
        _newScript.SetVerse(_newLibrary.GetEntry(position).Split("|")[1]);
    }


    public void setTotalWords()
    {
        string[] splitVerse = _newScript.GetVerse().Split(" ");
        totalWords = splitVerse.Count();
    }
    public int getTotalWords()
    {
        return totalWords;
    }





    public int getHiddenWordsCount()
    {
        return hiddenIndices.Count();
    }

    public void Show()
    {
        Console.WriteLine(_newScript.GetReference());
        Console.WriteLine(_newScript.GetVerse());
        Console.WriteLine("");
    }

    public void HideWords(int frequency)
    {
        string[] splitVerse = _newScript.GetVerse().Split(" ");

        for (int i = 0; i < frequency; i++)
        {
            int index = random.Next(splitVerse.Count());
            if (!splitVerse[index].Contains("_"))
            {
                string currentWord = splitVerse[index];
                string emptySpace = "";

                foreach (char letter in currentWord)
                {
                    emptySpace += "_";
                }
                splitVerse[index] =
                currentWord.EndsWith(".") ? emptySpace = emptySpace.Remove(0, 1) + "." :
                currentWord.EndsWith(",") ? emptySpace = emptySpace.Remove(0, 1) + "," :
                currentWord.EndsWith(":") ? emptySpace = emptySpace.Remove(0, 1) + ":" :
                currentWord.EndsWith(";") ? emptySpace = emptySpace.Remove(0, 1) + ";" :
                emptySpace;

                hiddenIndices.Add(index);
                _newScript.SetVerse("");
                foreach (string word in splitVerse)
                {
                    string newWords = _newScript.GetVerse(); 
                    _newScript.SetVerse($"{newWords} {word}");
                }
            }
            else
            {
                index = random.Next(splitVerse.Count() - 1);
                frequency++;
            }
        }



    }




}


