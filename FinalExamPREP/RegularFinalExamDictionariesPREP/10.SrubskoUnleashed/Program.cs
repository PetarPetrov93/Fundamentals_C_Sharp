using System.Text.RegularExpressions;

namespace _10.SrubskoUnleashed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Z][a-z]+( [A-Z][a-z]+)?( [A-Z][a-z]+)?) @(?<venue>[A-Z][a-z]+( [A-Z][a-z]+)?( [A-Z][a-z]+)?) (?<price>\d{1,3}) (?<tickets>\d{1,6})$";

            string input;

            Dictionary<string, Dictionary<string, int>> concerts = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "End")
            {
                
                if (!Regex.IsMatch(input, pattern))
                {
                    continue;
                }

                Match match = Regex.Match(input, pattern);

                string[] results = Regex.Split(input, pattern);

                string name = match.Groups["name"].Value;
                string venue = match.Groups["venue"].Value;
                int price = int.Parse(match.Groups["price"].Value);
                int tickets = int.Parse(match.Groups["tickets"].Value);

                int income = price * tickets;

                if (!concerts.ContainsKey(venue))
                {
                    concerts.Add(venue, new Dictionary<string, int>());
                }
                if (!concerts[venue].ContainsKey(name))
                {
                    concerts[venue].Add(name, 0);
                }
                concerts[venue][name] += income;

            }
            foreach (var venue in concerts)
            {
                Console.WriteLine(venue.Key);

                foreach (var singer in venue.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"# {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}