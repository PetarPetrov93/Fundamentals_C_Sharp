using System;

namespace _08_Triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int row = 1; row <= num; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write($" {row}");
                }
                Console.WriteLine();
            }
        }
    }
}
