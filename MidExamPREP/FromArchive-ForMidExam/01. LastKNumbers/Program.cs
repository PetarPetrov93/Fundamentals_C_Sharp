namespace _01._LastKNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLength = int.Parse(Console.ReadLine());
            int sumRange = int.Parse(Console.ReadLine());
            int[] sequence = new int[arrLength];
            sequence[0] = 1;

            for (int i = 1; i < arrLength; i++)
            {
                for (int j = sumRange; j > 0; j--)
                {

                    sequence[i] += sequence[i - j]; 
                    
                }
            }
            Console.WriteLine(string.Join(" ", sequence));

        }
    }
}