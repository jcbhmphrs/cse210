using System;
public class MathAssignment : Assignment
{
    private string _textbookSection, _problems;
    public MathAssignment(string studentName, string subject, string textbookSection, string problems) : base(studentName, subject)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        Console.WriteLine(this.GetSummary());
        return $"Section - {_textbookSection}; Problems - {_problems}\n";
    }
}