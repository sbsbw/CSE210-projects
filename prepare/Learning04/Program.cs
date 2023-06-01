using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Sean Walker", "Math");
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        MathAssignment assignment2 = new MathAssignment("Sean Walker", "Math", "4.5", "3-2");
        string summary2 = assignment2.GetSummary();
        string homeworkList2 = assignment2.GetHomeworkList();
        Console.WriteLine(summary2);
        Console.WriteLine(homeworkList2);
        
        WritingAssignment assignment3 = new WritingAssignment("Sean Walker", "English", "Random Essay");
        string summary3 = assignment3.GetSummary();
        string writingAssignment3 = assignment3.GetWritingAssignment();
        Console.WriteLine(summary3);
        Console.WriteLine(writingAssignment3);
    }
}