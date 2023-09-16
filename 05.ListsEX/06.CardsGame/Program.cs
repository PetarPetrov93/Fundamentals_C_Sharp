using System.Collections.Generic;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> plr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> plr2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (Math.Min(plr1.Count, plr2.Count) != 0)
            {
                int pl1Hand = plr1[0];
                int pl2Hand = plr2[0];

                if (pl1Hand == pl2Hand)
                {
                    plr1.RemoveAt(0);
                    plr2.RemoveAt(0);
                }
                else if (Math.Max(pl1Hand, pl2Hand) == pl1Hand)
                {
                    plr1.RemoveAt(0);
                    plr1.Add(pl1Hand);

                    plr2.RemoveAt(0);
                    plr1.Add(pl2Hand);
                }
                else if (Math.Max(pl1Hand, pl2Hand) == pl2Hand)
                {
                    plr2.RemoveAt(0);
                    plr2.Add(pl2Hand);

                    plr1.RemoveAt(0);
                    plr2.Add(pl1Hand);
                }
            }
            if (plr1.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {plr1.Sum()}");
            }
            else if (plr2.Count != 0)
            {
                Console.WriteLine($"Second player wins! Sum: {plr2.Sum()}");
            }
        }
    }
}