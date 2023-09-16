namespace _05.ShortWordsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            char[] separators = { ' ', ',', '.', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '\\', '!', '?' };

            List<string> words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length < 5).Distinct().ToList();
            words.Sort();
            Console.WriteLine(string.Join(", ", words));
        }
    }
}