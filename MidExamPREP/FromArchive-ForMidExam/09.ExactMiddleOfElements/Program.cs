namespace _09.ExactMiddleOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers.Length % 2 == 0)
            {
                Console.WriteLine($"{numbers[numbers.Length/2 - 1]}, {numbers[numbers.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{numbers[numbers.Length / 2 - 1]}, {numbers[numbers.Length / 2]}, {numbers[numbers.Length / 2 + 1]}");
            }
        }
    }
}