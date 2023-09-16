namespace _06.MiddleCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomWord = Console.ReadLine();
            Console.WriteLine(MiddleLetter(randomWord));
        }
        static string MiddleLetter(string word)
        {
            
            if (word.Length % 2 != 0)
            {
                char midlLetter = word[word.Length / 2];
                return midlLetter.ToString();
            }
            else
            {
                char leftMidLetter = word[word.Length / 2 - 1];
                char rightMidLetter = word[word.Length / 2];

                return leftMidLetter.ToString() + rightMidLetter.ToString();
            }
        }
    }
}