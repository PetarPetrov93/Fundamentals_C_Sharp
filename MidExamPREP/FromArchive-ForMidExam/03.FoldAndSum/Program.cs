namespace _03.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] summedNums = new int[nums.Length/2];

            for (int i = 0; i < nums.Length / 4; i++)
            {
                summedNums[summedNums.Length / 2 - 1 - i] = nums[i] + nums[nums.Length / 2 - 1 - i];
            }
            for (int j = 0; j < nums.Length/4 ; j++)
            {
                summedNums[summedNums.Length / 2 + j] = nums[nums.Length/2 + j] + nums[nums.Length - 1 - j];
            }
            Console.WriteLine(string.Join(" ", summedNums));
        }
    }
}