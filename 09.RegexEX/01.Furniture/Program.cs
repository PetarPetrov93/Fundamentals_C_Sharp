using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            List<string> purchases = new List<string>();
            decimal totalMoneySpent = 0;

            string input;
            while ((input = Console.ReadLine())!= "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);

                if (furnitureInfo.Success)
                {
                    string furnitureName = furnitureInfo.Groups["name"].Value;
                    decimal furnPrice = decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int furnQuantity = int.Parse(furnitureInfo.Groups["quantity"].Value);

                    purchases.Add(furnitureName);
                    totalMoneySpent += (furnPrice * furnQuantity);
                }
            }

            PrintOutput(purchases, totalMoneySpent);
        }
        static void PrintOutput (List<string> purchases, decimal moneySpent)
        {
            Console.WriteLine("Bought furniture:");

            foreach (string furnName in purchases)
            {
                Console.WriteLine(furnName);
            }

            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }
        
    }
}