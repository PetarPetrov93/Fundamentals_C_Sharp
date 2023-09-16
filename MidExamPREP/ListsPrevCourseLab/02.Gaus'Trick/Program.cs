namespace _02.Gaus_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers[i] += numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}