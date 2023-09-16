using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(#|\|)(?<itemName>[a-zA-Z ]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";

            int totalCalories = 0;

            if (Regex.IsMatch(text, pattern))
            {
                MatchCollection matches = Regex.Matches(text, pattern);

                foreach (Match match in matches)
                {
                    int calories = int.Parse(match.Groups["calories"].Value);
                    totalCalories += calories;
                }

                int days = totalCalories / 2000;
                Console.WriteLine($"You have food to last you for: {days} days!");

                foreach (Match match in matches)
                {
                    string food = match.Groups["itemName"].Value;
                    string bestBefore = match.Groups["expirationDate"].Value;
                    string calories = match.Groups["calories"].Value;

                    Console.WriteLine($"Item: {food}, Best before: {bestBefore}, Nutrition: {calories}");
                }
            }
            else
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
            
        }
    }
}