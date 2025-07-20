using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create Video 1
            Video video1 = new Video("How to Bake a Cake", "Chef Anna", 420);
            video1.AddComment(new Comment("Liam", "This recipe is perfect!"));
            video1.AddComment(new Comment("Emma", "Tried it and loved it."));
            video1.AddComment(new Comment("Noah", "Can I use almond flour instead?"));
            videos.Add(video1);

            // Create Video 2
            Video video2 = new Video("Guitar Lesson #1", "John Musician", 900);
            video2.AddComment(new Comment("Olivia", "Very helpful, thanks!"));
            video2.AddComment(new Comment("William", "Can you do a blues lesson next?"));
            video2.AddComment(new Comment("Sophia", "Great for beginners."));
            videos.Add(video2);

            // Create Video 3
            Video video3 = new Video("Space Documentary", "AstroWorld", 1800);
            video3.AddComment(new Comment("James", "Mind-blowing facts!"));
            video3.AddComment(new Comment("Isabella", "Loved the visuals."));
            video3.AddComment(new Comment("Benjamin", "Can you do one on black holes?"));
            videos.Add(video3);

            // Create Video 4
            Video video4 = new Video("Workout Routine", "FitLife", 600);
            video4.AddComment(new Comment("Charlotte", "This was intense!"));
            video4.AddComment(new Comment("Mason", "Exactly what I needed."));
            video4.AddComment(new Comment("Amelia", "Adding this to my morning routine."));
            videos.Add(video4);

            // Display all videos
            foreach (Video video in videos)
            {
                Console.WriteLine("Title: " + video.Title);
                Console.WriteLine("Author: " + video.Author);
                Console.WriteLine("Length: " + video.LengthInSeconds + " seconds");
                Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($"  - {comment.CommenterName}: {comment.Text}");
                }

                Console.WriteLine(new string('-', 40));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}