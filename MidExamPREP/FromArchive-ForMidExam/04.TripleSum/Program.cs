namespace _04.TripleSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTriple = false;

            for (int a = 0; a < numbers.Length-1; a++)
            {
                for (int b = a+1; b < numbers.Length; b++)
                {
                    int sum = numbers[a] + numbers[b];
                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                        isTriple = true;
                    }
                }
            }
            if (!isTriple)
            {
                Console.WriteLine("No");
            }
        }
    }
}