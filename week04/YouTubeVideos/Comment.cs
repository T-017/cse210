using System;

public class Comment
{
  public string CommenterName { get; set; }
  public string CommentText { get; set; }
  public int CommentLength
  {
    get { return CommentText.Length; }
  }

  public Comment(string commenterName, string commentText)
  {
    CommenterName = commenterName;
    CommentText = commentText;
  }
}