namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            foreach (int i in input)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}