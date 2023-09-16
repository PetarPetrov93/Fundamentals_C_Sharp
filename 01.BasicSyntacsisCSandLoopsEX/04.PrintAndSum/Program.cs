namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingIndex = int.Parse(Console.ReadLine());
            int endingIndex = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            for (int i = startingIndex; i <= endingIndex; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = startingIndex; i <= endingIndex; i++)
            {
                sumOfNumbers += i;
            }
            Console.WriteLine($"Sum: {sumOfNumbers}");
        }
    }
}