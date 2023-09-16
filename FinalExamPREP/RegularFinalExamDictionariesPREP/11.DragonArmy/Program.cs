using System.Diagnostics.Metrics;

namespace _11.DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, SortedDictionary<string, List<int>>> dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(input[2]);
                }

                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(input[3]);
                }

                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(input[4]);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, List<int>>());
                }
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new List<int>());
                }

                dragons[type][name].Clear();
                dragons[type][name].Insert(0,damage); // Can also use .Add here because of the Clear function above. Same goes for the below 2 lines as well
                dragons[type][name].Insert(1, health);
                dragons[type][name].Insert(2,armor);
                
            }

            foreach (var typeOfDragon in dragons)
            {
                Console.Write($"{typeOfDragon.Key}::");

                double averageDamage = 0;
                double averageHealth = 0;
                double averageArmor = 0;

                foreach (var dragonNames in typeOfDragon.Value)
                {
                    averageDamage += dragonNames.Value[0]; 
                    averageHealth += dragonNames.Value[1];
                    averageArmor += dragonNames.Value[2];

                }
                averageDamage /= typeOfDragon.Value.Count;// <-- this should be the count of the dragons in the given TYPE
                averageHealth /= typeOfDragon.Value.Count;
                averageArmor /= typeOfDragon.Value.Count;

                Console.WriteLine($"({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");


                foreach (var dragonName in typeOfDragon.Value)
                {
                    Console.Write($"-{dragonName.Key} -> ");
                        
                    Console.Write($"damage: {dragonName.Value[0]}, health: {dragonName.Value[1]}, armor: {dragonName.Value[2]}");
                    Console.WriteLine();
 
                }
                        
            }
        }
    }
}