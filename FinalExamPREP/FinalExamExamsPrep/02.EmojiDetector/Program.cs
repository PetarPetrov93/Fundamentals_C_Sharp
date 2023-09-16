using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string digitsPattern = "\\d";

            MatchCollection coolThresholdMatches = Regex.Matches(text, digitsPattern);

            int coolThreshold = 1;

            if (Regex.IsMatch(text, digitsPattern))
            {
                foreach (var number in coolThresholdMatches)
                {
                                  
                    coolThreshold *= int.Parse(number.ToString());
                }

                Console.WriteLine($"Cool threshold: {coolThreshold}");
            }
            else
            {
                coolThreshold = 0;
                Console.WriteLine($"Cool threshold: {coolThreshold}");
            }
            
            string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";

            MatchCollection emojies = Regex.Matches(text, pattern);
            int totalEmojies = emojies.Count;

            Console.WriteLine($"{totalEmojies} emojis found in the text. The cool ones are:");

            List<string> coolEmojies = new List<string>();
            int emojiASCIISum = 0;

            foreach (var emoji in emojies)
            {
                foreach (var letter in emoji.ToString())
                {
                    if (char.IsLetter(letter))
                    {
                        emojiASCIISum += letter;
                    }
                    
                }
                if (emojiASCIISum >= coolThreshold)
                {
                    coolEmojies.Add(emoji.ToString());
                }
                emojiASCIISum = 0;
            }
            
            foreach (string coolEmoji in coolEmojies)
            {
                Console.WriteLine(coolEmoji);
            }
        }
        
    }
}