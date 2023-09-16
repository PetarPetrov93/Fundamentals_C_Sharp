namespace _01.LagrestCommonEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            int match = 0;
            int longestSequence = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    match++;
                    if (longestSequence < match)
                    {
                        longestSequence = match;
                    }
                }
                else
                {
                    match = 0;
                }
            }
            for (int i = arr1.Length-1, j = arr2.Length-1; i >= 0 && j >=0; i--, j--)
            {
                if (arr1[i] == arr2[j])
                {
                    match++;
                    if (longestSequence < match)
                    {
                        longestSequence = match;
                    }
                }
                else
                {
                    match = 0;
                }
            }
            Console.WriteLine(longestSequence);
        }
    }
}