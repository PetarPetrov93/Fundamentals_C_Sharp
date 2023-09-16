namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int longestSequence = 0;
            int currentNum = 0;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }
                if (longestSequence < counter)
                {
                    longestSequence = counter;
                    currentNum = numbers[i];
                }
                counter = 1;
            }
            for (int i = 0; i < longestSequence; i++)
            {
                Console.Write(currentNum + " ");
            }
        }
    }
}