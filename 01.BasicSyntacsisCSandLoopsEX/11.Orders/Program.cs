using System.Diagnostics;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double pricePerOrder = 0;

            for (int i = 1; i <= orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                pricePerOrder = ((days * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:f2}");
                totalPrice += pricePerOrder;
                pricePerOrder = 0;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}