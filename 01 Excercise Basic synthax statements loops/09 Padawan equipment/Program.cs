using System;

namespace _09_Padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfOneLightsaber = double.Parse(Console.ReadLine());
            double priceOfOneRobe = double.Parse(Console.ReadLine());
            double priceOfOneBelt = double.Parse(Console.ReadLine());


            double extra = Math.Ceiling(students + (students * 0.1));   
            int belts = students / 6;
            double totalPrice = (extra * priceOfOneLightsaber) + ((students - belts) * priceOfOneBelt) + (students * priceOfOneRobe);
            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice-money:f2}lv more.");
            }

        }
    }
}
