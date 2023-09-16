namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (string word in words.Where(x => x.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}