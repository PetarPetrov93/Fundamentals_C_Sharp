namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double sum = 0;
            double businessSinglePrice = 0;  // need that for the last calculation, if I'd reversed the logic it wouldn't be needed

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    sum = groupCount * 8.45;
                }
                else if (groupType == "Business")
                {
                    businessSinglePrice = 10.9;
                    sum = groupCount * businessSinglePrice;
                }
                else if (groupType == "Regular")
                {
                    sum = groupCount * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    sum = groupCount * 9.8;
                }
                else if (groupType == "Business")
                {
                    businessSinglePrice = 15.6;
                    sum = groupCount * businessSinglePrice;
                }
                else if (groupType == "Regular")
                {
                    sum = groupCount * 20;
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    sum = groupCount * 10.46;
                }
                else if (groupType == "Business")
                {
                    businessSinglePrice = 16;
                    sum = groupCount * businessSinglePrice;
                }
                else if (groupType == "Regular")
                {
                    sum = groupCount * 22.5;
                }
            }
            if (groupType == "Students" && groupCount >= 30)
            {
                sum -= sum * 0.15;
            }
            if (groupType == "Business" && groupCount >= 100)
            {
                sum -= businessSinglePrice * 10;
            }
            if (groupType == "Regular" && groupCount >= 10 && groupCount <= 20)
            {
                sum -= sum * 0.05;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}