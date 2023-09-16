using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(@|#)(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";

            int mirrorWordsCounter = 0;

            List<string> mirrorWords= new List<string>();

            if (Regex.IsMatch(text, pattern))
            {
                MatchCollection matches = Regex.Matches(text, pattern);

                foreach (Match wordpair in matches)
                {
                    string firstWord = wordpair.Groups["firstWord"].Value;
                    string secondWord = wordpair.Groups["secondWord"].Value;
                                  
                    char[] secondWordCharArr = secondWord.ToCharArray();
                    Array.Reverse(secondWordCharArr);
                    string reversedSecondWord = string.Join("", secondWordCharArr);

                    if (firstWord == reversedSecondWord)
                    {
                        mirrorWordsCounter++;
                        mirrorWords.Add(firstWord + " <=> " + secondWord);
                    }
                }
                if (mirrorWordsCounter == 0)
                {
                    Console.WriteLine($"{matches.Count} word pairs found!");
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine($"{matches.Count} word pairs found!");
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
                
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            
        }
    }
}