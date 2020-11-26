using System.Collections.Generic;

namespace tweet_sample
{
    public class TweetData
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
    public class TweetContainer
    {
        private int Counter = 0;
        public List<TweetData> Tweets { get; set; } = new List<TweetData>();
        public void AddTweet(string s)
        {
            Tweets.Add(new TweetData { Id = ++Counter, Content = s });
        }
    }
}
