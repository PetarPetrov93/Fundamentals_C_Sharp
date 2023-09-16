using System.Diagnostics.Metrics;

namespace _01.Insert_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-vo vadim energiqta, posle smqtame vodata i pribavqme energiqta (5%) sushtoto e i s hranata (10%)

            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

            double totalWater = numberOfDays * numberOfPlayers * waterPerDayForOnePerson;
            double totalFood = numberOfDays * numberOfPlayers * foodPerDayForOnePerson;

            
            for (int i = 1; i <= numberOfDays; i++)
            {
                
                double energyLostPerDay = double.Parse(Console.ReadLine());
                groupsEnergy = groupsEnergy - energyLostPerDay;

                if (groupsEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:f2} food and {totalWater:f2} water.");
                    return;
                }
                else
                {
                    
                    if (i % 2 == 0)
                    {
                        groupsEnergy = groupsEnergy + (groupsEnergy * 0.05);
                        totalWater = totalWater - (totalWater * 0.3);
                        
                    } 

                    if (i % 3 == 0)
                    {
                        totalFood = totalFood - (totalFood / numberOfPlayers);
                        groupsEnergy = groupsEnergy + (groupsEnergy * 0.1);

                    }
                }
            }
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy :f2} energy!");

        }
    }
}