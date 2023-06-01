using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingAssignment()
    {
        string tempStudentName = GetStudentName();
        return $"{_title} by {tempStudentName}";
    }
}