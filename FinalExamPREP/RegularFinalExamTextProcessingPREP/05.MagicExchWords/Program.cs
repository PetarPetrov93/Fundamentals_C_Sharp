namespace _05.MagicExchWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CANT BE BOTHERED, HONESTLY!!!!
            
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            bool IsExchangable = IsItExchangable(word1, word2);
            
        }
        static bool IsItExchangable(string word1, string word2)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();

            if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    if (!map.ContainsKey(word2[i]))
                    {
                        map.Add(word2[i], '\0');
                    }
                }
            }
        }
    }
}