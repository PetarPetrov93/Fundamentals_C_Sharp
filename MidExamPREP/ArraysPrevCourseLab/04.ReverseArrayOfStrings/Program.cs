namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Array.Reverse(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}