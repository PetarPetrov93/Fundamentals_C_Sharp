﻿namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length -1 - i; j++)
                {

                    numbers[j] = numbers[j] + numbers[j + 1];

                }
            }


            Console.WriteLine(numbers[0]);
        }
    }
}