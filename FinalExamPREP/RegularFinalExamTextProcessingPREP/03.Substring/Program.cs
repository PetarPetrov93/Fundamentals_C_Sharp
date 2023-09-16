namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string sequence = Console.ReadLine();

            while (sequence.Contains(wordToRemove))
            {
                int indexOfWordToRemove = sequence.IndexOf(wordToRemove);
                sequence = sequence.Remove(indexOfWordToRemove, wordToRemove.Length);
            }
            Console.WriteLine(sequence);
        }
    }
}