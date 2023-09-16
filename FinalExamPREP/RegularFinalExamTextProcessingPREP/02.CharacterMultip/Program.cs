namespace _02.CharacterMultip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];

            Console.WriteLine(Sum(word1, word2));
        }
        static int Sum (string word1, string word2)
        {
            int sum = 0;

            int shorterWord = Math.Min(word1.Length, word2.Length);

            for (int i = 0; i < shorterWord; i++)
            {
                sum += word1[i] * word2[i];
            }

            if (word1.Length < word2.Length)
            {
                for (int i = shorterWord; i < word2.Length; i++)
                {
                    sum += word2[i];
                }
            }
            else if (word2.Length < word1.Length)
            {
                for (int i = shorterWord; i < word1.Length; i++)
                {
                    sum += word1[i];
                }
            }

            return sum;
        }
    }
}