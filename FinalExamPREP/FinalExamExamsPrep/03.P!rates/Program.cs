namespace _03.P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string cmd;

            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while ((cmd = Console.ReadLine()) != "Sail")
            {
                string[] cmdArr = cmd.Split("||");

                string city = cmdArr[0];
                int population = int.Parse(cmdArr[1]);
                int gold = int.Parse(cmdArr[2]);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new List<int>());
                    cities[city].Add(population);
                    cities[city].Add(gold);
                }
                else
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }
                
            }

            string cmd2;

            while ((cmd2 = Console.ReadLine()) != "End")
            {
                string[] cmdArr2 = cmd2.Split("=>");

                string city = cmdArr2[1];

                if (cmdArr2[0] == "Plunder")
                {
                    int people = int.Parse(cmdArr2[2]);
                    int gold = int.Parse(cmdArr2[3]);

                    if (cities[city][0] - people <= 0 || cities[city][1] - gold <= 0)
                    {
                        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                        Console.WriteLine($"{city} has been wiped off the map!");

                        cities.Remove(city);
                    }
                    else
                    {
                        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                        cities[city][0] -= people;
                        cities[city][1] -= gold;
                    }
                }
                else if (cmdArr2[0] == "Prosper")
                {
                    int gold = int.Parse(cmdArr2[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[city][1] += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city][1]} gold.");
                    }

                }
               
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}