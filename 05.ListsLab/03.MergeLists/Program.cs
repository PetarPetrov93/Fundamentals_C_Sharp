namespace _03.MergeLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mergedList = new List<int>();

            int minArray = Math.Min(list1.Count, list2.Count);
            int maxArray = Math.Max(list1.Count, list2.Count);

            for (int currentNum = 0; currentNum < minArray; currentNum++)
            {
                mergedList.Add(list1[currentNum]);
                mergedList.Add(list2[currentNum]);
                
            }
            for (int leftovers = minArray; leftovers < maxArray; leftovers++)
            {
                if (list1.Count > list2.Count)
                {
                    mergedList.Add(list1[leftovers]);
                }
                else
                {
                    mergedList.Add(list2[leftovers]);
                }
            }
            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}