namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalWordsGiven = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionaryWithSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < totalWordsGiven; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionaryWithSynonyms.ContainsKey(word))
                {
                    dictionaryWithSynonyms.Add(word, new List<string>());
                }
                dictionaryWithSynonyms[word].Add(synonym);
            }
            foreach (var (key, value) in dictionaryWithSynonyms)
            {
                Console.Write(key + " - ");
                Console.WriteLine(string.Join(", ", value));
            }
        }
    }
}