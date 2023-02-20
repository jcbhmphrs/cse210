using System;

public class Job
{
    public string jobTitle;
    public string companyName;
    public string startYear;
    public string endYear;
    public void Show()
    {
        Console.WriteLine($"{jobTitle} ({companyName})");
        Console.WriteLine($"{startYear} - {endYear}");
    }

}