using System;
using System.Reflection.PortableExecutable;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Spend the day with me and my sisters", "Ha Sisters", 700);
        Video video2 = new Video("7 reasons why you should fast today!!", "Christ Community", 500);
        Video video3 = new Video("Learn how C# in 3 days", "Wizzard", 900);


        video1.AddComment(new Comment("Yuni" , "I love your videos so much"));
        video1.AddComment(new Comment("KYOnG" , "You Guys are so funny hahaha"));
        video1.AddComment(new Comment("Pinky" , "My favorit sister!"));

        video2.AddComment(new Comment("James" , "How do people even come up with these things?"));
        video2.AddComment(new Comment("Peter" , "I believe this is a sign, stay blessed pastor Rick"));
        video2.AddComment(new Comment("Sarah" , "God is great"));

        video3.AddComment(new Comment("Tshedi","Thnk you so much for this"));
        video3.AddComment(new Comment("Rick","Can't believe i'm watching this for free. You're amazing man"));
        video3.AddComment(new Comment("Sipho","Straight to the point, love it."));



        List<Video>videos = new List<Video>{video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();}

    }
}