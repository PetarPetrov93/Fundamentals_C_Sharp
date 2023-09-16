namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (double num in numbers)
            {
                Console.WriteLine($"{num} => {(int)Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}