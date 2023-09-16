namespace _08.UpgradedMatcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string cmd;

            while ((cmd = Console.ReadLine()) != "done")
            {
                string[] cmdArr = cmd.Split();
                int index = Array.IndexOf(products, cmdArr[0]);
                long requestedQuantity = long.Parse(cmdArr[1]);

                if (index >= quantity.Length)
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
                if (quantity[index] - requestedQuantity >=0)
                {
                    decimal totalPrice = price[index] * requestedQuantity;

                    quantity[index] -= requestedQuantity;

                    Console.WriteLine($"{products[index]} x {requestedQuantity} costs {totalPrice:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {products[index]}");
                }
            }
        }
    }
}