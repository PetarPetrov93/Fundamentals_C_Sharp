namespace _04.SplitByWordCasing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ' ', '.', ';', ':', '!', '(', ')', '\'', '\\', '/', '[', ']' };
            List<string> text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowercaseOnly = new List<string>();
            List<string> uppercaseOnly = new List<string>();
            List<string> mixedLetters = new List<string>();

            foreach (string word in text)
            {
                if (word.Count(x => char.IsLower(x)) == word.Length)
                {
                    lowercaseOnly.Add(word);
                }
                else if (word.Count(x => char.IsUpper(x)) == word.Length)
                {
                    uppercaseOnly.Add(word);
                }
                else
                {
                    mixedLetters.Add(word);
                }
                
            }
            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowercaseOnly));

            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedLetters));

            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", uppercaseOnly));



        }
    }
}