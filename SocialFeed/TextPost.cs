using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SocialFeed
{
    public class TextPost : Post
    {
        private string _text;

        public string Text { get { return _text; } set { _text = value; } }

        public TextPost(string author, string text) :base(author)
        {
            _text = text;
        }

        public virtual int Score()
        {
            return Likes;
        }

        public override string GetDescription()
        {
            if(_text.Length > 20)
            {
                return $"{base.GetDescription()} : {_text.Substring(0,20)} ...";
            }
            return $"{base.GetDescription()} : {_text}";

        }
    }
}
