using System.Net;

namespace _03.DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;

            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();

            int totalDislikedMealsCount = 0;

            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] cmdArr = cmd.Split("-");
                string name = cmdArr[1];
                string meal = cmdArr[2];  

                if (cmdArr[0] == "Like")
                {
                    if (!guests.ContainsKey(name))
                    {
                        guests.Add(name, new List<string>());
                    }
                    if (!guests[name].Contains(meal))
                    {
                        guests[name].Add(meal);
                    }
                }
                else if (cmdArr[0] == "Dislike")
                {
                    if (guests.ContainsKey(name) && guests[name].Contains(meal))
                    {
                        totalDislikedMealsCount++;
                        guests[name].Remove(meal);
                        Console.WriteLine($"{name} doesn't like the {meal}.");
                    }
                    else if (!guests.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} is not at the party.");
                    }
                    else if (!guests[name].Contains(meal))
                    {
                        Console.WriteLine($"{name} doesn't have the {meal} in his/her collection.");
                    }
                }
            }
            foreach (var guest in guests)
            {
                Console.Write($"{guest.Key}: ");
                
                Console.WriteLine(string.Join(", ", guest.Value));
 
            }
            Console.WriteLine($"Unliked meals: {totalDislikedMealsCount}");
        }
    }
}