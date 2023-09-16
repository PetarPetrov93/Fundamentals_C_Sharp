using System;

namespace _03_Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double singlePrice = 0;
            double totalPrice = 0;
            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    singlePrice = 8.45;
                    totalPrice = groupSize * singlePrice;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 9.8;
                    totalPrice = groupSize * singlePrice;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 10.46;
                    totalPrice = groupSize * singlePrice;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    singlePrice = 10.9;
                    totalPrice = groupSize * singlePrice;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 15.6;
                    totalPrice = groupSize * singlePrice;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 16;
                    totalPrice = groupSize * singlePrice;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    singlePrice = 15;
                    totalPrice = groupSize * singlePrice;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 20;
                    totalPrice = groupSize * singlePrice;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 22.5;
                    totalPrice = groupSize * singlePrice;
                }
            }
            if (groupType == "Students" && groupSize >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (groupType == "Business" && groupSize >= 100)
            {
                totalPrice -= 10 * singlePrice;
            }
            else if (groupType == "Regular" && groupSize >= 10 && groupSize <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
