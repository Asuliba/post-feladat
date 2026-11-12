using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialFeed
{
    public class ImagePost : Post
    {
        private int _imageCount;
        
        public int ImageCount { get { return _imageCount; } set
            {
                if(value > 10 || value < 1)
                {
                    _imageCount = 1;
                }
                else
                {
                    _imageCount = value;
                }
            } }

        public ImagePost(string author, int imageCount) : base(author)
        {
            ImageCount = imageCount;
        }

        public override int Score()
        {
            return Likes * 2;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + $"{_imageCount} kép";
        }
    }
}
