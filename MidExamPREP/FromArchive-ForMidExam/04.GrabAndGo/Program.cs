namespace _04.GrabAndGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            if (numbers.Contains(number))
            {
                int lastIndexOfNumber = Array.LastIndexOf(numbers, number);

                for (int i = 0; i < lastIndexOfNumber; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}