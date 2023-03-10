using System;

public class Word
{
    private bool _visible;
    private string _word;


    public Word(string word)
    {
        _visible = true;
        _word = word;
    }



    public bool GetVisible()
    {
        return _visible;
    }



    public void Hide()
    {
        _visible = false;
        string blankWord = "";
        foreach (char letter in _word)
        {
            blankWord += "_";
        }
        _word =
        _word.EndsWith(":") ? blankWord = blankWord.Remove(0, 1) + ":" :
        _word.EndsWith(",") ? blankWord = blankWord.Remove(0, 1) + "," :
        _word.EndsWith(";") ? blankWord = blankWord.Remove(0, 1) + ";" :
        _word.EndsWith(".") ? blankWord = blankWord.Remove(0, 1) + "." :
        blankWord;
    }




    public string GetWord()
    {
        return _word;
    }
    
}
