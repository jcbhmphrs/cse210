using System;
public class Scripture
{
    Library _library = new Library();
    private string _reference;
    private List<Word> _words = new List<Word>();
    public Scripture()
    {
        string randomScript = _library.GetRandomEntry();
        _reference = randomScript.Split("|")[0];
        this.SetVerse(randomScript.Split("|")[1]);
    }
    public Scripture(string reference) //constructor
    {
        bool scriptFound = false;
        foreach (string script in _library.GetLibrary())
        {
            if (script.Contains(reference))
            {
                _reference = script.Split("|")[0];
                this.SetVerse(script.Split("|")[1]);
                scriptFound = true;
                break;
            }
        }
        if (!scriptFound)
        {
            _reference = "unknown reference";
            Word newWord = new Word("unknown verse");
            _words.Add(newWord);
        }
    }
    public void SetVerse(string verse)
    {
        foreach (string word in verse.Split(" "))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void SetReference(string reference)
    {
        _reference = reference;
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public bool Hidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetVisible())
            {
                return false;
            }
        }
        return true;
    }
    public void Show()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine("");
    }
}