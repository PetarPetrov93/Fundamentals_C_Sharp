using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1";

            MatchCollection destinations = Regex.Matches(input, pattern);

            List<string> validDestinations = new List<string>();

            int points = 0;

            foreach (Match destination in destinations)
            {
                string destinationName = destination.Groups["destination"].Value;

                validDestinations.Add(destinationName);

                points += destinationName.Length;
            }
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", validDestinations));
            Console.WriteLine($"Travel Points: {points}");

        }
    }
}