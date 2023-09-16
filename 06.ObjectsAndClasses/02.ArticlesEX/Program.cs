namespace _02.ArticlesEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());
            string cmd;

            for (int i = 0; i < n; i++)
            {
                cmd = Console.ReadLine();
                string[] cmdArr = cmd.Split(": ");
                if (cmdArr[0] == "Edit")
                {
                    string newContent = cmdArr[1];
                    article.Edit(newContent);
                }
                else if (cmdArr[0] == "ChangeAuthor")
                {
                    string newAuthor = cmdArr[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (cmdArr[0] == "Rename")
                {
                    string newTitle = cmdArr[1];
                    article.ChangeTitle(newTitle);
                }
            }
            
            Console.WriteLine(article);
            
        }
    }
    public class Article
    {
        //constructor:
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        //properties:
        public string Title { get; set; }
        
        public string Content {get; set; }

        public string Author { get; set; }

        //methods:
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }


    }
}