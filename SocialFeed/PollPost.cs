using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class PollPost : Post
    {
        private int _votes;
        private bool _isClosed;

        public int Votes
        {
            get { return _votes; }
        }

        public bool IsClosed
        {
            get { return _isClosed; }
        }

        public PollPost(string author): base(author)
        {
            _isClosed = false;
            _votes = 0;
        }

        public bool Vote()
        {
            if (_isClosed)
            {
                return false;
            }
            _votes++;
            return true;
        }

        public void Close()
        {
            _isClosed = true;
        }
        public override int Score()
        {
            return Likes + _votes;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + $", {_votes} szavazat {(IsClosed ? "zárva" : "")}";
        }
        public override bool Like()
        {
            if (_isClosed)
            {
                return false;
            }
            return base.Like();
        }
    }
}
