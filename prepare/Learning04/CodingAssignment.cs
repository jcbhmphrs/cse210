using System;
public class CodingAssignment : Assignment 
{
    private string _project, _codeLanguage;

    public CodingAssignment(string studentName, string subject, string project, string codeLanguage) : base(studentName, subject)
    {
        _project = project;
        _codeLanguage = codeLanguage;
    }

    public string GetHomeworkList()
    {
        Console.WriteLine(this.GetSummary());
        return $"project: {_project} in {_codeLanguage}\n";
    }
}