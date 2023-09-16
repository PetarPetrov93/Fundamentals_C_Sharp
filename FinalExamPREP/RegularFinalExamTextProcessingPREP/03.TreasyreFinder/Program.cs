using System.Text;

namespace _03.TreasyreFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;
            StringBuilder treasure = new StringBuilder();

            while ((input = Console.ReadLine()) != "find")
            {
                for (int i = 0, j = 0; i < input.Length; i++, j++)
                {
                    
                    char symbolToAppend = (char)(input[i] - nums[j]);
                    treasure.Append(symbolToAppend);
                    if (j == nums.Length - 1)
                    {
                        j = -1;
                    }
                }
                int startingIndexOfTreasure = treasure.ToString().IndexOf('&') + 1;
                int endingIndexOfTreasure = treasure.ToString().LastIndexOf('&');
                int treasureLength = endingIndexOfTreasure - startingIndexOfTreasure;
                string treasureName = treasure.ToString().Substring(startingIndexOfTreasure, treasureLength);

                int startingIndexOfCoordinates = treasure.ToString().IndexOf('<') +1;
                int endingIndexOfCoordinates = treasure.ToString().IndexOf('>');
                int coordinatesLength = endingIndexOfCoordinates - startingIndexOfCoordinates;
                string coordinates = treasure.ToString().Substring(startingIndexOfCoordinates, coordinatesLength);
                Console.WriteLine($"Found {treasureName} at {coordinates}");
                treasure.Clear();
            }
            
        }
    }
}