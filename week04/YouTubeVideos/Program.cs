using System;
using System.Collections.Generic;

// Comment class
class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

// Video class
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# Basics", "TechChannel", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot!"));

        Video video2 = new Video("Gaming Highlights", "ProGamer", 900);
        video2.AddComment(new Comment("Dave", "Awesome gameplay!"));
        video2.AddComment(new Comment("Eve", "That was intense!"));
        video2.AddComment(new Comment("Frank", "Loved this video!"));

        Video video3 = new Video("Travel Vlog Bolivia", "Explorer", 1200);
        video3.AddComment(new Comment("Grace", "Beautiful places!"));
        video3.AddComment(new Comment("Hank", "I want to visit!"));
        video3.AddComment(new Comment("Ivy", "Amazing content!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine("-----------------------------------");
        }
    }
}