using System;
public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string subject, string title) : base(studentName, subject)
    {
        _title = title;
    }
    public string GetHomeworkList()
    {
        Console.WriteLine(this.GetSummary());
        return $"{_title} by {_studentName}\n";
    }
}