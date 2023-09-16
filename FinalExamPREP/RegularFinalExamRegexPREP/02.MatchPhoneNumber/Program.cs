using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            
            string[] matchedPhones = matches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}