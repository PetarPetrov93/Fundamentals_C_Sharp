using System;

namespace _07_Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalMoney = 0;
            
            while (input != "Start")
            {
                double money = double.Parse(input);
                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    totalMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine();


            }
            
            string product = Console.ReadLine();
            double productPrice = 0;
           
            while (product != "End")
            {

                if (product == "Nuts")
                {
                    productPrice = 2;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (product == "Coke")
                {
                    productPrice = 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    product = Console.ReadLine();
                    continue;
                }
                
                if (totalMoney >= productPrice)
                {
                    totalMoney -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (totalMoney < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
