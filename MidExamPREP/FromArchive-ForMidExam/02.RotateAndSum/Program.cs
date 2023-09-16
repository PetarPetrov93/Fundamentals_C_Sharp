namespace _02.RotateAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotationCycles = int.Parse(Console.ReadLine());
            int lastNum = 0;

            int[] summedNums = new int[nums.Length];
            

            for (int i = 0; i < rotationCycles; i++)
            {
                lastNum = nums[nums.Length-1];
                for (int j = nums.Length - 1 ; j >= 1; j--)
                {
                    nums[j] = nums[j-1];
                    summedNums[j] += nums[j];
                }
                nums[0] = lastNum;
                summedNums[0] += nums[0];
                
                
            }
            
            Console.WriteLine(string.Join(" ", summedNums));
        }
    }
}