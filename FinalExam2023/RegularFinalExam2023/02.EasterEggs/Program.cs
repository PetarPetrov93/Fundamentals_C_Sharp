using System.Text.RegularExpressions;

namespace _02.EasterEggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"[@#]+(?<color>[a-z]{3,})[@#]+(?<separators>[\!\@\#\$\%\^\&\*\(\)_\+\-\=\<\>\'\ \|\:\;\/]*)\/+(?<quantity>[0-9]+)\/+";

            MatchCollection eggs = Regex.Matches(text, pattern);

            foreach (Match egg in eggs)
            {
                string color = egg.Groups["color"].Value;
                string quantity = egg.Groups["quantity"].Value;

                Console.WriteLine($"You found {quantity} {color} eggs!");
            }
        }
    }
}