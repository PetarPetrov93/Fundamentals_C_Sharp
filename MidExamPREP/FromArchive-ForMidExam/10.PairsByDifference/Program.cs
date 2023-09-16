namespace _10.PairsByDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                int currentNum = numbers[i];
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (Math.Abs(i - j) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}