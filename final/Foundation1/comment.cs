using System;

namespace YouTubeTracker
{
    public class Comment
    {
        public string commenterName;
        public string text;

        public Comment(string commenterName, string text)
        {
            this.commenterName = commenterName;
            this.text = text;
        }
    }
}
