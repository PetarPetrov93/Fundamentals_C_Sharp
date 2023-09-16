using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int barcodesQuantity = int.Parse(Console.ReadLine());
            string currentBarcode = string.Empty;
            string pattern = @"@#+(?<barcode>[A-Z][a-zA-Z0-9]{4,}[A-Z])@#+";

            for (int i = 1; i <= barcodesQuantity; i++)
            {
                currentBarcode = Console.ReadLine();

                if (Regex.IsMatch(currentBarcode, pattern))
                {
                    if (currentBarcode.Any(x => char.IsDigit(x)))
                    {
                        StringBuilder group = new StringBuilder();
                        foreach (char symbol in currentBarcode.Where(x => char.IsDigit(x)))
                        {
                            group.Append(symbol);
                        }
                        Console.WriteLine($"Product group: {group}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}