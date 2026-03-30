using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        Video video1 = new Video("Interstellar", "Christopher Nolan", 169);
        Comment comment1 = new Comment("Cooper", "Inspiring.");
        Comment comment2 = new Comment("Murph", "Emotional story.");
        Comment comment3 = new Comment("Dr. Brand", "The science is fascinating.");
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        Video video2 = new Video("The Martian", "Ridley Scott", 151);
        Comment comment4 = new Comment("Mark Watney", "So many potatoes.");
        Comment comment5 = new Comment("Rich Purnell", "Astrophysics is awesome.");
        Comment comment6 = new Comment("Andy Weir", "The book was better.");
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        Video video3 = new Video("Project Hail Mary", "Phil Lord, Chris Miller", 156);
        Comment comment7 = new Comment("Ryland Grace", "What an adventure!");
        Comment comment8 = new Comment("Rocky", "Amaze! Amaze! Amaze!");
        Comment comment9 = new Comment("Andy Weir", "The book was still better.");
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} minutes");
            Console.WriteLine($"Number of comments: {video.NumComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}