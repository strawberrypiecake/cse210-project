using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    public class Video
    {
        public string title;
        public string author;
        public int lengthInSeconds;
        public List<Comment> comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            this.title = title;
            this.author = author;
            this.lengthInSeconds = lengthInSeconds;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }
    }
}
