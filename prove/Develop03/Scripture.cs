using System;

public class Scripture
{
    private string _reference;
    private string _verse;


    public Scripture()
    {
        _reference = null;
        _verse = null;
    }
    public Scripture(string reference, string verse)
    {
        _reference = reference;
        _verse = verse;
    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }
    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetVerse()
    {
        return _verse;
    }
    public string GetReference()
    {
        return _reference;
    }
}