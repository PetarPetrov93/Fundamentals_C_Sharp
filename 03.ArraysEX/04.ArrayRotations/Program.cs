namespace _04.ArrayRotations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());
            int numToMove = 0;

            for (int i = 0; i < numOfRotations; i++)
            {
                numToMove = numbers[0];
                for (int j = 1; j < numbers.Length; j++)
                {                
                    numbers[j - 1] = numbers[j];  
                }
                numbers[numbers.Length - 1] = numToMove;
            }
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}