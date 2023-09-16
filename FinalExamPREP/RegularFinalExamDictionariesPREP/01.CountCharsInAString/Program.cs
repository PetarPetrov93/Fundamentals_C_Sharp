namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    if (!chars.ContainsKey(word[i]))
                    {
                        chars.Add(word[i], 0);
                    }
                    chars[word[i]]++;
                }
                
            }
            //chars.OrderBy(x => x.Value); -> this is how you sort it by value however not needed in this task

            foreach (var c in chars)
            {
                Console.WriteLine(c.Key + " -> " + c.Value);
            }
        }
    }
}