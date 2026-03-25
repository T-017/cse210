using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a video
        Video video1 = new Video("C# Tutorial", "VS Code Assistant", 600);

        // Create comments for the video
        Comment comment1 = new Comment("Holt", "You have been a great help, thank you.");
        Comment comment2 = new Comment("Toshio", "I have been struggling with C#, but the VS Code Assistant has made it much easier to understand.");

        // Display video information
        Console.WriteLine($"Title: {video1.Title}");
        Console.WriteLine($"Author: {video1.Author}");
        Console.WriteLine($"Length: {video1.LengthInSeconds} seconds");

        // Display comments
        Console.WriteLine("\nComments:");
        Console.WriteLine($"{comment1.CommenterName}: {comment1.CommentText} (Length: {comment1.CommentLength} characters)");
        Console.WriteLine($"{comment2.CommenterName}: {comment2.CommentText} (Length: {comment2.CommentLength} characters)");

        // Create a video
        Video video2 = new Video("C# Advanced Tutorial", "VS Code Assistant", 900);

        // Create comments for the video
        Comment comment3 = new Comment("Holt", "This advanced tutorial was very helpful.");
        Comment comment4 = new Comment("Toshio", "I learned a lot from this advanced tutorial.");
        // Display video information
        Console.WriteLine($"Title: {video2.Title}");
        Console.WriteLine($"Author: {video2.Author}");
        Console.WriteLine($"Length: {video2.LengthInSeconds} seconds");

        // Display comments
        Console.WriteLine("\nComments:");
        Console.WriteLine($"{comment3.CommenterName}: {comment3.CommentText} (Length: {comment3.CommentLength} characters)");
        Console.WriteLine($"{comment4.CommenterName}: {comment4.CommentText} (Length: {comment4.CommentLength} characters)");

        // Create a video
        Video video3 = new Video("C# Tutorial", "VS Code Assistant", 600);

        // Create comments for the video
        Comment comment5 = new Comment("Holt", "The VS Code Assistant really helps to cut down on entry time.");
        Comment comment6 = new Comment("Toshio", "I have to admit the Assistance is a big help, but I cant help but feel like it takes away from the learning experience.");

        // Display video information
        Console.WriteLine($"Title: {video3.Title}");
        Console.WriteLine($"Author: {video3.Author}");
        Console.WriteLine($"Length: {video3.LengthInSeconds} seconds");

        // Display comments
        Console.WriteLine("\nComments:");
        Console.WriteLine($"{comment5.CommenterName}: {comment5.CommentText} (Length: {comment5.CommentLength} characters)");
        Console.WriteLine($"{comment6.CommenterName}: {comment6.CommentText} (Length: {comment6.CommentLength} characters)");
    }
}