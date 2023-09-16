namespace _02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] laps = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double firstCarTime = 0;
            double secondCarTime = 0;

            for (int i = 0; i <= laps.Length/2-1; i++)
            {
                if (laps[i] == 0)
                {
                    firstCarTime *= 0.8;
                    continue;
                }
                firstCarTime += laps[i];
            }
            for (int i = laps.Length-1; i > laps.Length/2; i--)
            {
                if (laps[i] == 0)
                {
                    secondCarTime *= 0.8;
                    continue;
                }
                secondCarTime += laps[i];
            }
            if (firstCarTime < secondCarTime)
            {
                
                Console.WriteLine($"The winner is left with total time: {Math.Round(firstCarTime, 2)}");
            }
            else if (firstCarTime > secondCarTime)
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(secondCarTime, 2)}");
            }
            
        }
    }
}