namespace _00.FormulaForArraysAndListsLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int steps = int.Parse(Console.ReadLine());
            int initialIndex = int.Parse(Console.ReadLine());

            initialIndex = (initialIndex + steps) % numbers.Length;
            Console.WriteLine(numbers[initialIndex]);
        }
    }
}