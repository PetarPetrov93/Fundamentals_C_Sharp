using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder sequence = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sequence.Append(word);
                }
            }
            Console.WriteLine(sequence.ToString());
        }
    }
}