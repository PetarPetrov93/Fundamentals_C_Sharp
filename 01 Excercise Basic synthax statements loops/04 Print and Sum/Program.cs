using System;

namespace _04_Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int finalNum = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startingNum; i <= finalNum; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
