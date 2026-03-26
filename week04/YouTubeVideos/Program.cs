using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video(300, "How to Steal Baby Oil from P. Diddy", "Dwayne The Rock Johnson");
        video1._comments.Add(new Comment("General Public", "Why does he have so much baby oil?!"));
        video1._comments.Add(new Comment("Baby", "Why do you grown men need baby oil! We need it!"));
        video1._comments.Add(new Comment("Diddy", "I knew it was you, Dwayne!"));

        videos.Add(video1);

        Video video2 = new Video(600, "How to Booby Trap Your House", "P. Diddy");
        video2._comments.Add(new Comment("General Public", "I came from the How to Steal Baby Oil from P. Diddy video, and I with the baby. Why y'all need that baby oil?"));
        video2._comments.Add(new Comment("Baby", "Wouldn't Dwayne just watch this video before stealing the baby oil?"));
        video2._comments.Add(new Comment("Dwayne", "I wish I thought of this before trying to steal the baby oil again..."));
        video2._comments.Add(new Comment("General Public", "Wait, again?! Why do you keep stealing from Diddy? Just go to Walmart and buy some!"));

        videos.Add(video2);

        Video video3 = new Video(900, "Dwayne The Rock vs P. Diddy in the Walmart Baby Isle", "Baby");
        video3._comments.Add(new Comment("General Public", "This was not on my 2026 bingo card..."));
        video3._comments.Add(new Comment("Diddy", "If you hadn't covered yourself with all that oil, your booty would have been mine!"));
        video3._comments.Add(new Comment("Dwayne", "You're just mad you slipped on your own baby oil."));
        video3._comments.Add(new Comment("Donald", "I could have sold you gentlemen baby oil. I have the best babies for oil in the world. I've been told this many many times by many smart people. Believe me."));

        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}