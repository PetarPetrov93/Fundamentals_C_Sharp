using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A valid full name has the following characteristics:
                o It consists of two words.
                o Each word starts with a capital letter.
                o After the first letter, it only contains lowercase letters afterward.
                o Each of the two words should be at least two letters long.
                o The two words are separated by a single space.
             */
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string name = Console.ReadLine();

            MatchCollection nameMatches = Regex.Matches(name, pattern);

            foreach (Match matchingName in nameMatches)
            {
                Console.Write(matchingName.Value + " ");
            }
        }
    }
}