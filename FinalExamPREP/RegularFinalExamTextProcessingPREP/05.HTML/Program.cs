namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string header = Console.ReadLine();
            string content = Console.ReadLine();
            string comment;
            List<string> commentsList = new List<string>();

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                commentsList.Add(comment);
            }
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {header}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            foreach (var com in commentsList)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {com}");
                Console.WriteLine("</div>");
            }
        }
    }
}