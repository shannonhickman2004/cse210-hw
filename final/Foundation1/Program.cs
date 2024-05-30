using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        var video1 = new Video("Learning to Program", "Caroline Smith", 100);
        var video2 = new Video("Introduction to C#", "Stephanie Smith", 500);
        var video3 = new Video("Introduction to Python", "Hillary Smith", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Karina", "Great video!"));
        video1.AddComment(new Comment("Krew", "This is pretty basic"));
        video1.AddComment(new Comment("Rexley", "I learned a lot."));

        // Add comments to video2
        video2.AddComment(new Comment("Reagan", "Thanks for the walk through"));
        video2.AddComment(new Comment("Crystal", "Could you follow this up with the next advanced step"));
        video2.AddComment(new Comment("Bryson", "Thanks for this explanation"));

        // Add comments to video3
        video3.AddComment(new Comment("Karlie", "This was so helpful"));
        video3.AddComment(new Comment("Laura", "A little tricky for me."));
        video3.AddComment(new Comment("Charles", "I love the examples."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Loop through and display each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberofComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
