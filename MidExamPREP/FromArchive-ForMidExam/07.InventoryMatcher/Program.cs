namespace _07.InventoryMatcher
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
                int indexOfTheProduct = Array.IndexOf(products, cmd);

                Console.WriteLine($"{products[indexOfTheProduct]} costs: {price[indexOfTheProduct]}; Available quantity: {quantity[indexOfTheProduct]}");
            }
        }
    }
}