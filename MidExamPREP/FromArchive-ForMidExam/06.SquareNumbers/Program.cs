namespace _06.SquareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sqrtNums = new List<int>();

            foreach (int num in numbers.Where(x => Math.Sqrt(x) % 1 == 0))
            {
                sqrtNums.Add(num);
            }
            sqrtNums.Sort();
            sqrtNums.Reverse();
            
            Console.WriteLine(string.Join(" ", sqrtNums));

        }
    }
}