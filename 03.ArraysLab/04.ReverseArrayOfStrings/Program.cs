namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(string.Join(" ", input.Reverse()));
        }
    }
}