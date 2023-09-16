namespace _01.CountCharInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Dictionary<char, int> letterOccCount = new Dictionary<char, int>();

            foreach (char letter in word)
            {
                if (!letterOccCount.ContainsKey(letter))
                {
                    letterOccCount.Add(letter, 0);
                }
                if (letter != ' ')
                {
                    letterOccCount[letter]++;
                }
                
            }


            // I preffer the code in the .net7 solution!
            foreach (KeyValuePair<char, int> letter in letterOccCount.Where(x => x.Key != ' '))
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");

            }
        }
    }
}