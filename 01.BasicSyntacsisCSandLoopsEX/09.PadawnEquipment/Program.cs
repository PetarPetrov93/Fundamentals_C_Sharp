namespace _09.PadawnEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double Price1Lightsaber = double.Parse(Console.ReadLine());
            double Price1Robe = double.Parse(Console.ReadLine());
            double Price1Belt = double.Parse(Console.ReadLine());
            int counter = 0;

            double totalRpbesPrice = Price1Robe * studentsCount;
            double totalLightsaberPrice = Price1Lightsaber * studentsCount + (Price1Lightsaber * Math.Ceiling((studentsCount * 0.1)));
            double totalBeltsPrice = Price1Belt * studentsCount;

            for (int i = 6; i <= studentsCount; i += 6)
            {
                counter++;
            }
            totalBeltsPrice -= counter * Price1Belt;

            if (budget >= totalRpbesPrice+totalLightsaberPrice+totalBeltsPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalBeltsPrice + totalLightsaberPrice + totalRpbesPrice :f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalBeltsPrice+totalLightsaberPrice+totalRpbesPrice) - budget :f2}lv more.");
            }

        }
    }
}