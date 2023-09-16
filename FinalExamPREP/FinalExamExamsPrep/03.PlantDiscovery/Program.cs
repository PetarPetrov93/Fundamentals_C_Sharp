namespace _03.PlantDiscovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UNFINISHED, The best approach is to use Dic<string, List<int>> and to use the list[0] for the rarity and list[1+...] for the ratings. In the end ratings should be casted to double!
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                
            }

            string cmd;

            while ((cmd = Console.ReadLine()) != "Exhibition")
            {
                
            }
 
        }
    }
}