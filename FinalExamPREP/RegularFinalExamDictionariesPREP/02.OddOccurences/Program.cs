namespace _02.OddOccurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Dictionary<string, int> wordsOccurences = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string currentWordToLower = word.ToLower();
                if (!wordsOccurences.ContainsKey(currentWordToLower))
                {
                    wordsOccurences.Add(currentWordToLower, 0);
                }
                wordsOccurences[currentWordToLower]++;
            }
            foreach (var item in wordsOccurences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}