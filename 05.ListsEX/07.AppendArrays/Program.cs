namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> finalList = new List<int>();

            foreach (var miniList in initialList)
            {
                List<int> newList = miniList.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                finalList.InsertRange(0, newList);

            }

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}