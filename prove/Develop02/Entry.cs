using System;

public class Entry
{
    public string entryDate = DateTime.Now.ToShortDateString();
    public Prompt prompt = new Prompt();
    public string entryText;

}
