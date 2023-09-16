using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^|$\%.]*?<(?<product>\w+)>[^|$\%.]*?\|(?<count>\d+)\|[^|$\%.]*?(?<price>\d+(\.\d+)?)\$";

            double totalSiftAmount = 0;
             

            while ((input = Console.ReadLine()) != "end of shift")
            {
                // THIS IS ALSO VALID instead of if(match.Success) :)
                //if (!Regex.IsMatch(input, pattern))
                //{
                //    continue;
                //}
                
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");

                    totalSiftAmount += totalPrice;
                }

                
            }

            Console.WriteLine($"Total income: {totalSiftAmount:f2}");
        }
    }
}