namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, string> products = new Dictionary<string, string>();

            while (input[0] != "buy")
            {
                
                if (!products.ContainsKey(input[0]))
                {
                    products.Add(input[0], string.Join(" ", input[1], input[2]) );
                    
                }
                else 
                {
                    
                    ExistingProduct(products, input[0], input[2], input[1]);

                }
                  
                input = Console.ReadLine().Split();
            }

            foreach (var (key, value) in products) 
            {
                products[key] = CaluclatePriceByQuantity(value);
                //products[item.Key] = CaluclatePriceByQuantity(item.Value); - can also be done this way if var is "item"
            }

            foreach(var (key, value) in products) 
            {
                Console.WriteLine($"{key} -> {value}");
            }

        }
        static void ExistingProduct(Dictionary<string, string> productListDic,string product, string newQuantityToAdd, string newPrice)
        {

            string oldQuantityAndPrice = string.Empty;

            foreach (var item in productListDic.Where(x => x.Key == product)) // when working with dictionaries the "var" represents a "KeyValuePair"
            {
                oldQuantityAndPrice = item.Value;
            }
            string[] oldQantityAndPriceArr = oldQuantityAndPrice.Split();

            int oldQantity = int.Parse(oldQantityAndPriceArr[1]);
            int addedQuantity = int.Parse(newQuantityToAdd) + oldQantity;

            double updatedPrice = double.Parse(newPrice);
            
            string newValues = string.Join(" ", newPrice.ToString(), addedQuantity.ToString());

            productListDic[product] = newValues;

        }
        static string CaluclatePriceByQuantity (string totalPrice) 
        {

            string[]totalPriceArr = totalPrice.Split();
            
            double finalPrice = double.Parse(totalPriceArr[0]) * int.Parse(totalPriceArr[1]);

            return finalPrice.ToString("F2");


        }
    }
}