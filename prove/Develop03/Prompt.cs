using System;
public class Prompt
{
    private static Library _newLibrary = new Library();
    private static Scripture _scripture;
    private static Random random = new Random();
    public Prompt(string reference)
    {
        _scripture = new Scripture(reference);
    }
    public Prompt()
    {
        _scripture = new Scripture();
    }
    public void setRandomScripture()
    {
        int position = random.Next(1, _newLibrary.GetEntryCount());
        _scripture.SetReference(_newLibrary.GetEntry(position).Split("|")[0]);
        _scripture.SetVerse(_newLibrary.GetEntry(position).Split("|")[1]);
    }
    public void Show()
    {
        _scripture.Show();
    }
    public void HideWords(int frequency)
    {
        int wordsHidden = 0;
        do
        {
            int index = random.Next(_scripture.GetWords().Count());
            if (_scripture.GetWords()[index].GetVisible())
            {
                _scripture.GetWords()[index].Hide();
                wordsHidden++;
            }
        } while (!_scripture.Hidden() && wordsHidden != frequency);
    }
    public bool GetScriptureVisability()
    {
        return _scripture.Hidden();
    }
}