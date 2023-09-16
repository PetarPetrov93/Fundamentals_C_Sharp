namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string word1 = words[0];
            string word2 = words[1];
            
            Console.WriteLine(SumOfChars(word1, word2));
        }
        static int SumOfChars(string word1, string word2)
        {
            string longerWord = string.Empty;
            if (word1.Length >= word2.Length)
            {
                longerWord = word1;
            }
            else
            {
                longerWord = word2;
            }

            int shorterWordLength = Math.Min(word1.Length, word2.Length);
            int longerWordLength = Math.Max(word1.Length, word2.Length);
            int sum = 0;

            for (int i = 0; i < shorterWordLength; i++)
            {
                sum += word1[i] * word2[i];
            }

            for (int i = shorterWordLength; i < longerWordLength; i++)
            {
                sum += longerWord[i];
            }

            return sum;
        }
    }
}