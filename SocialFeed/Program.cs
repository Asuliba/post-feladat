namespace SocialFeed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TextPost post = new TextPost("A", "Ez egy rövid bejegyzés c:");
            TextPost post2 = new TextPost("A", "Ez egy nagyon nagyon nagyon nagyon nagyon hosszú bejegyzés c:");

            Console.WriteLine(post.Like());
            Console.WriteLine(post.Like());
            Console.WriteLine(post.Like());

            Console.WriteLine(post.GetDescription());
            Console.WriteLine(post2.GetDescription());

            Console.WriteLine(post.Score());
            Console.WriteLine(post2.Score());
        }
    }
}
