using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public abstract class Post : IReportable
    {
        private string _author;
        private int _likes;
        private int _reports;
        private List<Comment> _comments;
        public string Author { get { return _author; } set { _author = value; } }
        public int Likes { get { return _likes; } }

        public List<Comment> Comments { get { return _comments; } }

        public Post(string author)
        {
            _author = author;
            _likes = 0;
            _comments = new List<Comment>();
        }

        public virtual bool Like()
        {
            _likes++;
            return true;
        }

        public virtual string GetDescription()
        {
            return $"{_author}, {_likes} kedvelés {(_comments.Count > 0 ? $", {_comments.Count} hozzászólás" : "")}";
        }
        public void Report()
        {
            _reports++;
        }

        public int ReportCount()
        {
            return _reports;
        }

        public Comment AddComment(string author, string text)
        {
            Comment comment = new Comment(author, text, this);
            _comments.Add(comment);
            return comment;
        }
    }
}
