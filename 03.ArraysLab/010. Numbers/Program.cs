namespace _010._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            double averageValue = (double)numbers.Average();

            TakeAllAboveAverage(numbers, averageValue);
        }
        static void TakeAllAboveAverage (int[] numbers, double averageValue) 
        {
            if (numbers.Count(x => x>averageValue) >= 5)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            else if (numbers.Count(x => x>averageValue) > 0 && numbers.Count(x => x > averageValue) < 5)
            {
                Array.Sort(numbers);
                Array.Reverse(numbers);
                Console.WriteLine(string.Join(" ", numbers.Where(x => x>averageValue)));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}