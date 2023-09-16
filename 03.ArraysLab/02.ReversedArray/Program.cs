namespace _02.ReversedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arrayNums = new int[input];

            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                arrayNums[i] = num;

            }
            Console.WriteLine(string.Join(" ", arrayNums.Reverse()));
        }
    }
}