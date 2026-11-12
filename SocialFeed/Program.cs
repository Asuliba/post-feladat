namespace SocialFeed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TextPost post = new TextPost("A", "Ez rövid bejegyzés c:");
            TextPost post2 = new TextPost("A", "Ez egy nagyon nagyon nagyon nagyon nagyon hosszú bejegyzés c:");

            Console.WriteLine(post.Like());
            Console.WriteLine(post.Like());
            Console.WriteLine(post.Like());

            Console.WriteLine(post.GetDescription());
            Console.WriteLine(post2.GetDescription());

            Console.WriteLine(post.Score());
            Console.WriteLine(post2.Score());

            ImagePost img1 = new ImagePost("C", 2);
            for(int i = 0;i < 5; i++)
            {
                img1.Like();
            }
            Console.WriteLine(img1.Score());
            Console.WriteLine(img1.GetDescription());
            ImagePost img2 = new ImagePost("D", 3);
            Console.WriteLine(img2.GetDescription());

            PollPost poll1 = new PollPost("A");

            poll1.Like();
            poll1.Like();
            for(int i = 0; i < 4; i++)
            {
                poll1.Vote();
            }
            poll1.Close();
            Console.WriteLine(poll1.Like());
            Console.WriteLine(poll1.Vote());
            Console.WriteLine(poll1.GetDescription());
            Console.WriteLine(poll1.Score());
        }
    }
}
