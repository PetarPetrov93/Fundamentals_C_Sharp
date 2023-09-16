namespace _03.Articles2._0EX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Articles> list = new List<Articles>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                Articles article = new Articles(input[0], input[1], input[2]);
                list.Add(article);

            }
            Console.WriteLine(string.Join(Environment.NewLine, list)); // One way to print all elements in the list (Don't know how it works but it works)

            //foreach (Articles article in list) ---> This is the same as above but I know exactly how it works (also NOTE that it USES the method in the class)!
            //{
            //    Console.WriteLine(article.ToString());
            //}

            //foreach (Articles currentArticle in list) ---> This way is also very easy and there is NO need to create a method in the class!!
            //{
            //    Console.WriteLine($"{currentArticle.Title} - {currentArticle.Content}: {currentArticle.Author}");
            //}
        }
    }
    public class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}