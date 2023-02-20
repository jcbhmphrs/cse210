using System;

public class Resume
{
    public string name;

    public List<Job> jobs = new List<Job>();

    public void Show()
    {
        Console.WriteLine($"Name: {name}");
        
        foreach (Job i in jobs)
        {
            Console.WriteLine("Job:");
            i.Show();    
        }        
    }
}