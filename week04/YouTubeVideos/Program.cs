using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(300, "How to Code in C#", "John Doe");
        video1._comments.Add(new Comment("Alice", "Great tutorial!"));
        video1._comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video1._comments.Add(new Comment("Charlie", "I learned a lot from this video."));

        videos.Add(video1);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }

        Video video2 = new Video(300, "How to Code in C#", "John Doe");
        video2._comments.Add(new Comment("Alice", "Great tutorial!"));
        video2._comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video2._comments.Add(new Comment("Charlie", "I learned a lot from this video."));

        videos.Add(video2);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }

        Video video3 = new Video(300, "How to Code in C#", "John Doe");
        video3._comments.Add(new Comment("Alice", "Great tutorial!"));
        video3._comments.Add(new Comment("Bob", "Very helpful, thanks!"));
        video3._comments.Add(new Comment("Charlie", "I learned a lot from this video."));

        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}