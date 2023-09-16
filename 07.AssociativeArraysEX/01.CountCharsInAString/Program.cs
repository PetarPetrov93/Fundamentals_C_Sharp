namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // .net7 - woeks like a charm!

            string word = Console.ReadLine();

            Dictionary<char, int> letterOccCount = new Dictionary<char, int>();

            foreach (char letter in word)
            {
                if (!letterOccCount.ContainsKey(letter))
                {
                    letterOccCount.Add(letter, 0);
                }
                letterOccCount[letter]++;
            }
            foreach (var (key, value) in letterOccCount.Where(x => x.Key != ' '))
            {
                Console.WriteLine($"{key} -> {value}");
            }

        }
    }
}