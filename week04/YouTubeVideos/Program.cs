using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        var video1 = new Video("C# Tutorial for Beginners", "Alice", 600);
        video1.AddComment(new Comment("Bob", "Great tutorial!"));
        video1.AddComment(new Comment("Charlie", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Dana", "Can you make one on LINQ?"));
        videos.Add(video1);

        var video2 = new Video("Understanding OOP", "Eve", 900);
        video2.AddComment(new Comment("Frank", "OOP finally makes sense!"));
        video2.AddComment(new Comment("Grace", "Loved the examples."));
        video2.AddComment(new Comment("Heidi", "Clear and concise."));
        videos.Add(video2);

        var video3 = new Video("Advanced C# Patterns", "Ivan", 1200);
        video3.AddComment(new Comment("Judy", "Mind blown!"));
        video3.AddComment(new Comment("Mallory", "Please do more advanced topics."));
        video3.AddComment(new Comment("Niaj", "Subscribed!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Name}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
