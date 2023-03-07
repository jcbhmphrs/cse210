using System;
public abstract class Assignment
{
    protected string _studentName, _subject;
    public Assignment(string studentName, string subject)
    {
        _studentName = studentName;
        _subject = subject;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_subject}";
    }
}