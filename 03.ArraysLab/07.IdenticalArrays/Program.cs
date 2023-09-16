namespace _07.IdenticalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool areIdentical = true;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areIdentical = false;
                    break;
                }

            }
            if (areIdentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {array1.Sum()}");
            }
        }
    }
}