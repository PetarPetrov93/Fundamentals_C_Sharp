namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> numberOccurances = new SortedDictionary<int, int>();
            foreach (int number in numbers)
            {
                if (!numberOccurances.ContainsKey(number))
                {
                    numberOccurances.Add(number, 0);
                }
                numberOccurances[number]++;

            }
            
            foreach (var item in numberOccurances)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}