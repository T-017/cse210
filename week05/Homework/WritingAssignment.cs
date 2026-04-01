using System;

public class WritingAssignment : Assignment
{
  private string _title = "";

  public WritingAssignment(string studentName, string topic, string title, string dueDate) : base(studentName, topic)
  {
    _title = title;
  }

  public string GetWritingInformation()
  {
    return $"{_title} by {_studentName}";
  }
}