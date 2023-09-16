namespace _06.EvenAndOddSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sumEven += number;
            
                }
                else if (number % 2 != 0)
                {
                    sumOdd += number;
                }
            }
            Console.WriteLine(sumEven - sumOdd);

        }
    }
}