namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", numbers.Where(x => x%2 == 0).Sum()));
        }
    }
}