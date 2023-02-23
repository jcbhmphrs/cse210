using System;

public class Journal
{
    public List<Entry> entries = new List<Entry>();


    public void AddEntry()
    {
        Entry entry = new Entry();
        Console.WriteLine(entry.prompt.text);
        Console.Write("> ");
        entry.entryText = Console.ReadLine();
        entries.Add(entry);
    }


    public void Show()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.entryDate}: {entry.prompt.text}: {entry.entryText}");
        }
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

    }


    public void LoadFile()
    {
        entries.Clear();
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(": ");
            string loadDate = parts[0];
            string loadPrompt = parts[1];
            string loadText = parts[2];
            Entry entry = new Entry();
            entry.entryDate = loadDate;
            entry.prompt.text = loadPrompt;
            entry.entryText = loadText;
            entries.Add(entry);
        }
    }


    public void SaveFile()
    {
        Console.Write("What is the filename? ");
        string fileName = Console.ReadLine();
        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.entryDate}: {entry.prompt.text}: {entry.entryText}");
            }
        }
    }


}