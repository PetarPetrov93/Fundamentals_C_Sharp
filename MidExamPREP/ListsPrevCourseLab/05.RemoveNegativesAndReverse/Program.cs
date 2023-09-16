using System;
using System.Security.Cryptography.X509Certificates;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <0)
                {
                    numbers.Remove(numbers[i]);
                    i = -1;
                }
            }
            // Easier option than the above:
            //numbers.RemovaAll(n => n < 0);
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}