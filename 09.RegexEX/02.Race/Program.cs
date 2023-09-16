using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            string namePattern = @"(?<letters>[A-Za-z]+)";
            string distancePattern = @"(?<distanvce>\d)";
            StringBuilder name = new StringBuilder();
            int distance = 0;

            Dictionary<string, int> winners = new Dictionary<string, int>();

            string input;

            
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection nameMatches = Regex.Matches(input, namePattern);
               
                foreach (Match letter in nameMatches)
                {
                   name.Append(letter.Value);
                }

                if (!names.Contains(name.ToString()))
                {
                    name.Clear();
                    continue;
                }

                MatchCollection distanceMatch = Regex.Matches(input, distancePattern);

                foreach (Match digit in distanceMatch)
                {
                    distance += int.Parse(digit.ToString());
                }

                if (!winners.ContainsKey(name.ToString()))
                {
                    winners.Add(name.ToString(), 0);
                }

                winners[name.ToString()] += distance;

                distance = 0;
                name.Clear();

            }

            Dictionary<string, int> ordered = winners.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
   

            List<string> topThree = new List<string>();
            int counter = 0;

            foreach (var item in ordered)
            {
                topThree.Add(item.Key);
                counter++;
                if (counter == 3)
                {
                    break;
                }
            }
            
            Console.WriteLine($"1st place: {topThree[0]}");
            Console.WriteLine($"2nd place: {topThree[1]}");
            Console.WriteLine($"3rd place: {topThree[2]}");

        }
        
    }
}