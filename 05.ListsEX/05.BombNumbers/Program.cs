using System.Security.Cryptography.X509Certificates;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] numPow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bomb = numPow[0]; //containt the Bomb number
            int power = numPow[1]; // the power << and >> of the bomb
            while (input.Contains(bomb))
            {
                int bombIndex = input.IndexOf(bomb); // indentifying the index of the bomb in the List
                int start = bombIndex - power; // identifying the starting index which is the furthers number away (power) from the bomb
                if (start < 0) // checking of we are out of range on the left, if we are, we start from the 1st element
                {
                    start = 0;
                }

                int end = bombIndex + power; // identifying the ending index which is the furtherst away (power) from the bomb
                if (end > input.Count - 1) // checking if we are out of range on the right, if yes - we change the eding point
                {
                    end = input.Count - 1;
                }

                input.RemoveRange(start, end - start + 1); // cointing from the starting index to where we need to stop, adding 1 for the index of the bomb
            }

            Console.WriteLine(input.Sum());

        }
    }
}