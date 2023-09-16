namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            double inputToCoins = 0;
            double coinsTotal = 0;

            while ((input = Console.ReadLine()) != "Start")
            {
                inputToCoins = double.Parse(input);
                
                if (inputToCoins != 0.1 && inputToCoins != 0.2 && inputToCoins != 0.5 && inputToCoins != 1 && inputToCoins != 2)
                {
                    Console.WriteLine($"Cannot accept {inputToCoins}");
                    continue;
                }
                coinsTotal += inputToCoins;
                
            }
            string purchase = string.Empty;
            double currentPrice = 0;

            while ((purchase = Console.ReadLine()) != "End") 
            {
                if (purchase == "Nuts")
                {
                    currentPrice = 2;
                }
                else if (purchase == "Water")
                {
                    currentPrice = 0.7;
                }
                else if (purchase == "Crisps")
                {
                    currentPrice = 1.5;
                }
                else if (purchase == "Soda")
                {
                    currentPrice = 0.8;
                }
                else if (purchase == "Coke")
                {
                    currentPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                if (currentPrice <= coinsTotal)
                {
                    coinsTotal -= currentPrice;
                    string toLower = purchase.ToLower();
                    Console.WriteLine($"Purchased {toLower}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enugh money");
                }
            }
            Console.WriteLine($"Change: {coinsTotal:f2}");
        }
    }
}