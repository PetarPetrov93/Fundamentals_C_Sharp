using System.Runtime.CompilerServices;

namespace _01.SmallestOfThreeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
        
            SmallestNum(a, b, c);
        }
        public static void SmallestNum(int x, int y, int z)
        {
            int smallestNumber = 0;
            if (x < y && x < z)
            {
                smallestNumber = x;
            }
            else if (y < x && y < z)
            {
                smallestNumber = y;
            }
            else if (z < x && z < y)
            {
                smallestNumber = z;
            }
            else
            {
                smallestNumber = x;
            }
            Console.WriteLine(smallestNumber);
        }
        
    }
}