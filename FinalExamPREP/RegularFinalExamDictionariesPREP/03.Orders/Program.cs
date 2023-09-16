namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, List<double>> productQuantityAndPrice = new Dictionary<string, List<double>>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputArr = input.Split();

                string productName = inputArr[0];
                double currentPrice = double.Parse(inputArr[1]);
                double currentQuantity = double.Parse(inputArr[2]);

                if (!productQuantityAndPrice.ContainsKey(productName))
                {
                    productQuantityAndPrice.Add(productName, new List<double>());
                    productQuantityAndPrice[productName].Add(currentPrice);
                    productQuantityAndPrice[productName].Add(currentQuantity);

                }
                else
                {
                    foreach (var (key, listAsValue) in productQuantityAndPrice.Where(key => key.Key == productName))
                    {
                        if (listAsValue[0] != currentPrice)
                        {
                            listAsValue[0] = currentPrice;
                        }
                        listAsValue[1] += currentQuantity;
                    }
                }
                
            }
            foreach (var (key, listAsValue) in productQuantityAndPrice)
            {
                double totalPriceForCurrProduct = listAsValue[0] * listAsValue[1];
                Console.WriteLine($"{key} -> {totalPriceForCurrProduct:f2}");
            }
        }
    }
}