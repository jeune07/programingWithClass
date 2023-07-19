using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Winsley", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Winsley", 180);
        video2.AddComment("User3", "Nice work!");
        video2.AddComment("User4", "Could you explain more?");
        video2.AddComment("User5", "This is amazing!");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Winsley", 150);
        video3.AddComment("User6", "Awesome content!");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(" - " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}