﻿namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;

            while (num>0)
            {
                digit = num % 10;
                num /= 10;
                sum += digit;

            }
            Console.WriteLine(sum);
        }
    }
}