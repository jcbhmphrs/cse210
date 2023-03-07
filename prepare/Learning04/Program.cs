using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MathAssignment newMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(newMathAssignment.GetHomeworkList());
        WritingAssignment newWritingAssignment = new WritingAssignment("Mary Waters", "European History", "The causes of World War II");
        Console.WriteLine(newWritingAssignment.GetHomeworkList());
        CodingAssignment newCodingAssignment = new CodingAssignment("Miles Noble", "CSE210", "AQ craft", "Java");
        Console.WriteLine(newCodingAssignment.GetHomeworkList());
    }

}