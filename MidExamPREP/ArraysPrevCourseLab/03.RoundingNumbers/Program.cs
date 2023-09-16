namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double[] numbers = input.Split().Select(double.Parse).ToArray();

            //double[] test = Console.ReadLine().Split().Select(double.Parse).ToArray(); --> shorter way to write it

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}"); //casting to (int) was only for Judge, not needed otherwise

            }
            
        }
    }
}