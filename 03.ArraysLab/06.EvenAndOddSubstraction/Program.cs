namespace _06.EvenAndOddSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine( numbers.Where(x => x%2 == 0).Sum() - numbers.Where(x => x%2 != 0).Sum());
        }
    }
}