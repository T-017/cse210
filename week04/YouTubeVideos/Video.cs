using System;

public class Video
{
  public List<Comment> _comments = new List<Comment>();
  private int _videoLength;
  private string _videoTitle;
  private string _videoAuthor;

  public Video(int videoLength, string videoTitle, string videoAuthor)
  {
    _videoLength = videoLength;
    _videoTitle = videoTitle;
    _videoAuthor = videoAuthor;
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
  }

  public int GetNumberOfComments()
  {
    return _comments.Count;
  }
  
  public void DisplayVideoInfo()
  {
    Console.WriteLine($"Title: {_videoTitle}");
    Console.WriteLine($"Author: {_videoAuthor}");
    Console.WriteLine($"Length: {_videoLength} seconds");
    Console.WriteLine($"Number of Comments: {_comments.Count}");
    foreach (var comment in _comments)
    {
      comment.DisplayComment();
    }
  }
}