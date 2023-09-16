namespace _02.NumbersInReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] numbers = new int[input];

            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());

                numbers[i] = num;
            }
           
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}