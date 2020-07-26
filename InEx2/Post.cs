using System;

namespace InEx2
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private DateTime _dateTime { get; set; }

        private int _vote = 0;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            _dateTime = DateTime.Now;
        }

        public void VoteUp ()
        {
            _vote++;
        }

        public void VoteDown ()
        {
            if (_vote < 0)
            {
                Console.WriteLine("You cannot vote down from Zero");
                return;
            }
            else if (_vote > 0)
            {
                _vote--;
            }

        }

        public int Votes ()
        {
            return _vote;
        }
    }
}
