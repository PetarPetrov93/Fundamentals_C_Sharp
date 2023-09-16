namespace _06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int midNum = 0;
            bool areEqual = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == 0)
                    {
                        leftSum = 0;
                    }
                    else
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            leftSum += numbers[j];
                        }
                    }
                    
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        rightSum += numbers[k];
                    }
                    if (leftSum == rightSum)
                    {
                        areEqual = true;
                        midNum = i;
                    }
                    leftSum = 0;
                    rightSum = 0;

                }
                if (areEqual)
                {
                    Console.WriteLine(midNum);
                }
                else
                {
                    Console.WriteLine("no");
                }
            
            
        }
    }
}