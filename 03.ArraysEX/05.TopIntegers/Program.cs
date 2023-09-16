namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isGrater = true;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] <= input[j])
                    {
                        isGrater = false;
                        break;
                    }
                }
                if (isGrater)
                {

                    Console.Write(input[i] + " ");
                }
                isGrater = true;
            }
        }
    }
}